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

namespace CostingEvalution.AdminPanel.Master
{
    public partial class MST_Department : System.Web.UI.Page
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
            MST_DepartmentBAL balMST_Department = new MST_DepartmentBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balMST_Department.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvDepartment.DataSource = dt;
                gvDepartment.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        [Obsolete]
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            MST_DepartmentENT entMST_Department = new MST_DepartmentENT();
            MST_DepartmentBAL balMST_Department = new MST_DepartmentBAL();
            #endregion Variable

            #region Validation
            if (txtDepartmentName.Text.Trim() == "")
            {
                ClearValidation();
                lblDepartmentName.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfDepartmentID.Value != "")
            {
                entMST_Department.DepartmentID = Convert.ToInt32(hfDepartmentID.Value.Trim());
            }

            if (txtDepartmentName.Text.Trim() != "")
            {
                entMST_Department.DepartmentName = txtDepartmentName.Text.Trim();
            }

            if (txtDepartmentDescription.Text.Trim() != "")
            {
                entMST_Department.Description = txtDepartmentDescription.Text.Trim();
            }

            entMST_Department.CreateDateTime = DateTime.Now;
            entMST_Department.CreateBy = Convert.ToInt32(Session["UserID"]);
            entMST_Department.CreateIP = Session["IP"].ToString();
            entMST_Department.UpdateDateTime = DateTime.Now;
            entMST_Department.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entMST_Department.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfDepartmentID.Value != "")
            {
                if (balMST_Department.Update(entMST_Department))
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
                if (balMST_Department.Insert(entMST_Department))
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
            hfDepartmentID.Value = null;
            txtDepartmentName.Text = "";
            txtDepartmentDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblDepartmentName.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvDepartment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            MST_DepartmentBAL balMST_Department = new MST_DepartmentBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balMST_Department.Delete(Convert.ToInt32(e.CommandArgument)))
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
            MST_DepartmentBAL balMST_Department = new MST_DepartmentBAL();
            MST_DepartmentENT entMST_Department = balMST_Department.SelectPK(EmployeeDesignationID);
            #endregion Variable

            #region Fill Data
            if (!entMST_Department.DepartmentID.IsNull)
            {
                hfDepartmentID.Value = entMST_Department.DepartmentID.Value.ToString();
            }
            if (!entMST_Department.DepartmentName.IsNull)
            {
                txtDepartmentName.Text = entMST_Department.DepartmentName.Value;
            }
            if (!entMST_Department.Description.IsNull)
            {
                txtDepartmentDescription.Text = entMST_Department.Description.Value.ToString();
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvDepartment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDepartment.PageIndex = e.NewPageIndex;
            FillGridView();
            gvDepartment.DataBind();
        }
        #endregion PageIndex Change
    }
}