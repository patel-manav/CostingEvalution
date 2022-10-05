using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemWiseRawMaterialBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class ITM_ItemWiseRawMaterialBAL
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
        public ITM_ItemWiseRawMaterialBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial)
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();
            if (dalITM_ItemWiseRawMaterial.Insert(entITM_ItemWiseRawMaterial))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseRawMaterial.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 ItemWiseRawMaterialID)
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();

            if (dalITM_ItemWiseRawMaterial.Delete(ItemWiseRawMaterialID))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseRawMaterial.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial)
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();
            if (dalITM_ItemWiseRawMaterial.Update(entITM_ItemWiseRawMaterial))
            {
                return true;
            }
            else
            {
                Message = dalITM_ItemWiseRawMaterial.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();
            return dalITM_ItemWiseRawMaterial.Select();
        }
        #endregion Select

        #region SelectPK
        public ITM_ItemWiseRawMaterialENT SelectPK(SqlInt32 ItemWiseRawMaterialID)
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();
            return dalITM_ItemWiseRawMaterial.SelectPK(ItemWiseRawMaterialID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            ITM_ItemWiseRawMaterialDAL dalITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialDAL();
            return dalITM_ItemWiseRawMaterial.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
