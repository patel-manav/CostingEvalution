using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_UserWiseMenuBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class SEC_UserWiseMenuBAL
    {
        #region Local Variable
        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variable

        #region Constructor
        public SEC_UserWiseMenuBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(SqlInt32 UserID, SqlInt32 MenuID)
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();
            if (dalSEC_UserWiseMenu.Insert(UserID, MenuID))
            {
                return true;
            }
            else
            {
                Message = dalSEC_UserWiseMenu.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 UserID)
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();

            if (dalSEC_UserWiseMenu.Delete(UserID))
            {
                return true;
            }
            else
            {
                Message = dalSEC_UserWiseMenu.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(SEC_UserWiseMenuENT entSEC_UserWiseMenu)
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();
            if (dalSEC_UserWiseMenu.Update(entSEC_UserWiseMenu))
            {
                return true;
            }
            else
            {
                Message = dalSEC_UserWiseMenu.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select(SqlInt32 UserID)
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();
            return dalSEC_UserWiseMenu.Select(UserID);
        }
        #endregion Select

        #region SelectPK
        public SEC_UserWiseMenuENT SelectPK(SqlInt32 UserWiseMenuID)
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();
            return dalSEC_UserWiseMenu.SelectPK(UserWiseMenuID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            SEC_UserWiseMenuDAL dalSEC_UserWiseMenu = new SEC_UserWiseMenuDAL();
            return dalSEC_UserWiseMenu.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
