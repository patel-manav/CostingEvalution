using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_RawMaterialBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class MST_RawMaterialBAL
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
        public MST_RawMaterialBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(MST_RawMaterialENT entMST_RawMaterial)
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            if (dalMST_RawMaterial.Insert(entMST_RawMaterial))
            {
                return true;
            }
            else
            {
                Message = dalMST_RawMaterial.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 RawMaterialID)
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();

            if (dalMST_RawMaterial.Delete(RawMaterialID))
            {
                return true;
            }
            else
            {
                Message = dalMST_RawMaterial.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(MST_RawMaterialENT entMST_RawMaterial)
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            if (dalMST_RawMaterial.Update(entMST_RawMaterial))
            {
                return true;
            }
            else
            {
                Message = dalMST_RawMaterial.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            return dalMST_RawMaterial.Select();
        }
        #endregion Select

        #region SelectPK
        public MST_RawMaterialENT SelectPK(SqlInt32 RawMaterialID)
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            return dalMST_RawMaterial.SelectPK(RawMaterialID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            return dalMST_RawMaterial.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #region Select
        public DataTable SelectForItem(SqlInt32 RawMaterialID)
        {
            MST_RawMaterialDAL dalMST_RawMaterial = new MST_RawMaterialDAL();
            return dalMST_RawMaterial.SelectForItem(RawMaterialID);
        }
        #endregion Select

        #endregion Select Operation
    }
}
