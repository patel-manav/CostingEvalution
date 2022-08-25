using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_RawMaterialENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class MST_RawMaterialENT
    {
        #region Constructor
        public MST_RawMaterialENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor
        
        #region RawMaterialID
        protected SqlInt32 _RawMaterialID;

        public SqlInt32 RawMaterialID
        {
            get
            {
                return _RawMaterialID;
            }
            set
            {
                _RawMaterialID = value;
            }
        }
        #endregion RawMaterialID

        #region RawMaterialName
        protected SqlString _RawMaterialName;

        public SqlString RawMaterialName
        {
            get
            {
                return _RawMaterialName;
            }
            set
            {
                _RawMaterialName = value;
            }
        }
        #endregion RawMaterialName

        #region UnitID
        protected SqlInt32 _UnitID;

        public SqlInt32 UnitID
        {
            get
            {
                return _UnitID;
            }
            set
            {
                _UnitID = value;
            }
        }
        #endregion UnitID

        #region RawMaterialPrice
        protected SqlDouble _RawMaterialPrice;

        public SqlDouble RawMaterialPrice
        {
            get
            {
                return _RawMaterialPrice;
            }
            set
            {
                _RawMaterialPrice = value;
            }
        }
        #endregion RawMaterialName

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
