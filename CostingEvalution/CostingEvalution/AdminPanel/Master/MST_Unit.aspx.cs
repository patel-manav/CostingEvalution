using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Master
{
    public partial class MST_Unit : System.Web.UI.Page
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
            MST_UnitBAL balMST_Unit = new MST_UnitBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balMST_Unit.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvUnit.DataSource = dt;
                gvUnit.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        [Obsolete]
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            MST_UnitENT entMST_Unit = new MST_UnitENT();
            MST_UnitBAL balMST_Unit = new MST_UnitBAL();
            #endregion Variable

            #region Validation
            if (txtUnitName.Text.Trim() == "")
            {
                ClearValidation();
                lblUnitName.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfUnitID.Value != "")
            {
                entMST_Unit.UnitID = Convert.ToInt32(hfUnitID.Value.Trim());
            }

            if (txtUnitName.Text.Trim() != "")
            {
                entMST_Unit.UnitName = txtUnitName.Text.Trim();
            }

            if (txtUnitDescription.Text.Trim() != "")
            {
                entMST_Unit.Description = txtUnitDescription.Text.Trim();
            }



            entMST_Unit.CreateDateTime = DateTime.Now;
            entMST_Unit.CreateBy = Convert.ToInt32(Session["UserID"]);
            entMST_Unit.CreateIP = Session["IP"].ToString();
            entMST_Unit.UpdateDateTime = DateTime.Now;
            entMST_Unit.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entMST_Unit.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfUnitID.Value != "")
            {
                if (balMST_Unit.Update(entMST_Unit))
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
                if (balMST_Unit.Insert(entMST_Unit))
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
            hfUnitID.Value = null;
            txtUnitName.Text = "";
            txtUnitDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblUnitName.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvUnit_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            MST_UnitBAL balMST_Unit = new MST_UnitBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balMST_Unit.Delete(Convert.ToInt32(e.CommandArgument)))
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
            MST_UnitBAL balMST_Unit = new MST_UnitBAL();
            MST_UnitENT entMST_Unit = balMST_Unit.SelectPK(EmployeeDesignationID);
            #endregion Variable

            #region Fill Data
            if (!entMST_Unit.UnitID.IsNull)
            {
                hfUnitID.Value = entMST_Unit.UnitID.Value.ToString();
            }
            if (!entMST_Unit.UnitName.IsNull)
            {
                txtUnitName.Text = entMST_Unit.UnitName.Value;
            }
            if (!entMST_Unit.Description.IsNull)
            {
                txtUnitDescription.Text = entMST_Unit.Description.Value.ToString();
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvUnit_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUnit.PageIndex = e.NewPageIndex;
            FillGridView();
            gvUnit.DataBind();
        }
        #endregion PageIndex Change
    }
}