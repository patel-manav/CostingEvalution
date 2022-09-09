using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_MenuENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class SEC_MenuENT
    {
        #region Constructor
        public SEC_MenuENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region MenuID
        protected SqlInt32 _MenuID;

        public SqlInt32 MenuID
        {
            get
            {
                return _MenuID;
            }
            set
            {
                _MenuID = value;
            }
        }
        #endregion MenuID

        #region MenuName
        protected SqlString _MenuName;

        public SqlString MenuName
        {
            get
            {
                return _MenuName;
            }
            set
            {
                _MenuName = value;
            }
        }
        #endregion MenuName

        #region MenuImagePath
        protected SqlString _MenuImagePath;

        public SqlString MenuImagePath
        {
            get
            {
                return _MenuImagePath;
            }
            set
            {
                _MenuImagePath = value;
            }
        }
        #endregion MenuImagePath

        #region MenuURL
        protected SqlString _MenuURL;

        public SqlString MenuURL
        {
            get
            {
                return _MenuURL;
            }
            set
            {
                _MenuURL = value;
            }
        }
        #endregion MenuURL

        #region MenuSequence
        protected SqlDecimal _MenuSequence;

        public SqlDecimal MenuSequence
        {
            get
            {
                return _MenuSequence;
            }
            set
            {
                _MenuSequence = value;
            }
        }
        #endregion MenuSequence

        #region CreateDateTime
        protected SqlDateTime _CreateDateTime;

        public SqlDateTime CreateDateTime
        {
            get
            {
                return _CreateDateTime;
            }
            set
            {
                _CreateDateTime = value;
            }
        }
        #endregion CreateDateTime

        #region CreateBy
        protected SqlInt32 _CreateBy;

        public SqlInt32 CreateBy
        {
            get
            {
                return _CreateBy;
            }
            set
            {
                _CreateBy = value;
            }
        }
        #endregion CreateBy

        #region CreateIP
        protected SqlString _CreateIP;

        public SqlString CreateIP
        {
            get
            {
                return _CreateIP;
            }
            set
            {
                _CreateIP = value;
            }
        }
        #endregion CreateIP

        #region UpdateDateTime
        protected SqlDateTime _UpdateDateTime;

        public SqlDateTime UpdateDateTime
        {
            get
            {
                return _UpdateDateTime;
            }
            set
            {
                _UpdateDateTime = value;
            }
        }
        #endregion UpdateDateTime

        #region UpdateBy
        protected SqlInt32 _UpdateBy;

        public SqlInt32 UpdateBy
        {
            get
            {
                return _UpdateBy;
            }
            set
            {
                _UpdateBy = value;
            }
        }
        #endregion UpdateBy

        #region UpdateIP
        protected SqlString _UpdateIP;

        public SqlString UpdateIP
        {
            get
            {
                return _UpdateIP;
            }
            set
            {
                _UpdateIP = value;
            }
        }
        #endregion UpdateIP

    }
}
