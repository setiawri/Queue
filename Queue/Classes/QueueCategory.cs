using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace Queue
{
    public class QueueCategory
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Code;
        public string Description;
		public bool Active;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Code = "Code";
        public const string COL_DB_Description = "Description";
        public const string COL_DB_Active = "Active";

        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";
        public const string COL_QueueCount = "QueueCount";
        public const string COL_RequestText = "RequestText";
        public const string COL_CallerText = "CallerText";
        public const string COL_CalledCount = "CalledCount";
        public const string COL_LastCalledNo = "LastCalledNo";
        public const string COL_PendingCount = "PendingCount";
        public const string COL_WaitTime = "WaitTime";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS
		
        public QueueCategory(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            Code = Util.wrapNullable<string>(row, COL_DB_Code);
            Description = Util.wrapNullable<string>(row, COL_DB_Description);
            Active = Util.wrapNullable<bool>(row, COL_DB_Active);
        }

        public QueueCategory() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static void add(string code, string description)
        {
            Guid id = Guid.NewGuid();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("QueueCategories_add", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                    cmd.Parameters.Add("@" + COL_DB_Code, SqlDbType.NVarChar).Value = code;
                    cmd.Parameters.Add("@" + COL_DB_Description, SqlDbType.NVarChar).Value = description;

                    if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
                    cmd.ExecuteNonQuery();

                    //ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(true, id, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? id, string code, string description)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("QueueCategories_get", sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_FILTER_IncludeInactive, SqlDbType.Bit).Value = filterIncludeInactive;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = Util.wrapNullable(id);
                    cmd.Parameters.Add("@" + COL_DB_Code, SqlDbType.NVarChar).Value = Util.wrapNullable(code);
                    cmd.Parameters.Add("@" + COL_DB_Description, SqlDbType.NVarChar).Value = Util.wrapNullable(description);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(datatable);
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return datatable;
        }

        public static void update(Guid id, string code, string description)
        {
            try
            {
                QueueCategory objOld = new QueueCategory(id);
                string log = "";
                log = Util.appendChange(log, objOld.Code, code, "Code: '{0}' to '{1}'");
                log = Util.appendChange(log, objOld.Description, description, "Description: '{0}' to '{1}'");
				
                if (string.IsNullOrEmpty(log))
                {
                    Util.displayMessageBoxError("No changes to record");
                }
                else
                {
					using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
					using (SqlCommand cmd = new SqlCommand("QueueCategories_update", sqlConnection))
					{
						cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                        cmd.Parameters.Add("@" + COL_DB_Code, SqlDbType.NVarChar).Value = Util.wrapNullable(code);
                        cmd.Parameters.Add("@" + COL_DB_Description, SqlDbType.NVarChar).Value = Util.wrapNullable(description);

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

        public static string updateActiveStatus(Guid id, bool active)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("QueueCategories_update_Active", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                    cmd.Parameters.Add("@" + COL_DB_Active, SqlDbType.Bit).Value = active;

                    if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    
                    //ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + active);
                }
            } catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return string.Empty;
        }

        public static string delete(Guid id)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("QueueCategories_delete", sqlConnection))
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

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}
