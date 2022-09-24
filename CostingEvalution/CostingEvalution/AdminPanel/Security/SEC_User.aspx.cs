using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Security
{
    public partial class SEC_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["UserID"] == null)
            {
                Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
            }
            if (!Page.IsPostBack)
            {
                FillGridView();
            }
        }

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balSEC_User.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvUser.DataSource = dt;
                gvUser.DataBind();
            }
            #endregion Bind Data
        }
        #endregion Fill GridView

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            SEC_UserENT entSEC_User = new SEC_UserENT();
            #endregion Variable

            #region Validation
            if (txtUserName.Text.Trim() == "")
            {
                ClearValidation();
                lblUserName.Visible = true;
                return;
            }
            else if (txtDisplayName.Text.Trim() == "")
            {
                ClearValidation();
                lblDisplayName.Visible = true;
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                ClearValidation();
                lblPassword.Visible = true;
                return;
            }
            else if (txtPassword.Text.Length <= 5)
            {
                ClearValidation();
                lblPasswordCharacter.Visible = true;
                return;
            }
            else if (txtConfirmPassword.Text.Trim() == "")
            {
                ClearValidation();
                lblConfirmPassword.Visible = true;
                return;
            }
            else if (!txtPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
            {
                ClearValidation();
                lblPasswordCheck.Visible = true;
                lblConfirmPasswordCheck.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfUserID.Value != "")
            {
                entSEC_User.UserID = Convert.ToInt32(hfUserID.Value.Trim());
            }
            if (txtUserName.Text.Trim() != "")
            {
                entSEC_User.UserName = txtUserName.Text.Trim();
            }
            if (txtDisplayName.Text.Trim() != "")
            {
                entSEC_User.UserDisplayName = txtDisplayName.Text.Trim();
            }
            if (txtPassword.Text.Trim() != "")
            {
                entSEC_User.UserPassword = txtPassword.Text.Trim();
            }

            entSEC_User.CreateDateTime = DateTime.Now;
            entSEC_User.CreateBy = Convert.ToInt32(Session["UserID"]);
            entSEC_User.CreateIP = Session["IP"].ToString();
            entSEC_User.UpdateDateTime = DateTime.Now;
            entSEC_User.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entSEC_User.UpdateIP = Session["IP"].ToString();
            
            #endregion Gather Data

            #region Insert/Update
            if (hfUserID.Value != "")
            {
                if (balSEC_User.Update(entSEC_User))
                {
                    ClearControl();
                    ClearValidation();
                }
                else
                {

                }
            }
            else
            {
                if (balSEC_User.Insert(entSEC_User))
                {
                    ClearControl();
                    ClearValidation();
                }
                else
                {

                }
            }
            #endregion Insert/Update
        }
        #endregion Save Click

        #region Clear Button
        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
            ClearValidation();
        }

        #region Clear Control
        private void ClearControl()
        {
            FillGridView();
            hfUserID.Value = null;
            txtUserName.Text = "";
            txtDisplayName.Text = "";

            txtPassword.TextMode = TextBoxMode.SingleLine;
            txtPassword.Text= "";
            txtPassword.TextMode = TextBoxMode.Password;

            txtConfirmPassword.TextMode = TextBoxMode.SingleLine;
            txtConfirmPassword.Text= "";
            txtConfirmPassword.TextMode = TextBoxMode.Password;
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblUserName.Visible = false;
            lblDisplayName.Visible = false;
            lblPassword.Visible = false;
            lblPasswordCheck.Visible = false;
            lblPasswordCharacter.Visible = false;
            lblConfirmPassword.Visible = false;
            lblConfirmPasswordCheck.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Button

        #region Delete/Fill For Update
        protected void gvUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            #endregion Variable

            #region Clear Validation
            ClearControl();
            ClearValidation();
            #endregion Clear Validation

            #region Delete
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balSEC_User.Delete(Convert.ToInt32(e.CommandArgument)))
                {
                    FillGridView();
                    ClearControl();
                }
                else
                {

                }
            }
            #endregion Delete

            #region Call FillDataByPK
            else if (e.CommandName == "EditRecord" && e.CommandArgument != null)
            {
                FillDataByPK(Convert.ToInt32(e.CommandArgument));
            }
            #endregion Call FillDataByPK
        }
        #endregion Delete/Fill For Update

        #region Fill_DataBy_PK
        private void FillDataByPK(SqlInt32 UserID)
        {
            #region Variable
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            SEC_UserENT entSEC_User = balSEC_User.SelectPK(UserID);
            #endregion Variable

            #region FillDate
            if (!entSEC_User.UserID.IsNull)
            {
                hfUserID.Value = entSEC_User.UserID.Value.ToString();
            }
            if (!entSEC_User.UserName.IsNull)
            {
                txtUserName.Text = entSEC_User.UserName.ToString();
            }
            if (!entSEC_User.UserDisplayName.IsNull)
            {
                txtDisplayName.Text = entSEC_User.UserDisplayName.ToString();
            }
            if (!entSEC_User.UserPassword.IsNull)
            {
                txtPassword.Attributes["value"] = entSEC_User.UserPassword.ToString();
                txtConfirmPassword.Attributes["value"] = entSEC_User.UserPassword.ToString();
            }
            #endregion FillDate
        }
        #endregion Fill_DataBy_PK

        #region PageIndex Change
        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            FillGridView();
            gvUser.DataBind();
        }
        #endregion PageIndex Change
    }
}