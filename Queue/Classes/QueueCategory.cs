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

        public const string FILTER_QueueNoCutoffTimestamp = "FILTER_QueueNoCutoffTimestamp";

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
            Guid Id = Guid.NewGuid();
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "QueueCategories_add",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                new SqlQueryParameter(COL_DB_Code, SqlDbType.NVarChar, code),
                new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, description)
            );

            //if (result.IsSuccessful)
            //    ActivityLog.submit(Id, "Added");
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(true, id, null, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? Id, string Code, string Description, DateTime? QueueNoCutoffTimestamp)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.FillByAdapter,
                "QueueCategories_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Id)),
                new SqlQueryParameter(COL_DB_Code, SqlDbType.NVarChar, Util.wrapNullable(Code)),
                new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, Util.wrapNullable(Description)),
                new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.BigInt, Util.wrapNullable(filterIncludeInactive)),
                new SqlQueryParameter(FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime, Util.wrapNullable(QueueNoCutoffTimestamp))
                );
            return result.Datatable;
        }

        public static void update(Guid Id, string Code, string Description)
        {
            QueueCategory objOld = new QueueCategory(Id);
            string log = "";
            log = Util.appendChange(log, objOld.Code, Code, "Code: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Description, Description, "Description: '{0}' to '{1}'");
				
            if (string.IsNullOrEmpty(log))
            {
                Util.displayMessageBoxError("No changes to record");
            }
            else
            {
                SqlQueryResult result = DBConnection.query(
                    false,
                    DBConnection.ActiveSqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "QueueCategories_update",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                    new SqlQueryParameter(COL_DB_Code, SqlDbType.NVarChar, Util.wrapNullable(Code)),
                    new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, Util.wrapNullable(Description))
                );

                //if (result.IsSuccessful)
                //    ActivityLog.submit(Id, String.Format("Updated: {0}", log));

            }
        }

        public static void updateActiveStatus(Guid Id, bool Value)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "QueueCategories_update_Active",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, Value)
            );

            //if (result.IsSuccessful)
            //    ActivityLog.submit(Id, String.Format("Completed changed to: {0}", Value));
        }

        public static void delete(Guid Id)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "QueueCategories_delete",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id)
            );

            //if (result.IsSuccessful)
            //    ActivityLog.submit(Id, String.Format("Completed changed to: {0}", Value));
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}
