using CostingEvalution.App_Code.DAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_QuestionBAL
/// </summary>
/// 
namespace CostingEvalution.App_Code.BAL
{
    public class PRD_QuestionBAL
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
        public PRD_QuestionBAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor

        #region Insert Operation
        public Boolean Insert(PRD_QuestionENT entPRD_Question)
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();
            if (dalPRD_Question.Insert(entPRD_Question))
            {
                return true;
            }
            else
            {
                Message = dalPRD_Question.Message;
                return false;
            }
        }
        #endregion Insert Operation

        #region Delele Operation
        public Boolean Delete(SqlInt32 QuestionID)
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();

            if (dalPRD_Question.Delete(QuestionID))
            {
                return true;
            }
            else
            {
                Message = dalPRD_Question.Message;
                return false;
            }
        }

        #endregion Delele Operation

        #region Update Operation
        public Boolean Update(PRD_QuestionENT entPRD_Question)
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();
            if (dalPRD_Question.Update(entPRD_Question))
            {
                return true;
            }
            else
            {
                Message = dalPRD_Question.Message;
                return false;
            }
        }
        #endregion Update Operation

        #region Select Operation

        #region Select
        public DataTable Select()
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();
            return dalPRD_Question.Select();
        }
        #endregion Select

        #region SelectPK
        public PRD_QuestionENT SelectPK(SqlInt32 QuestionID)
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();
            return dalPRD_Question.SelectPK(QuestionID);
        }

        #endregion SelectPK

        #region Select For Dropdown
        public DataTable SelectForDropDown()
        {
            PRD_QuestionDAL dalPRD_Question = new PRD_QuestionDAL();
            return dalPRD_Question.SelectForDropDown();
        }
        #endregion Select For Dropdown

        #endregion Select Operation
    }
}
