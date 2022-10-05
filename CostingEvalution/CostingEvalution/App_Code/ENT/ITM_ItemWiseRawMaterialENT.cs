using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ITM_ItemWiseRawMaterialENT
/// </summary>
/// 
namespace CostingEvalution.App_Code.ENT
{
    public class ITM_ItemWiseRawMaterialENT
    {
        #region Constructor
        public ITM_ItemWiseRawMaterialENT()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion Constructor        
        
        #region ItemWiseRawMaterialID
        protected SqlInt32 _ItemWiseRawMaterialID;

        public SqlInt32 ItemWiseRawMaterialID
        {
            get
            {
                return _ItemWiseRawMaterialID;
            }
            set
            {
                _ItemWiseRawMaterialID = value;
            }
        }
        #endregion ItemWiseRawMaterialID

        #region ItemID
        protected SqlInt32 _ItemID;

        public SqlInt32 ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                _ItemID = value;
            }
        }
        #endregion ItemID

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

        #region RawMaterialQuantity
        protected SqlInt32 _RawMaterialQuantity;

        public SqlInt32 RawMaterialQuantity
        {
            get
            {
                return _RawMaterialQuantity;
            }
            set
            {
                _RawMaterialQuantity = value;
            }
        }
        #endregion RawMaterialQuantity

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
