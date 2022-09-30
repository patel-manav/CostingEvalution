using CostingEvalution.App_Code;
using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Master
{
    public partial class MST_RawMaterial : System.Web.UI.Page
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
                FillGridView();
            }
        }

        #region FillDropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListUnit(ddlUnit);
        }
        #endregion FillDropDownList

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            MST_RawMaterialBAL balMST_RawMaterial = new MST_RawMaterialBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balMST_RawMaterial.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvRawMaterial.DataSource = dt;
                gvRawMaterial.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            MST_RawMaterialENT entMST_RawMaterial = new MST_RawMaterialENT();
            MST_RawMaterialBAL balMST_RawMaterial = new MST_RawMaterialBAL();
            #endregion Variable

            #region Validation
            if (txtRawMaterialName.Text.Trim() == "")
            {
                ClearValidation();
                lblRawMaterialName.Visible = true;
                return;
            }
            else if (ddlUnit.SelectedIndex == 0)
            {
                ClearValidation();
                lblUnit.Visible = true;
                return;
            }
            else if(txtRawMaterialPrice.Text.Trim()=="")
            {
                ClearValidation();
                lblRawMaterialPrice.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfRawMaterialID.Value != "")
            {
                entMST_RawMaterial.RawMaterialID = Convert.ToInt32(hfRawMaterialID.Value.Trim());
            }

            if (txtRawMaterialName.Text.Trim() != "")
            {
                entMST_RawMaterial.RawMaterialName = txtRawMaterialName.Text.Trim();
            }

            if (ddlUnit.SelectedIndex != 0)
            {
                entMST_RawMaterial.UnitID = Convert.ToInt32(ddlUnit.SelectedValue.ToString());
            }

            if (txtRawMaterialPrice.Text.Trim() != "")
            {
                entMST_RawMaterial.RawMaterialPrice = Convert.ToDecimal(txtRawMaterialPrice.Text);
            }

            if (txtRawMaterialDescription.Text.Trim() != "")
            {
                entMST_RawMaterial.Description = txtRawMaterialDescription.Text.Trim();
            }

            entMST_RawMaterial.CreateDateTime = DateTime.Now;
            entMST_RawMaterial.CreateBy = Convert.ToInt32(Session["UserID"]);
            entMST_RawMaterial.CreateIP = Session["IP"].ToString();
            entMST_RawMaterial.UpdateDateTime = DateTime.Now;
            entMST_RawMaterial.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entMST_RawMaterial.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfRawMaterialID.Value != "")
            {
                if (balMST_RawMaterial.Update(entMST_RawMaterial))
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
                if (balMST_RawMaterial.Insert(entMST_RawMaterial))
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
            hfRawMaterialID.Value = null;
            txtRawMaterialName.Text = "";
            ddlUnit.SelectedIndex = 0;
            txtRawMaterialPrice.Text = "";
            txtRawMaterialDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblRawMaterialName.Visible = false;
            lblRawMaterialPrice.Visible = false;
            lblUnit.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvRawMaterial_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            MST_RawMaterialBAL balMST_RawMaterial = new MST_RawMaterialBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balMST_RawMaterial.Delete(Convert.ToInt32(e.CommandArgument)))
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
        private void FillDataByPK(SqlInt32 EmployeeDesignationID)
        {
            #region Variable
            MST_RawMaterialBAL balMST_RawMaterial = new MST_RawMaterialBAL();
            MST_RawMaterialENT entMST_RawMaterial = balMST_RawMaterial.SelectPK(EmployeeDesignationID);
            #endregion Variable

            #region Fill Data
            if (!entMST_RawMaterial.RawMaterialID.IsNull)
            {
                hfRawMaterialID.Value = entMST_RawMaterial.RawMaterialID.Value.ToString();
            }
            if (!entMST_RawMaterial.RawMaterialName.IsNull)
            {
                txtRawMaterialName.Text = entMST_RawMaterial.RawMaterialName.Value;
            }
            if (!entMST_RawMaterial.UnitID.IsNull)
            {
                ddlUnit.SelectedValue = entMST_RawMaterial.UnitID.Value.ToString();
            }
            if (!entMST_RawMaterial.RawMaterialPrice.Equals(null))
            {
                txtRawMaterialPrice.Text = entMST_RawMaterial.RawMaterialPrice.ToString();
            }
            if (!entMST_RawMaterial.Description.IsNull)
            {
                txtRawMaterialDescription.Text = entMST_RawMaterial.Description.Value.ToString();
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvRawMaterial_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvRawMaterial.PageIndex = e.NewPageIndex;
            FillGridView();
            gvRawMaterial.DataBind();
        }
        #endregion PageIndex Change
    }
}