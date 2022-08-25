using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_DepartmentBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class MST_DepartmentBAL
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
        public MST_DepartmentBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(MST_DepartmentENT entMST_Department)
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();
            if (dalMST_Department.Insert(entMST_Department))
            {
                return true;
            }
            else
            {
                Message = dalMST_Department.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 DepartmentID)
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();

            if (dalMST_Department.Delete(DepartmentID))
            {
                return true;
            }
            else
            {
                Message = dalMST_Department.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(MST_DepartmentENT entMST_Department)
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();
            if (dalMST_Department.Update(entMST_Department))
            {
                return true;
            }
            else
            {
                Message = dalMST_Department.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();
            return dalMST_Department.Select();
        }
        #endregion Select

        #region SelectPK
        public MST_DepartmentENT SelectPK(SqlInt32 DepartmentID)
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();
            return dalMST_Department.SelectPK(DepartmentID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            MST_DepartmentDAL dalMST_Department = new MST_DepartmentDAL();
            return dalMST_Department.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
