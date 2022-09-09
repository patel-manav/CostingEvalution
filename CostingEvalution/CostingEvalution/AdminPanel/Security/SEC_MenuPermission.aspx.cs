using CostingEvalution.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CostingEvalution.App_Code.BAL;

namespace CostingEvalution.AdminPanel.Security
{
    public partial class SEC_MenuPermission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["UserID"] == null)
            {
                Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
            }
            if (!Page.IsPostBack)
            {
                FillDropDownList();
                ddlUserID_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        #region Fill DropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListUser(ddlUserID);
        }
        #endregion Fill DropDownList

        #region UserIndexChange
        protected void ddlUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMenuList(Convert.ToInt32(ddlUserID.SelectedValue));
        }
        #endregion UserIndexChange

        #region FillMenu
        private void FillMenuList(SqlInt32 userID)
        {
            SEC_UserWiseMenuBAL balSEC_UserWiseMenu = new SEC_UserWiseMenuBAL();
            DataTable dt = balSEC_UserWiseMenu.Select(userID);
            if (dt != null && dt.Rows.Count > 0)
            {
                MenuList.DataSource = dt;
                MenuList.DataBind();
            }
        }
        #endregion FillMenu

        #region SaveButton
        protected void Save_Click(object sender, EventArgs e)
        {
            SEC_UserWiseMenuBAL balSEC_UserWiseMenu = new SEC_UserWiseMenuBAL();

            SqlInt32 UserID = SqlInt32.Null;

            UserID = Convert.ToInt32(ddlUserID.SelectedValue);

            balSEC_UserWiseMenu.Delete(UserID);

            foreach (RepeaterItem item in MenuList.Items)
            {
                HiddenField hfMenuID = (HiddenField)item.FindControl("hfMenuID");
                CheckBox cbMenuID = (CheckBox)item.FindControl("cbMenuID");

                if (cbMenuID.Checked)
                {
                    balSEC_UserWiseMenu.Insert(UserID, Convert.ToInt32(hfMenuID.Value));
                }
            }
            ClearGridAndUser();
        }
        #endregion SaveButton

        #region Clear Button

        private void ClearGridAndUser()
        {
            ddlUserID.SelectedIndex = 0;
            FillMenuList(0);
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ClearGridAndUser();
        }
        #endregion Clear Button
    }
}