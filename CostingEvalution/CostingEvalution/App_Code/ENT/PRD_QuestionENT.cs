using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRD_QuestionENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class PRD_QuestionENT
    {
        #region Constructor
        public PRD_QuestionENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
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

        #region QuestionName
        protected SqlString _QuestionName;

        public SqlString QuestionName
        {
            get
            {
                return _QuestionName;
            }
            set
            {
                _QuestionName = value;
            }
        }
        #endregion QuestionName

        #region ItemTypeID
        protected SqlInt32 _ItemTypeID;

        public SqlInt32 ItemTypeID
        {
            get
            {
                return _ItemTypeID;
            }
            set
            {
                _ItemTypeID = value;
            }
        }
        #endregion ItemTypeID

        #region Description
        protected SqlString _Description;

        public SqlString Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        #endregion Description

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
