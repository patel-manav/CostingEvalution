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

        #region User DropDown
        public static void FillDropDownListUser(DropDownList ddl)
        {
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            DataTable dt = balSEC_User.SelectForDropDown();
            if (dt != null && dt.Rows.Count > 0)
            {
                ddl.DataValueField = "UserID";
                ddl.DataTextField = "UserDisplayName";
                ddl.DataSource = dt;
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem("Select User", "-1"));
            }
        }
        #endregion User DropDown

        #region ItemType DropDown
        public static void FillDropDownListItemType(DropDownList ddl)
        {
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            DataTable dt = balITM_ItemType.SelectForDropDown();
            if (dt != null && dt.Rows.Count > 0)
            {
                ddl.DataValueField = "ItemTypeID";
                ddl.DataTextField = "ItemTypeName";
                ddl.DataSource = dt;
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem("Select Item-Type", "-1"));
            }
        }
        #endregion ItemType DropDown

        #region Question DropDown
        public static void FillDropDownListQuestion(ListBox ddl)
        {
            PRD_QuestionBAL balPRD_Question = new PRD_QuestionBAL();
            DataTable dt = balPRD_Question.SelectForDropDown();
            if (dt != null && dt.Rows.Count > 0)
            {
                ddl.DataValueField = "QuestionID";
                ddl.DataTextField = "QuestionName";
                ddl.DataSource = dt;
                ddl.DataBind();
                //ddl.Items.Insert(0, new ListItem("Select Question", "-1"));
            }
        }
        #endregion Question DropDown

        #region MainModel DropDown
        public static void FillDropDownListMainModel(ListBox ddl)
        {
            PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
            DataTable dt = balPRD_MainModel.SelectForDropDown();
            if (dt != null && dt.Rows.Count > 0)
            {
                ddl.DataValueField = "MainModelID";
                ddl.DataTextField = "MainModelName";
                ddl.DataSource = dt;
                ddl.DataBind();
                ddl.Items.Insert(0, new ListItem("Select MainModel", "-1"));
            }
        }
        #endregion MainModel DropDown

    }
}