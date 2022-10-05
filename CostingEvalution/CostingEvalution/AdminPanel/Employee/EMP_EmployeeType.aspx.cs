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

namespace CostingEvalution.AdminPanel.Employee
{
    public partial class EMP_EmployeeType : System.Web.UI.Page
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
                FillDropDown();
            }
        }

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            EMP_EmployeeTypeBAL balEMP_EmployeeType = new EMP_EmployeeTypeBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balEMP_EmployeeType.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvEmployeeType.DataSource = dt;
                gvEmployeeType.DataBind();
            }
            #endregion Bind Data

        }
        #endregion Fill GridView

        #region FillDropDown
        private void FillDropDown()
        {
            ddlEmployeeTypeForNosHour.Items.Insert(0, new ListItem("Select For Hour/Nos", "Select For Hour/Nos"));
            ddlEmployeeTypeForNosHour.Items.Insert(1, new ListItem("Hour", "True"));
            ddlEmployeeTypeForNosHour.Items.Insert(2, new ListItem("Nos", "False"));
        }
        #endregion FillDropDown

        #region Save Click

        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            EMP_EmployeeTypeENT entEMP_EmployeeType = new EMP_EmployeeTypeENT();
            EMP_EmployeeTypeBAL balEMP_EmployeeType = new EMP_EmployeeTypeBAL();
            #endregion Variable

            #region Validation
            if (txtEmployeeTypeName.Text.Trim() == "")
            {
                ClearValidation();
                lblEmployeeTypeName.Visible = true;
                return;
            }
            if (ddlEmployeeTypeForNosHour.SelectedIndex == 0)
            {
                ClearValidation();
                lblEmployeeTypeForNosHour.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfEmployeeTypeID.Value != "")
            {
                entEMP_EmployeeType.EmployeeTypeID = Convert.ToInt32(hfEmployeeTypeID.Value.Trim());
            }

            if (txtEmployeeTypeName.Text.Trim() != "")
            {
                entEMP_EmployeeType.EmployeeTypeName = txtEmployeeTypeName.Text.Trim();
            }

            if (ddlEmployeeTypeForNosHour.SelectedIndex != 0)
            {
                entEMP_EmployeeType.IsEmployeeTypeForHourAndNos = Convert.ToBoolean(ddlEmployeeTypeForNosHour.SelectedValue);
            }

            if (txtDescription.Text.Trim() != "")
            {
                entEMP_EmployeeType.Description = txtDescription.Text.Trim();
            }

            entEMP_EmployeeType.CreateDateTime = DateTime.Now;
            entEMP_EmployeeType.CreateBy = Convert.ToInt32(Session["UserID"]);
            entEMP_EmployeeType.CreateIP = Session["IP"].ToString();
            entEMP_EmployeeType.UpdateDateTime = DateTime.Now;
            entEMP_EmployeeType.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entEMP_EmployeeType.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfEmployeeTypeID.Value != "")
            {
                if (balEMP_EmployeeType.Update(entEMP_EmployeeType))
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
                if (balEMP_EmployeeType.Insert(entEMP_EmployeeType))
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
            hfEmployeeTypeID.Value = null;
            txtEmployeeTypeName.Text = "";
            ddlEmployeeTypeForNosHour.SelectedIndex = 0;
            txtDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblEmployeeTypeName.Visible = false;
            lblEmployeeTypeForNosHour.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvEmployeeType_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            EMP_EmployeeTypeBAL balEMP_EmployeeType = new EMP_EmployeeTypeBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balEMP_EmployeeType.Delete(Convert.ToInt32(e.CommandArgument)))
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
        private void FillDataByPK(SqlInt32 EmployeeTypeID)
        {
            #region Variable
            EMP_EmployeeTypeBAL balEMP_EmployeeType = new EMP_EmployeeTypeBAL();
            EMP_EmployeeTypeENT entEMP_EmployeeType = balEMP_EmployeeType.SelectPK(EmployeeTypeID);

            #endregion Variable

            #region Fill Data
            if (!entEMP_EmployeeType.EmployeeTypeID.IsNull)
            {
                hfEmployeeTypeID.Value = entEMP_EmployeeType.EmployeeTypeID.Value.ToString();
            }

            if (!entEMP_EmployeeType.EmployeeTypeName.IsNull)
            {
                txtEmployeeTypeName.Text = entEMP_EmployeeType.EmployeeTypeName.Value;
            }

            if (!entEMP_EmployeeType.IsEmployeeTypeForHourAndNos.IsNull)
            {
                ddlEmployeeTypeForNosHour.SelectedValue = entEMP_EmployeeType.IsEmployeeTypeForHourAndNos.ToString();
            }

            if (!entEMP_EmployeeType.Description.IsNull)
            {
                txtDescription.Text = entEMP_EmployeeType.Description.Value;
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvEmployeeType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployeeType.PageIndex = e.NewPageIndex;
            FillGridView();
            gvEmployeeType.DataBind();
        }
        #endregion PageIndex Change
    }
}
