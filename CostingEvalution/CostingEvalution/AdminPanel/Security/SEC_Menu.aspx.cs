using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;

namespace CostingEvalution.AdminPanel.Security
{
    public partial class SEC_Menu : System.Web.UI.Page
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
            SEC_MenuBAL balSEC_Menu = new SEC_MenuBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balSEC_Menu.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvMenu.DataSource = dt;
                gvMenu.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click

        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            SEC_MenuENT entSEC_Menu = new SEC_MenuENT();
            SEC_MenuBAL balSEC_Menu = new SEC_MenuBAL();
            #endregion Variable

            #region Validation
            if (txtMenuName.Text.Trim() == "")
            {
                ClearValidation();
                lblMenuName.Visible = true;
                return;
            }
            if (txtMenuURL.Text.Trim() == "")
            {
                ClearValidation();
                lblMenuURL.Visible = true;
                return;
            }
            if (txtMenuSequence.Text.Trim() == "")
            {
                ClearValidation();
                lblMenuSequence.Visible = true;
                return;
            }

            #endregion Validation

            #region Gather Data
            if (hfMenuID.Value != "")
            {
                entSEC_Menu.MenuID = Convert.ToInt32(hfMenuID.Value.Trim());
            }

            if (txtMenuName.Text.Trim() != "")
            {
                entSEC_Menu.MenuName = txtMenuName.Text.Trim();
            }

            //if (txtMenuImage.Text.Trim() != "")
            //{
            //    entMenu.MenuImagePath = txtMenuImage.Text.Trim();
            //}

            if (txtMenuURL.Text.Trim() != "")
            {
                entSEC_Menu.MenuURL = txtMenuURL.Text.Trim();
            }

            if (txtMenuSequence.Text.Trim() != "")
            {
                entSEC_Menu.MenuSequence = Convert.ToDecimal(txtMenuSequence.Text);
            }

            entSEC_Menu.CreateDateTime = DateTime.Now;
            entSEC_Menu.CreateBy = Convert.ToInt32(Session["UserID"]);
            entSEC_Menu.CreateIP = Session["IP"].ToString();
            entSEC_Menu.UpdateDateTime = DateTime.Now;
            entSEC_Menu.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entSEC_Menu.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfMenuID.Value != "")
            {
                if (balSEC_Menu.Update(entSEC_Menu))
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
                if (balSEC_Menu.Insert(entSEC_Menu))
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

        #region Clear Control
        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
            ClearValidation();
        }

        #region Clear Control
        private void ClearControl()
        {
            FillGridView();
            hfMenuID.Value = null;
            txtMenuName.Text = "";
            //txtMenuImage.Text = "";
            txtMenuURL.Text = "";
            txtMenuSequence.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblMenuName.Visible = false;
            lblMenuURL.Visible = false;
            lblMenuSequence.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvMenu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            SEC_MenuBAL balSEC_Menu = new SEC_MenuBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balSEC_Menu.Delete(Convert.ToInt32(e.CommandArgument)))
                {
                    ClearControl();
                }
                else
                {

                }
            }
            #endregion Delete Record

            #region Call FillDataByPK
            else if (e.CommandName == "EditRecord" && e.CommandArgument != null)
            {
                FillDataByPK(Convert.ToInt32(e.CommandArgument));
            }
            #endregion Call FillDataByPK
        }
        #endregion Delete/Update

        #region FillDataByPK
        private void FillDataByPK(SqlInt32 MenuID)
        {
            #region Variable
            SEC_MenuBAL balSEC_Menu = new SEC_MenuBAL();
            SEC_MenuENT entSEC_Menu = balSEC_Menu.SelectPK(MenuID);
            #endregion Variable

            #region Fill Data
            if (!entSEC_Menu.MenuID.IsNull)
            {
                hfMenuID.Value = entSEC_Menu.MenuID.Value.ToString();
            }
            if (!entSEC_Menu.MenuName.IsNull)
            {
                txtMenuName.Text = entSEC_Menu.MenuName.Value;
            }
            //if (!entMenu.MenuImagePath.IsNull)
            //{
            //    txtMenuImage.Text = entMenu.MenuImagePath.Value;
            //}
            if (!entSEC_Menu.MenuURL.IsNull)
            {
                txtMenuURL.Text = entSEC_Menu.MenuURL.Value;
            }
            if (!entSEC_Menu.MenuSequence.Equals(null))
            {
                txtMenuSequence.Text = entSEC_Menu.MenuSequence.ToString();
            }
            #endregion Fill Data

        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvMenu_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMenu.PageIndex = e.NewPageIndex;
            FillGridView();
            gvMenu.DataBind();
        }
        #endregion PageIndex Change
    }
}