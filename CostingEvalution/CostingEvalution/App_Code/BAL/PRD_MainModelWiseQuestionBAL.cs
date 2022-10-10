using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_MainModelWiseQuestionBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class PRD_MainModelWiseQuestionBAL
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
        public PRD_MainModelWiseQuestionBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            if (dalPRD_MainModelWiseQuestion.Insert(entPRD_MainModelWiseQuestion))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModelWiseQuestion.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 MainModelID)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();

            if (dalPRD_MainModelWiseQuestion.Delete(MainModelID))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModelWiseQuestion.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            if (dalPRD_MainModelWiseQuestion.Update(entPRD_MainModelWiseQuestion))
            {
                return true;
            }
            else
            {
                Message = dalPRD_MainModelWiseQuestion.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select(SqlInt32 MainModelID)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            return dalPRD_MainModelWiseQuestion.Select(MainModelID);
        }
        #endregion Select

        #region SelectPK
        public PRD_MainModelWiseQuestionENT SelectPK(SqlInt32 MainModelWiseQuestionID)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            return dalPRD_MainModelWiseQuestion.SelectPK(MainModelWiseQuestionID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            return dalPRD_MainModelWiseQuestion.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #region SelectByMainModelId
        public DataTable SelectByMainModelId(SqlInt32 MainModelID)
        {
            PRD_MainModelWiseQuestionDAL dalPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionDAL();
            return dalPRD_MainModelWiseQuestion.SelectByMainModelId(MainModelID);
        }
        #endregion SelectByMainModelId

        #endregion Select Operation
    }
}
