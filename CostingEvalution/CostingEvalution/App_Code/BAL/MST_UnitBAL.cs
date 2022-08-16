using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_UnitBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class MST_UnitBAL
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
        public MST_UnitBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(MST_UnitENT entMST_Unit)
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();
            if (dalMST_Unit.Insert(entMST_Unit))
            {
                return true;
            }
            else
            {
                Message = dalMST_Unit.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 UnitID)
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();

            if (dalMST_Unit.Delete(UnitID))
            {
                return true;
            }
            else
            {
                Message = dalMST_Unit.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(MST_UnitENT entMST_Unit)
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();
            if (dalMST_Unit.Update(entMST_Unit))
            {
                return true;
            }
            else
            {
                Message = dalMST_Unit.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();
            return dalMST_Unit.Select();
        }
        #endregion Select

        #region SelectPK
        public MST_UnitENT SelectPK(SqlInt32 UnitID)
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();
            return dalMST_Unit.SelectPK(UnitID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            MST_UnitDAL dalMST_Unit = new MST_UnitDAL();
            return dalMST_Unit.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
