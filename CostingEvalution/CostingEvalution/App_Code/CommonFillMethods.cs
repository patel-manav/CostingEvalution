using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;

namespace CostingEvalution.App_Code
{
    public class CommonFillMethods
    {
        #region Unit DropDown
        public static void FillDropDownListUnit(DropDownList ddl)
        {
            MST_UnitBAL balMST_Unit = new MST_UnitBAL();
            DataTable dt = balMST_Unit.SelectForDropDown();
            if (dt != null && dt.Rows.Count > 0)
            {
                ddl.DataValueField = "UnitID";
                ddl.DataTextField = "UnitName";
                ddl.DataSource = dt;
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem("Select Unit", "-1"));
            }
        }
        #endregion Unit DropDown
    }
}