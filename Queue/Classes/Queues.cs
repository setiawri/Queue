using System;
using System.Data;
using LIBUtil;

namespace Queue
{
    public class Queues
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid QueueCategories_Id;
        public string QueueCategories_Code;
        public DateTime Timestamp;
        public int No;
        public DateTime CallTimestamp;
        public Guid CounterAddresses_Id;
        public string CounterAddresses_Name;
        public DateTime? VoidTimestamp;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_QueueCategories_Id = "QueueCategories_Id";
        public const string COL_DB_QueueCategories_Code = "QueueCategories_Code";
        public const string COL_DB_Timestamp = "Timestamp";
        public const string COL_DB_CallTimestamp = "CallTimestamp";
        public const string COL_DB_No = "No";
        public const string COL_DB_CounterAddresses_Id = "CounterAddresses_Id";
        public const string COL_DB_CounterAddresses_Name = "CounterAddresses_Name";
        public const string COL_DB_VoidTimestamp = "VoidTimestamp";

        public const string COL_CallNo = "CallNo";
        public const string COL_WaitTime = "WaitTime";
        public const string FILTER_CalledOnly = "FILTER_CalledOnly";
        public const string FILTER_TopCount = "FILTER_TopCount";
        public const string FILTER_StartDate = "FILTER_StartDate";
        public const string FILTER_EndDate = "FILTER_EndDate";
        public const string FILTER_QueueNoCutoffTimestamp = "FILTER_QueueNoCutoffTimestamp";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Queues(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            QueueCategories_Id = Util.wrapNullable<Guid>(row, COL_DB_QueueCategories_Id);
            QueueCategories_Code = Util.wrapNullable<string>(row, COL_DB_QueueCategories_Code);
            Timestamp = Util.wrapNullable<DateTime>(row, COL_DB_Timestamp);
            No = Util.wrapNullable<int>(row, COL_DB_No);
            CounterAddresses_Id = Util.wrapNullable<Guid>(row, COL_DB_CounterAddresses_Id);
            CounterAddresses_Name = Util.wrapNullable<string>(row, COL_DB_CounterAddresses_Name);
            VoidTimestamp = Util.wrapNullable<DateTime?>(row, COL_DB_VoidTimestamp);
        }

        public Queues() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static string add(Guid queueCategoryId, DateTime? QueueNoCutoffTimestamp)
        {
            Guid Id = Guid.NewGuid();
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                true, false, false, false, false,
                "Queues_add",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                new SqlQueryParameter(COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier, queueCategoryId),
                new SqlQueryParameter(FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime, Util.wrapNullable(QueueNoCutoffTimestamp))
                );

            if (result.IsSuccessful)
                return result.ValueString;
            else
                return null;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(false, id, null, null)); }
        public static DataTable get(bool calledOnly, Guid? id, Guid? queueCategoryId, int? topCount) { return get(calledOnly, id, queueCategoryId, topCount, null, null, null); }
        public static DataTable get(bool calledOnly, Guid? id, Guid? queueCategoryId, int? topCount, DateTime? startDate, DateTime? endDate, DateTime? QueueNoCutoffTimestamp)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.FillByAdapter,
                "Queues_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier, queueCategoryId),
                new SqlQueryParameter(FILTER_CalledOnly, SqlDbType.Bit, calledOnly),
                new SqlQueryParameter(FILTER_TopCount, SqlDbType.Int, topCount),
                new SqlQueryParameter(FILTER_StartDate, SqlDbType.DateTime, Util.wrapNullable(startDate)),
                new SqlQueryParameter(FILTER_EndDate, SqlDbType.DateTime, Util.wrapNullable(endDate)),
                new SqlQueryParameter(FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime, Util.wrapNullable(QueueNoCutoffTimestamp))
            );
            return result.Datatable;
        }

        public static DataTable getLastCalledForEachCounter()
        {
            SqlQueryResult result = DBConnection.query(
                false, DBConnection.ActiveSqlConnection,
                QueryTypes.FillByAdapter,
                "Queues_getlastcalledforeachcounter"
            );
            return result.Datatable;
        }

        public static string callNext(Guid QueueCategories_Id, Guid CounterAddresses_Id)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                true, false, false, false, false,
                "Queues_callNext",
                new SqlQueryParameter(COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier, QueueCategories_Id),
                new SqlQueryParameter(COL_DB_CounterAddresses_Id, SqlDbType.UniqueIdentifier, CounterAddresses_Id)
                );

            if (result.IsSuccessful)
                return result.ValueString;
            else
                return null;
        }

        public static void call(Guid Id, Guid CounterAddresses_Id)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Queues_call",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Id),
                new SqlQueryParameter(COL_DB_CounterAddresses_Id, SqlDbType.UniqueIdentifier, CounterAddresses_Id)
            );
        }

        public static void deleteAll()
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Queues_delete_all"
            );
        }

        public static void update_VoidTimestamp(DateTime? QueueNoCutoffTimestamp)
        {
            SqlQueryResult result = DBConnection.query(
                false,
                DBConnection.ActiveSqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Queues_update_VoidTimestamp",
                new SqlQueryParameter(FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime, Util.wrapNullable(QueueNoCutoffTimestamp))
            );
        }

        public static void resetQueueNumber()
        {
            if (Util.displayMessageBoxYesNo("Konfirmasi nomor antrian akan di RESET?"))
            {
                DateTime cutofftime = DateTime.Now;
                Settings.QueueNoCutoffTimestamp = cutofftime;
                update_VoidTimestamp(cutofftime);
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public static void populateDropDownList(LIBUtil.Desktop.UserControls.Dropdownlist dropdownlist, bool calledOnly, int? lastQueueCount)
        {
            dropdownlist.populate(get(calledOnly, null, null, lastQueueCount), COL_CallNo, COL_DB_Id, null);
        }

        public static void clearQueueIfStartOfDay()
        {
            DataTable datatable = Queues.get(true, null, null, 1);
            if (datatable.Rows.Count > 0)
            {
                DateTime lastdate = Util.wrapNullable<DateTime>(datatable.Rows[0], Queues.COL_DB_Timestamp);
                if (lastdate.Date < DateTime.Now.Date)
                    Queues.deleteAll();
            }
        }

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}
