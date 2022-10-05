using CostingEvalution.App_Code.ENT;
using CostingEvalution.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class ITM_ItemBAL
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
        public ITM_ItemBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(ITM_ItemENT entITM_Item)
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            if (dalITM_Item.Insert(entITM_Item))
            {
                return true;
            }
            else
            {
                Message = dalITM_Item.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 ItemID)
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();

            if (dalITM_Item.Delete(ItemID))
            {
                return true;
            }
            else
            {
                Message = dalITM_Item.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(ITM_ItemENT entITM_Item)
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            if (dalITM_Item.Update(entITM_Item))
            {
                return true;
            }
            else
            {
                Message = dalITM_Item.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select(SqlInt32 ItemID)
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            return dalITM_Item.Select(ItemID);
        }
        #endregion Select

        #region SelectPK
        public ITM_ItemENT SelectPK(SqlInt32 ItemID)
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            return dalITM_Item.SelectPK(ItemID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            return dalITM_Item.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #region SelectWithPrice
        public DataTable SelectWithPrice()
        {
            ITM_ItemDAL dalITM_Item = new ITM_ItemDAL();
            return dalITM_Item.SelectWithPrice();
        }
        #endregion SelectWithPrice

        #endregion Select Operation
    }
}
