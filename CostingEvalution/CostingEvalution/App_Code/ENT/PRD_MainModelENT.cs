using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_MainModelENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class PRD_MainModelENT
    {
        #region Constructor
        public PRD_MainModelENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region MainModelID
        protected SqlInt32 _MainModelID;

        public SqlInt32 MainModelID
        {
            get
            {
                return _MainModelID;
            }
            set
            {
                _MainModelID = value;
            }
        }
        #endregion MainModelID

        #region MainModelName
        protected SqlString _MainModelName;

        public SqlString MainModelName
        {
            get
            {
                return _MainModelName;
            }
            set
            {
                _MainModelName = value;
            }
        }
        #endregion MainModelName

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
