using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SEC_MenuBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class SEC_MenuBAL
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
        public SEC_MenuBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(SEC_MenuENT entSEC_Menu)
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            if (dalSEC_Menu.Insert(entSEC_Menu))
            {
                return true;
            }
            else
            {
                Message = dalSEC_Menu.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 MenuID)
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();

            if (dalSEC_Menu.Delete(MenuID))
            {
                return true;
            }
            else
            {
                Message = dalSEC_Menu.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(SEC_MenuENT entSEC_Menu)
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            if (dalSEC_Menu.Update(entSEC_Menu))
            {
                return true;
            }
            else
            {
                Message = dalSEC_Menu.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            return dalSEC_Menu.Select();
        }
        #endregion Select

        #region SelectPK
        public SEC_MenuENT SelectPK(SqlInt32 MenuID)
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            return dalSEC_Menu.SelectPK(MenuID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            return dalSEC_Menu.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #region FillMenu
        public DataTable FillMenu(SqlInt32 UserID)
        {
            SEC_MenuDAL dalSEC_Menu = new SEC_MenuDAL();
            return dalSEC_Menu.FillMenu(UserID);
        }

        #endregion SelectPK

        #endregion Select Operation
    }
}
