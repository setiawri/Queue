﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace Queue
{
    public class Settings
    {
        public static bool CallerDisplay_Locked = false;

        public static string CONNECTIONSTRING_DEFAULTPARAMS = "Integrated Security=False;Persist Security Info=False;";
        public const string SQL_USERNAME = "queuelogin";
        public const string SQL_PASSWORD = "q1w2e3r4t";

        private const int DEFAULTADINTERVAL = 5000;
        private static Guid GUID_AdFolder = new Guid("534E59FF-AEC7-4EB9-8F1F-1C9D089637AA");
        private static Guid GUID_ShowAdAsDefault = new Guid("589B1BE4-71D5-4581-A403-38267D6DCBE6");
        private static Guid GUID_AdInterval = new Guid("FE22F341-3184-4B72-A104-06116B6CC9F5");

        private const int DEFAULTREFRESHINTERVAL = 5000;
        private static Guid GUID_RefreshInterval = new Guid("91AB58DF-B603-4CEC-B110-3DA284F11754");

        private const int DEFAULTREQUESTGRIDWIDTH = 300;
        private static Guid GUID_RequestGridWidth = new Guid("3ECA9E21-5C4C-4F7C-8740-5368E4E09CAF");

        private const int DEFAULTFONTSIZE = 27;
        private static Guid GUID_DisplayFontSize = new Guid("89D84A55-40A1-48D5-A1F4-41DF1F2FB722");

        private const int DEFAULTDISPLAYGRIDWIDTH = 300;
        private static Guid GUID_DisplayGridWidth = new Guid("D1B3020F-607A-40EF-8B5E-43CA76091D39");

        private const int DEFAULTPRINTAREAWIDTH = 300;
        private static Guid GUID_PrintAreaWidth = new Guid("081E5A09-1967-44cb-AA29-0D0E0D828F33");

        private static Guid GUID_HeaderText = new Guid("93A34F27-052C-4DB0-A4BA-42108572BB5C");

        private const int DEFAULTROLLINGTEXTSPEED = 2;
        public const int ROLLINGTEXTTIMERINTERVAL = 1;
        private static Guid GUID_RollingText = new Guid("e9232297-ef13-413a-b9af-2b78aea65832");
        private static Guid GUID_RollingTextSpeed = new Guid("1c250e10-3582-4ed2-b8ea-845e2735bbc0");

        private const int DEFAULTDISPLAYFORMMODE = 1;
        private static Guid GUID_DisplayFormMode = new Guid("{E9DB78A0-901B-42F9-BAB8-EA403003F362}");
        
        public static System.Media.SoundPlayer notificationSound = new System.Media.SoundPlayer(Properties.Resources.Notification);

        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public const string USERACCOUNTS_TEMPORARYPASSWORD = "qwerty";

        /// <summary><para></para></summary>
        public static int DisplayFormMode
        {
            get { return getIntValue(GUID_DisplayFormMode, DEFAULTDISPLAYFORMMODE); }
            set { update(GUID_DisplayFormMode, value, null); }
        }

        /// <summary><para></para></summary>
        public static int AdInterval
        {
            get { return getIntValue(GUID_AdInterval, DEFAULTADINTERVAL); }
            set { update(GUID_AdInterval, value, null); }
        }

        /// <summary><para></para></summary>
        public static bool ShowAdAsDefault
        {
            get { return Convert.ToBoolean(getIntValue(GUID_ShowAdAsDefault, 0)); }
            set { update(GUID_ShowAdAsDefault, Convert.ToInt32(value), null); }
        }

        /// <summary><para></para></summary>
        public static string AdFolder
        {
            get { return getStringValue(GUID_AdFolder); }
            set { update(GUID_AdFolder, null, value); }
        }

        /// <summary><para></para></summary>
        public static int RefreshInterval
        {
            get { return getIntValue(GUID_RefreshInterval, DEFAULTREFRESHINTERVAL); }
            set { update(GUID_RefreshInterval, value, null); }
        }

        /// <summary><para></para></summary>
        public static int RequestGridWidth
        {
            get { return getIntValue(GUID_RequestGridWidth, DEFAULTREQUESTGRIDWIDTH); }
            set { update(GUID_RequestGridWidth, value, null); }
        }

        /// <summary><para></para></summary>
        public static int DisplayFontSize
        {
            get {
                int size = getIntValue(GUID_DisplayFontSize, DEFAULTFONTSIZE);
                if (size < 1)
                    size = DisplayFontSize = 1;
                return size;
            }
            set { update(GUID_DisplayFontSize, value, null); }
        }

        /// <summary><para></para></summary>
        public static int DisplayGridWidth
        {
            get { return getIntValue(GUID_DisplayGridWidth, DEFAULTDISPLAYGRIDWIDTH); }
            set { update(GUID_DisplayGridWidth, value, null); }
        }

        /// <summary><para></para></summary>
        public static int PrintAreaWidth
        {
            get { return getIntValue(GUID_PrintAreaWidth, DEFAULTPRINTAREAWIDTH); }
            set { update(GUID_PrintAreaWidth, value, null); }
        }

        /// <summary><para></para></summary>
        public static string HeaderText
        {
            get { return getStringValue(GUID_HeaderText); }
            set { update(GUID_HeaderText, null, value); }
        }

        /// <summary><para></para></summary>
        public static string RollingText
        {
            get { return getStringValue(GUID_RollingText); }
            set { update(GUID_RollingText, null, value); }
        }

        /// <summary><para></para></summary>
        public static int RollingTextSpeed
        {
            get { return getIntValue(GUID_RollingTextSpeed, DEFAULTROLLINGTEXTSPEED); }
            set { update(GUID_RollingTextSpeed, value, null); }
        }

        private static int getIntValue(Guid GUID, int defaultValue)
        {
            DataRow row = get(GUID);
            if (row == null)
                return defaultValue;
            else
                return Convert.ToInt32(row[COL_DB_Value_Int]);
        }

        private static string getStringValue(Guid GUID)
        {
            DataRow row = get(GUID);
            if (row == null)
                return "";
            else
                return row[COL_DB_Value_String].ToString();
        }

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Value_Int = "Value_Int";
        public const string COL_DB_Value_String = "Value_String";

        #endregion DATABASE FIELDS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static DataRow get(Guid? id)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("Settings_get", sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = Util.wrapNullable(id);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(datatable);
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            return Util.getFirstRow(datatable);
        }

        public static void update(Guid id, int? intValue, string stringValue)
        {
            //Settings objOld = new Settings(id);
            //string log = "";
            //if (intValue != null)
            //    log = Util.appendChange(log, objOld.Notes, intValue.ToString(), "Notes: '{0}' to '{1}'");
            //else
            //    log = Util.appendChange(log, objOld.Notes, intValue.ToString(), "Notes: '{0}' to '{1}'");            

            //if (string.IsNullOrEmpty(log))
            //{
            //    Util.displayMessageBoxError("No changes to record");
            //}
            //else
            //{
                try
                {
                    using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
                    using (SqlCommand cmd = new SqlCommand("Settings_update", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = id;
                        cmd.Parameters.Add("@" + COL_DB_Value_Int, SqlDbType.Int).Value = Util.wrapNullable(intValue);
                        cmd.Parameters.Add("@" + COL_DB_Value_String, SqlDbType.NVarChar).Value = Util.wrapNullable(stringValue);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        //ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                    }
                    //Util.displayMessageBoxSuccess("Changes updated");
                }
                catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }
            //}
        }        

        #endregion DATABASE METHODS
        /*******************************************************************************************************/

    }
}