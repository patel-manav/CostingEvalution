using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EMP_EmployeeTypeENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class EMP_EmployeeTypeENT
    {
        #region Constructor
        public EMP_EmployeeTypeENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        
        #region EmployeeTypeID
        protected SqlInt32 _EmployeeTypeID;

        public SqlInt32 EmployeeTypeID
        {
            get
            {
                return _EmployeeTypeID;
            }
            set
            {
                _EmployeeTypeID = value;
            }
        }
        #endregion EmployeeTypeID

        #region EmployeeTypeName
        protected SqlString _EmployeeTypeName;

        public SqlString EmployeeTypeName
        {
            get
            {
                return _EmployeeTypeName;
            }
            set
            {
                _EmployeeTypeName = value;
            }
        }
        #endregion EmployeeTypeName

        #region IsEmployeeTypeForHourAndNos
        protected SqlBoolean _IsEmployeeTypeForHourAndNos;

        public SqlBoolean IsEmployeeTypeForHourAndNos
        {
            get
            {
                return _IsEmployeeTypeForHourAndNos;
            }
            set
            {
                _IsEmployeeTypeForHourAndNos = value;
            }
        }
        #endregion IsEmployeeTypeForHourAndNos

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
