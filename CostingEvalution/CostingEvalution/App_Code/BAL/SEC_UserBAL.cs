using System;
using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;

/// <summary>
/// Summary description for SEC_UserBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class SEC_UserBAL
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
        public SEC_UserBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(SEC_UserENT entSEC_User)
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            if (dalSEC_User.Insert(entSEC_User))
            {
                return true;
            }
            else
            {
                Message = dalSEC_User.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 UserID)
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();

            if (dalSEC_User.Delete(UserID))
            {
                return true;
            }
            else
            {
                Message = dalSEC_User.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(SEC_UserENT entSEC_User)
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            if (dalSEC_User.Update(entSEC_User))
            {
                return true;
            }
            else
            {
                Message = dalSEC_User.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            return dalSEC_User.Select();
        }
        #endregion Select

        #region SelectPK
        public SEC_UserENT SelectPK(SqlInt32 UserID)
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            return dalSEC_User.SelectPK(UserID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            return dalSEC_User.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation

        #region UserSignIn
        public DataTable UserSignIn(String UserName, String UserPassword)
        {
            SEC_UserDAL dalSEC_User = new SEC_UserDAL();
            return dalSEC_User.UserSignIn(UserName, UserPassword);
        }
        #endregion UserSignIn
    }
}
