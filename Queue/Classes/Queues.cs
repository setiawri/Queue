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
            Guid id = Guid.NewGuid();
            string printString = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Queues_add", DBConnection.ActiveSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                    cmd.Parameters.Add("@" + COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier).Value = queueCategoryId;
                    cmd.Parameters.Add("@" + FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime).Value = Util.wrapNullable(QueueNoCutoffTimestamp);
                    SqlParameter return_value = cmd.Parameters.Add("@" + COL_CallNo, SqlDbType.NVarChar, -1);
                    return_value.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    printString = return_value.Value.ToString();

                    //ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return printString;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get_withtrycatch(false, id, null, null)); }

        public static DataTable get_withtrycatch(bool calledOnly, Guid? id, Guid? queueCategoryId, int? topCount)
        {
            DataTable datatable = new DataTable();

            try
            {
                datatable = get(calledOnly, id, queueCategoryId, topCount, null, null, null);
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return datatable;
        }

        public static DataTable get(bool calledOnly, Guid? id, Guid? queueCategoryId, int? topCount, DateTime? startDate, DateTime? endDate, DateTime? QueueNoCutoffTimestamp)
        {
            DataTable datatable = new DataTable();

            using (SqlCommand cmd = new SqlCommand("Queues_get", DBConnection.ActiveSqlConnection))
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = Util.wrapNullable(id);
                cmd.Parameters.Add("@" + COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier).Value = queueCategoryId;
                cmd.Parameters.Add("@" + FILTER_CalledOnly, SqlDbType.Bit).Value = calledOnly;
                cmd.Parameters.Add("@" + FILTER_TopCount, SqlDbType.Int).Value = topCount;
                cmd.Parameters.Add("@" + FILTER_StartDate, SqlDbType.DateTime).Value = Util.wrapNullable(startDate);
                cmd.Parameters.Add("@" + FILTER_EndDate, SqlDbType.DateTime).Value = Util.wrapNullable(endDate);
                cmd.Parameters.Add("@" + FILTER_QueueNoCutoffTimestamp, SqlDbType.DateTime).Value = Util.wrapNullable(QueueNoCutoffTimestamp);

                adapter.SelectCommand = cmd;
                adapter.Fill(datatable);
            }

            return datatable;
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
            string calledNumber = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Queues_callNext", DBConnection.ActiveSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_QueueCategories_Id, SqlDbType.UniqueIdentifier).Value = QueueCategories_Id;
                    cmd.Parameters.Add("@" + COL_DB_CounterAddresses_Id, SqlDbType.UniqueIdentifier).Value = CounterAddresses_Id;
                    SqlParameter Queues_No = cmd.Parameters.Add("@Queues_No", SqlDbType.VarChar, 100);
                    Queues_No.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    calledNumber = Queues_No.Value.ToString();
                    //ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + active);
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return calledNumber;
        }

        public static void call(Guid id, Guid CounterAddresses_Id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Queues_call", DBConnection.ActiveSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                    cmd.Parameters.Add("@" + COL_DB_CounterAddresses_Id, SqlDbType.UniqueIdentifier).Value = CounterAddresses_Id;

                    cmd.ExecuteNonQuery();

                    //ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + active);
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
        }

        public static void deleteAll()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Queues_delete_all", DBConnection.ActiveSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    //ActivityLog.add(sqlConnection, userAccountID, id, "Deleted");
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
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

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public static void populateDropDownList(LIBUtil.Desktop.UserControls.Dropdownlist dropdownlist, bool calledOnly, int? lastQueueCount)
        {
            dropdownlist.populate(get_withtrycatch(calledOnly, null, null, lastQueueCount), COL_CallNo, COL_DB_Id, null);
        }

        public static void clearQueueIfStartOfDay()
        {
            DataTable datatable = Queues.get_withtrycatch(true, null, null, 1);
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
