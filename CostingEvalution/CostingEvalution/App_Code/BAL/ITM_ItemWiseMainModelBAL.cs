using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemWiseMainModelBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class ITM_ItemWiseMainModelBAL
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
        public ITM_ItemWiseMainModelBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel)
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();
            if (dalITM_ItemWiseMainModel.Insert(entITM_ItemWiseMainModel))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseMainModel.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 ItemWiseMainModelID)
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();

            if (dalITM_ItemWiseMainModel.Delete(ItemWiseMainModelID))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseMainModel.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel)
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();
            if (dalITM_ItemWiseMainModel.Update(entITM_ItemWiseMainModel))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseMainModel.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();
            return dalITM_ItemWiseMainModel.Select();
        }
        #endregion Select

        #region SelectPK
        public ITM_ItemWiseMainModelENT SelectPK(SqlInt32 ItemWiseMainModelID)
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();
            return dalITM_ItemWiseMainModel.SelectPK(ItemWiseMainModelID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            ITM_ItemWiseMainModelDAL dalITM_ItemWiseMainModel = new ITM_ItemWiseMainModelDAL();
            return dalITM_ItemWiseMainModel.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
