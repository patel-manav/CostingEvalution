using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemTypeBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class ITM_ItemTypeBAL
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
        public ITM_ItemTypeBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(ITM_ItemTypeENT entITM_ItemType)
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();
            if (dalITM_ItemType.Insert(entITM_ItemType))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemType.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 ItemTypeID)
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();

            if (dalITM_ItemType.Delete(ItemTypeID))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemType.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(ITM_ItemTypeENT entITM_ItemType)
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();
            if (dalITM_ItemType.Update(entITM_ItemType))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemType.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();
            return dalITM_ItemType.Select();
        }
        #endregion Select

        #region SelectPK
        public ITM_ItemTypeENT SelectPK(SqlInt32 ItemTypeID)
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();
            return dalITM_ItemType.SelectPK(ItemTypeID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            ITM_ItemTypeDAL dalITM_ItemType = new ITM_ItemTypeDAL();
            return dalITM_ItemType.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
