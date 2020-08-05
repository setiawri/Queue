using System;
using System.Data;
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

        public static Guid? add(string name, string IPAddress, DefaultForms defaultForm)
        {
            Guid Id = Guid.NewGuid();
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "CounterAddresses_add",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                new SqlQueryParameter(COL_DB_IPAddress, SqlDbType.NVarChar, IPAddress),
                new SqlQueryParameter(COL_DB_DefaultForms_enumid, SqlDbType.TinyInt, defaultForm)
            );

            if (!result.IsSuccessful)
                return null;
            else
                return Id;
        }

        public static DataTable get() { return get(null, null, null); }
        public static DataRow get(Guid id) { return Util.getFirstRow(get(id, null, null)); }
        public static DataRow get(string ipAddress) { return Util.getFirstRow(get(null, null, ipAddress)); }
        public static DataTable get(Guid? id, string name, string ipAddress)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.FillByAdapter,
                "CounterAddresses_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name)),
                new SqlQueryParameter(COL_DB_IPAddress, SqlDbType.NVarChar, Util.wrapNullable(ipAddress))
            );

            return Util.parseEnum<DefaultForms>(result.Datatable, COL_DefaultForms_description, COL_DB_DefaultForms_enumid);
        }

        public static string getNameByIPAddress(string ipAddress)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                true, false, false, false, false,
                "CounterAddresses_get_Name_by_IPAddress",
                new SqlQueryParameter(COL_DB_IPAddress, SqlDbType.NVarChar, Util.wrapNullable(ipAddress))
                );

            if (result.IsSuccessful)
                return result.ValueString;
            else
                return null;
        }

        public static void update(Guid Id, string name, string ipAddress, DefaultForms defaultForm)
        {
            CounterAddress objOld = new CounterAddress(Id);
            string log = "";
            log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.IPAddress, ipAddress, "IP Address: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.DefaultForms_description, Util.GetEnumDescription(defaultForm), "Default Form: '{0}' to '{1}'");

            if (!string.IsNullOrEmpty(log))
            {
                SqlQueryResult result = DBConnection.query(
                    false,
                    DBConnection.ActiveSqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "CounterAddresses_update",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name)),
                    new SqlQueryParameter(COL_DB_IPAddress, SqlDbType.NVarChar, Util.wrapNullable(ipAddress)),
                    new SqlQueryParameter(COL_DB_DefaultForms_enumid, SqlDbType.TinyInt, defaultForm)
                );
            }
        }

        public static void delete(Guid Id)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "CounterAddresses_delete",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id)
            );
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
