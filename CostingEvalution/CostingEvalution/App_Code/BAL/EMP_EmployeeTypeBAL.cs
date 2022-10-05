using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EMP_EmployeeTypeBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class EMP_EmployeeTypeBAL
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
        public EMP_EmployeeTypeBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(EMP_EmployeeTypeENT entEMP_EmployeeType)
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();
            if (dalEMP_EmployeeType.Insert(entEMP_EmployeeType))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeType.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 EmployeeTypeID)
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();

            if (dalEMP_EmployeeType.Delete(EmployeeTypeID))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeType.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(EMP_EmployeeTypeENT entEMP_EmployeeType)
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();
            if (dalEMP_EmployeeType.Update(entEMP_EmployeeType))
            {
                return true;
            }
            else
            {
                Message = dalEMP_EmployeeType.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();
            return dalEMP_EmployeeType.Select();
        }
        #endregion Select

        #region SelectPK
        public EMP_EmployeeTypeENT SelectPK(SqlInt32 EmployeeTypeID)
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();
            return dalEMP_EmployeeType.SelectPK(EmployeeTypeID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            EMP_EmployeeTypeDAL dalEMP_EmployeeType = new EMP_EmployeeTypeDAL();
            return dalEMP_EmployeeType.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
