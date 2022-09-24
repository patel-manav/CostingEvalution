using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_MainModelBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class PRD_MainModelBAL
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
        public PRD_MainModelBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(PRD_MainModelENT entPRD_MainModel)
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();
            if (dalPRD_MainModel.Insert(entPRD_MainModel))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModel.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 MainModelID)
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();

            if (dalPRD_MainModel.Delete(MainModelID))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModel.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(PRD_MainModelENT entPRD_MainModel)
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();
            if (dalPRD_MainModel.Update(entPRD_MainModel))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModel.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();
            return dalPRD_MainModel.Select();
        }
        #endregion Select

        #region SelectPK
        public PRD_MainModelENT SelectPK(SqlInt32 MainModelID)
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();
            return dalPRD_MainModel.SelectPK(MainModelID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            PRD_MainModelDAL dalPRD_MainModel = new PRD_MainModelDAL();
            return dalPRD_MainModel.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
