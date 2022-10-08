using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EMP_EmployeeBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class EMP_EmployeeBAL
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
        public EMP_EmployeeBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(EMP_EmployeeENT entEMP_Employee)
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();
            if (dalEMP_Employee.Insert(entEMP_Employee))
            {
                return true;
            }
            else
            {
                Message = dalEMP_Employee.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 EmployeeID)
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();

            if (dalEMP_Employee.Delete(EmployeeID))
            {
                return true;
            }
            else
            {
                Message = dalEMP_Employee.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(EMP_EmployeeENT entEMP_Employee)
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();
            if (dalEMP_Employee.Update(entEMP_Employee))
            {
                return true;
            }
            else
            {
                Message = dalEMP_Employee.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();
            return dalEMP_Employee.Select();
        }
        #endregion Select

        #region SelectPK
        public EMP_EmployeeENT SelectPK(SqlInt32 EmployeeID)
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();
            return dalEMP_Employee.SelectPK(EmployeeID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            EMP_EmployeeDAL dalEMP_Employee = new EMP_EmployeeDAL();
            return dalEMP_Employee.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
