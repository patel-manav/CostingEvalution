using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_UserENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class SEC_UserENT
    {
        #region Constructor
        public SEC_UserENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        #region UserID
        protected SqlInt32 _UserID;

        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        #endregion UserID

        #region UserName
        protected SqlString _UserName;

        public SqlString UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        #endregion UserName

        #region UserDisplayName
        protected SqlString _UserDisplayName;

        public SqlString UserDisplayName
        {
            get
            {
                return _UserDisplayName;
            }
            set
            {
                _UserDisplayName = value;
            }
        }
        #endregion UserDisplayName

        #region UserPassword
        protected SqlString _UserPassword;

        public SqlString UserPassword
        {
            get
            {
                return _UserPassword;
            }
            set
            {
                _UserPassword = value;
            }
        }
        #endregion UserPassword

        #region Description
        protected SqlString _Description;

        public SqlString Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        #endregion Description

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

    }
}
