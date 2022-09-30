using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemWiseMainModelENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class ITM_ItemWiseMainModelENT
    {
        #region Constructor
        public ITM_ItemWiseMainModelENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region ItemWiseMainModelID
        protected SqlInt32 _ItemWiseMainModelID;

        public SqlInt32 ItemWiseMainModelID
        {
            get
            {
                return _ItemWiseMainModelID;
            }
            set
            {
                _ItemWiseMainModelID = value;
            }
        }
        #endregion ItemWiseMainModelID

        #region ItemID
        protected SqlInt32 _ItemID;

        public SqlInt32 ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                _ItemID = value;
            }
        }
        #endregion ItemID

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
