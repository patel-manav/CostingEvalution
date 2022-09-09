using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_UserWiseMenuENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class SEC_UserWiseMenuENT
    {
        #region Constructor
        public SEC_UserWiseMenuENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region UserWiseMenuID
        protected SqlInt32 _UserWiseMenuID;

        public SqlInt32 UserWiseMenuID
        {
            get
            {
                return _UserWiseMenuID;
            }
            set
            {
                _UserWiseMenuID = value;
            }
        }
        #endregion UserWiseMenuID

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

    }
}
