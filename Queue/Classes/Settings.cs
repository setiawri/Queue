using System;

namespace Queue
{
    public class Settings
    {
        public const string USERACCOUNTS_TEMPORARYPASSWORD = "qwerty";
        public const bool SQLCONNECTION_MULTIPLEUSE = false;

        /*******************************************************************************************************/
        #region APP VERSION

        public const string APPVERSION = "v200427";
        private static Guid GUID_LatestAppVersion = new Guid("C1552CB9-E157-4925-897E-904180379BFE");

        public static string LatestAppVersion 
        { 
            get { return LIBUtil.Settings.getStringValue(GUID_LatestAppVersion); } 
            set { LIBUtil.Settings.update(GUID_LatestAppVersion, value); } 
        }

        public static bool hasLatestAppVersion()
        {
            if (LatestAppVersion == APPVERSION)
                return true;
            else if (String.Compare(LatestAppVersion, APPVERSION) < 0)
            {
                LatestAppVersion = APPVERSION;
                return true;
            }
            else
                return false;
        }

        #endregion APP VERSION
        /*******************************************************************************************************/

        public static bool CallerDisplay_Locked = false;

        //DB CONNECTION
        public static string CONNECTIONSTRING_DEFAULTPARAMS = "Integrated Security=False;Persist Security Info=False;";
        public const string SQL_USERNAME = "queuelogin";
        public const string SQL_PASSWORD = "q1w2e3r4t";

        //DATA QUERY REFRESH INTERVAL
        private const int DEFAULTREFRESHINTERVAL = 5000;
        private static Guid GUID_RefreshInterval = new Guid("91AB58DF-B603-4CEC-B110-3DA284F11754");

        //ADVERTISEMENT
        private const int DEFAULTADINTERVAL = 5000;
        private static Guid GUID_AdFolder = new Guid("534E59FF-AEC7-4EB9-8F1F-1C9D089637AA");
        private static Guid GUID_ShowAdAsDefault = new Guid("589B1BE4-71D5-4581-A403-38267D6DCBE6");
        private static Guid GUID_AdInterval = new Guid("FE22F341-3184-4B72-A104-06116B6CC9F5");
        
        //SOUND
        private static Guid GUID_SoundFolder = new Guid("CE745060-2503-4733-94D8-FB1F8D710B78");
        private static Guid GUID_TransitionSoundFile = new Guid("B85BA6CD-120D-491F-AF39-E36B4D07CF57");
        private static Guid GUID_CallFormat_PlayNotificationSound = new Guid("CB500BA5-7FA6-4864-90EC-DC3EA5CF9A4E");
        private static Guid GUID_CallFormat_PlayCounter = new Guid("8B2F3B4E-0E1B-4985-BC17-E90948C4860D");

        public static System.Media.SoundPlayer notificationSound = new System.Media.SoundPlayer(Properties.Resources.Notification);

        //COUNTER WIDTH SIZE
        private const int DEFAULTREQUESTGRIDWIDTH = 300;
        private static Guid GUID_RequestGridWidth = new Guid("3ECA9E21-5C4C-4F7C-8740-5368E4E09CAF");

        //DISPLAY
        private const int DEFAULTFONTSIZE = 27;
        private static Guid GUID_DisplayFontSize = new Guid("89D84A55-40A1-48D5-A1F4-41DF1F2FB722");

        private const int DEFAULTDISPLAYGRIDWIDTH = 300;
        private static Guid GUID_DisplayGridWidth = new Guid("D1B3020F-607A-40EF-8B5E-43CA76091D39");

        private const int DEFAULTDISPLAYFORMMODE = 1;
        private static Guid GUID_DisplayFormMode = new Guid("{E9DB78A0-901B-42F9-BAB8-EA403003F362}");

        //PRINTER
        private const int DEFAULTPRINTAREAWIDTH = 300;
        private static Guid GUID_PrintAreaWidth = new Guid("081E5A09-1967-44cb-AA29-0D0E0D828F33");

        private const int DEFAULTPRINTQTY = 1;
        private static Guid GUID_PrintQty = new Guid("98C99B92-AEF3-436E-9948-43D3F48FC4C7");

        private static Guid GUID_ManualQueueNoReset = new Guid("4F6B552C-02B6-4425-A691-4C05C9B70D4F");
        private static Guid GUID_AutomaticQueueNoResetHour = new Guid("BCE4D753-9ACA-4E8E-A249-DC713F8FEC69");
        private static Guid GUID_QueueNoCutoffTimestamp = new Guid("E20C6B8C-9D58-4DBD-A3D4-4803F5E550CE");

        //HEADER TEXT
        private static Guid GUID_HeaderText = new Guid("93A34F27-052C-4DB0-A4BA-42108572BB5C");

        //ROLLING TEXT
        private const int DEFAULTROLLINGTEXTSPEED = 2;
        public const int ROLLINGTEXTTIMERINTERVAL = 1;
        private static Guid GUID_RollingText = new Guid("e9232297-ef13-413a-b9af-2b78aea65832");
        private static Guid GUID_RollingTextSpeed = new Guid("1c250e10-3582-4ed2-b8ea-845e2735bbc0");

        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        /// <summary><para></para></summary>
        public static int DisplayFormMode
        {
            get { return LIBUtil.Settings.getIntValue(GUID_DisplayFormMode, DEFAULTDISPLAYFORMMODE); }
            set { LIBUtil.Settings.update(GUID_DisplayFormMode, value); }
        }

        /// <summary><para></para></summary>
        public static int AdInterval
        {
            get { return LIBUtil.Settings.getIntValue(GUID_AdInterval, DEFAULTADINTERVAL); }
            set { LIBUtil.Settings.update(GUID_AdInterval, value); }
        }

