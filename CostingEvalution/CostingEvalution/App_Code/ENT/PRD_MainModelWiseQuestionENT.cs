using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_MainModelWiseQuestionENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class PRD_MainModelWiseQuestionENT
    {
        #region Constructor
        public PRD_MainModelWiseQuestionENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region MainModelWiseQuestionID
        protected SqlInt32 _MainModelWiseQuestionID;

        public SqlInt32 MainModelWiseQuestionID
        {
            get
            {
                return _MainModelWiseQuestionID;
            }
            set
            {
                _MainModelWiseQuestionID = value;
            }
        }
        #endregion MainModelWiseQuestionID

        #region MainModelID
        protected SqlInt32 _MainModelID;

        public SqlInt32 MainModelID
        {
            get
            {
                return _MainModelID;
            }
            set
            {
                _MainModelID = value;
            }
        }
        #endregion MainModelID

        #region QuestionID
        protected SqlInt32 _QuestionID;

        public SqlInt32 QuestionID
        {
            get
            {
                return _QuestionID;
            }
            set
            {
                _QuestionID = value;
            }
        }
        #endregion QuestionID

        #region CreateDateTime
        protected SqlDateTime _CreateDateTime;

        public SqlDateTime CreateDateTime
        {
            get
            {
                return _CreateDateTime;
            }
            set
            {
                _CreateDateTime = value;
            }
        }
        #endregion CreateDateTime

        #region CreateBy
        protected SqlInt32 _CreateBy;

        public SqlInt32 CreateBy
        {
            get
            {
                return _CreateBy;
            }
            set
            {
                _CreateBy = value;
            }
        }
        #endregion CreateBy

        #region CreateIP
        protected SqlString _CreateIP;

        public SqlString CreateIP
        {
            get
            {
                return _CreateIP;
            }
            set
            {
                _CreateIP = value;
            }
        }
        #endregion CreateIP

        #region UpdateDateTime
        protected SqlDateTime _UpdateDateTime;

        public SqlDateTime UpdateDateTime
        {
            get
            {
                return _UpdateDateTime;
            }
            set
            {
                _UpdateDateTime = value;
            }
        }
        #endregion UpdateDateTime

        #region UpdateBy
        protected SqlInt32 _UpdateBy;

        public SqlInt32 UpdateBy
        {
            get
            {
                return _UpdateBy;
            }
            set
            {
                _UpdateBy = value;
            }
        }
        #endregion UpdateBy

        #region UpdateIP
        protected SqlString _UpdateIP;

        public SqlString UpdateIP
        {
            get
            {
                return _UpdateIP;
            }
            set
            {
                _UpdateIP = value;
            }
        }
        #endregion UpdateIP

    }
}
