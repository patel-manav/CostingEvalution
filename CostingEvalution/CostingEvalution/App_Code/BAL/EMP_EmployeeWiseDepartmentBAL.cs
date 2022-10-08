using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EMP_EmployeeWiseDepartmentBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class EMP_EmployeeWiseDepartmentBAL
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
        public EMP_EmployeeWiseDepartmentBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment)
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            if (dalEMP_EmployeeWiseDepartment.Insert(entEMP_EmployeeWiseDepartment))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeWiseDepartment.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 EmployeeWiseDepartmentID)
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();

            if (dalEMP_EmployeeWiseDepartment.Delete(EmployeeWiseDepartmentID))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeWiseDepartment.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment)
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            if (dalEMP_EmployeeWiseDepartment.Update(entEMP_EmployeeWiseDepartment))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeWiseDepartment.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            return dalEMP_EmployeeWiseDepartment.Select();
        }
        #endregion Select

        #region SelectPK
        public EMP_EmployeeWiseDepartmentENT SelectPK(SqlInt32 EmployeeWiseDepartmentID)
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            return dalEMP_EmployeeWiseDepartment.SelectPK(EmployeeWiseDepartmentID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            return dalEMP_EmployeeWiseDepartment.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #region SelectByMainModelId
        public DataTable SelectByEmployeeId(SqlInt32 EmployeeID)
        {
            EMP_EmployeeWiseDepartmentDAL dalEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentDAL();
            return dalEMP_EmployeeWiseDepartment.SelectByEmployeeId(EmployeeID);
        }
        #endregion SelectByMainModelId

        #endregion Select Operation

    }
}