        /// <summary><para></para></summary>
        public static bool ShowAdAsDefault
        {
            get { return LIBUtil.Settings.getBoolValue(GUID_ShowAdAsDefault); }
            set { LIBUtil.Settings.update(GUID_ShowAdAsDefault, value); }
        }

        /// <summary><para></para></summary>
        public static string AdFolder
        {
            get { return LIBUtil.Settings.getStringValue(GUID_AdFolder); }
            set { LIBUtil.Settings.update(GUID_AdFolder, value); }
        }

        /// <summary><para></para></summary>
        public static string SoundFolder
        {
            get { return LIBUtil.Settings.getStringValue(GUID_SoundFolder); }
            set { LIBUtil.Settings.update(GUID_SoundFolder, value); }
        }

        /// <summary><para></para></summary>
        public static string TransitionSoundFile
        {
            get { return LIBUtil.Settings.getStringValue(GUID_TransitionSoundFile); }
            set { LIBUtil.Settings.update(GUID_TransitionSoundFile, value); }
        }

        /// <summary><para></para></summary>
        public static bool PlayNotificationSound
        {
            get { return LIBUtil.Settings.getBoolValue(GUID_CallFormat_PlayNotificationSound); }
            set { LIBUtil.Settings.update(GUID_CallFormat_PlayNotificationSound, value); }
        }

        /// <summary><para></para></summary>
        public static bool PlayCounter
        {
            get { return LIBUtil.Settings.getBoolValue(GUID_CallFormat_PlayCounter); }
            set { LIBUtil.Settings.update(GUID_CallFormat_PlayCounter, value); }
        }

        /// <summary><para></para></summary>
        public static int RefreshInterval
        {
            get { return LIBUtil.Settings.getIntValue(GUID_RefreshInterval, DEFAULTREFRESHINTERVAL); }
            set { LIBUtil.Settings.update(GUID_RefreshInterval, value); }
        }

        /// <summary><para></para></summary>
        public static int RequestGridWidth
        {
            get { return LIBUtil.Settings.getIntValue(GUID_RequestGridWidth, DEFAULTREQUESTGRIDWIDTH); }
            set { LIBUtil.Settings.update(GUID_RequestGridWidth, value); }
        }

        /// <summary><para></para></summary>
        public static int DisplayFontSize
        {
            get {
                int size = LIBUtil.Settings.getIntValue(GUID_DisplayFontSize, DEFAULTFONTSIZE);
                if (size < 1)
                    size = DisplayFontSize = 1;
                return size;
            }
            set { LIBUtil.Settings.update(GUID_DisplayFontSize, value); }
        }

        /// <summary><para></para></summary>
        public static int DisplayGridWidth
        {
            get { return LIBUtil.Settings.getIntValue(GUID_DisplayGridWidth, DEFAULTDISPLAYGRIDWIDTH); }
            set { LIBUtil.Settings.update(GUID_DisplayGridWidth, value); }
        }

        /// <summary><para></para></summary>
        public static int PrintAreaWidth
        {
            get { return LIBUtil.Settings.getIntValue(GUID_PrintAreaWidth, DEFAULTPRINTAREAWIDTH); }
            set { LIBUtil.Settings.update(GUID_PrintAreaWidth, value); }
        }

        /// <summary><para></para></summary>
        public static int PrintQty
        {
            get { return LIBUtil.Settings.getIntValue(GUID_PrintQty, DEFAULTPRINTQTY); }
            set { LIBUtil.Settings.update(GUID_PrintQty, value); }
        }

        /// <summary><para></para></summary>
        public static string HeaderText
        {
            get { return LIBUtil.Settings.getStringValue(GUID_HeaderText); }
            set { LIBUtil.Settings.update(GUID_HeaderText, value); }
        }

        /// <summary><para></para></summary>
        public static string RollingText
        {
            get { return LIBUtil.Settings.getStringValue(GUID_RollingText); }
            set { LIBUtil.Settings.update(GUID_RollingText, value); }
        }

        /// <summary><para></para></summary>
        public static int RollingTextSpeed
        {
            get { return LIBUtil.Settings.getIntValue(GUID_RollingTextSpeed, DEFAULTROLLINGTEXTSPEED); }
            set { LIBUtil.Settings.update(GUID_RollingTextSpeed, value); }
        }

        /// <summary><para></para></summary>
        public static bool ManualQueueNoReset
        {
            get { return LIBUtil.Settings.getBoolValue(GUID_ManualQueueNoReset); }
            set { LIBUtil.Settings.update(GUID_ManualQueueNoReset, value); }
        }

        /// <summary><para></para></summary>
        public static int AutomaticQueueNoResetHour
        {
            get { return LIBUtil.Settings.getIntValue(GUID_AutomaticQueueNoResetHour, 0); }
            set { LIBUtil.Settings.update(GUID_AutomaticQueueNoResetHour, value); }
        }

        /// <summary><para></para></summary>
        public static DateTime QueueNoCutoffTimestamp
        {
            get {
                DateTime? value = LIBUtil.Settings.getDateTimeValue(GUID_QueueNoCutoffTimestamp);
                if (value == null)
                    return DateTime.Now;
                else
                    return (DateTime)value;
            }
            set {
                LIBUtil.Settings.update(GUID_QueueNoCutoffTimestamp, value);
            }
        }

        public static DateTime getAutomaticQueueNoResetTimestamp(DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, AutomaticQueueNoResetHour, 0, 0);
        }

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        #endregion DATABASE FIELDS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        #endregion DATABASE METHODS
        /*******************************************************************************************************/

    }
}
