using System;

using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using System.ComponentModel;

namespace Queue
{
    public enum DefaultForms
    {
        [Description("COUNTER")]
        COUNTER,
        [Description("PRINTER")]
        PRINTER,
        [Description("TV Monitor")]
        TVMonitor,
    }

    public class CounterAddress
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Name = "";
        public string IPAddress;
        public DefaultForms DefaultForms_enum;

        public string DefaultForms_description;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Name = "Name";
        public const string COL_DB_IPAddress = "IPAddress";
        public const string COL_DB_DefaultForms_enumid = "DefaultForms_enumid";

        public const string COL_DefaultForms_description = "DefaultForms_description";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public CounterAddress(string ipAddress):this(null, ipAddress) { }
        public CounterAddress(Guid id):this(id, null) { }
        public CounterAddress(Guid? id, string ipAddress)
        {
            DataRow row;
            if (id != null)
                row = get((Guid)id);
            else
                row = get(ipAddress);

            IPAddress = ipAddress;
            if (row != null)
            {
                Id = Util.wrapNullable<Guid>(row, COL_DB_Id);
                IPAddress = Util.wrapNullable<string>(row, COL_DB_IPAddress);
                Name = Util.wrapNullable<string>(row, COL_DB_Name);
                DefaultForms_enum = Util.parseEnum<DefaultForms>(Util.wrapNullable<int>(row, COL_DB_DefaultForms_enumid));

                DefaultForms_description = Util.wrapNullable<string>(row, COL_DefaultForms_description);
            }
        }

        public CounterAddress() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static void add(string name, string IPAddress, DefaultForms defaultForm)
        {
            Guid id = Guid.NewGuid();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("CounterAddresses_add", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                    cmd.Parameters.Add("@" + COL_DB_Name, SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@" + COL_DB_IPAddress, SqlDbType.NVarChar).Value = IPAddress;
                    cmd.Parameters.Add("@" + COL_DB_DefaultForms_enumid, SqlDbType.TinyInt).Value = defaultForm;

                    if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
                    cmd.ExecuteNonQuery();

                    //ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
        }

        public static DataTable get() { return get(null, null, null); }
        public static DataRow get(Guid id) { return Util.getFirstRow(get(id, null, null)); }
        public static DataRow get(string ipAddress) { return Util.getFirstRow(get(null, null, ipAddress)); }
        public static DataTable get(Guid? id, string name, string ipAddress)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("CounterAddresses_get", sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = Util.wrapNullable(id);
                    cmd.Parameters.Add("@" + COL_DB_Name, SqlDbType.NVarChar).Value = Util.wrapNullable(name);
                    cmd.Parameters.Add("@" + COL_DB_IPAddress, SqlDbType.NVarChar).Value = Util.wrapNullable(ipAddress);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(datatable);
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            Util.parseEnum<DefaultForms>(datatable, COL_DefaultForms_description, COL_DB_DefaultForms_enumid);

            return datatable;
        }

        public static string getNameByIPAddress(string ipAddress)
        {
            DataTable datatable = new DataTable();
            string name = "";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("CounterAddresses_get_Name_by_IPAddress", sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_IPAddress, SqlDbType.NVarChar).Value = Util.wrapNullable(ipAddress);
                    SqlParameter return_value = cmd.Parameters.Add("@" + COL_DB_Name, SqlDbType.NVarChar, -1);
                    return_value.Direction = ParameterDirection.Output;

                    if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
                    cmd.ExecuteNonQuery();

                    name = return_value.Value.ToString();
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return name;
        }

        public static void update(Guid id, string name, string ipAddress, DefaultForms defaultForm)
        {
            try
            {
                CounterAddress objOld = new CounterAddress(id);
                string log = "";
                log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
                log = Util.appendChange(log, objOld.IPAddress, ipAddress, "IP Address: '{0}' to '{1}'");
                log = Util.appendChange(log, objOld.DefaultForms_description, Util.GetEnumDescription(defaultForm), "Default Form: '{0}' to '{1}'");

                if (string.IsNullOrEmpty(log))
                {
                    Util.displayMessageBoxError("No changes to record");
                }
                else
                {
					using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
					using (SqlCommand cmd = new SqlCommand("CounterAddresses_update", sqlConnection))
					{
						cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                        cmd.Parameters.Add("@" + COL_DB_Name, SqlDbType.NVarChar).Value = Util.wrapNullable(name);
                        cmd.Parameters.Add("@" + COL_DB_IPAddress, SqlDbType.NVarChar).Value = Util.wrapNullable(ipAddress);
                        cmd.Parameters.Add("@" + COL_DB_DefaultForms_enumid, SqlDbType.TinyInt).Value = defaultForm;

                        if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
						cmd.ExecuteNonQuery();
					
						//ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                    
						//notify supervisor role
						//if (new UserAccount(userAccountID).UserRole != UserAccountRoles.Supervisor)
						//  add row to Notifications table
					}
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
        }

        public static string delete(Guid id)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("CounterAddresses_delete", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;

                    if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    
                    //ActivityLog.add(sqlConnection, userAccountID, id, "Deleted");
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return string.Empty;
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public bool isValidCounter()
        {
            Helper.counter = new CounterAddress(LIBUtil.Util.getIPv4());
            return !string.IsNullOrEmpty(Helper.counter.Name);
        }

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}
