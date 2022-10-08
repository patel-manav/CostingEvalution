using CostingEvalution.App_Code;
using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Employee
{
    public partial class EMP_Employee : System.Web.UI.Page
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
                FillDropDownList();
            }
        }

        #region FillDropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListDepartment(lbDepartment);
        }
        #endregion FillDropDownList

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            EMP_EmployeeBAL balEMP_Employee = new EMP_EmployeeBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balEMP_Employee.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvEmployee.DataSource = dt;
                gvEmployee.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            EMP_EmployeeENT entEMP_Employee = new EMP_EmployeeENT();
            EMP_EmployeeBAL balEMP_Employee = new EMP_EmployeeBAL();

            EMP_EmployeeWiseDepartmentENT entEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentENT();
            EMP_EmployeeWiseDepartmentBAL balEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentBAL();
            #endregion Variable

            #region Validation
            if (txtEmployeeName.Text.Trim() == "")
            {
                ClearValidation();
                lblEmployeeName.Visible = true;
                return;
            }
            else if (lbDepartment.GetSelectedIndices().Count() <= 0)
            {
                ClearValidation();
                lblEmployeeDepartment.Visible = true;
                return;
            }
            else if(txtPricePerHour.Text.Trim() == "")
            {
                ClearValidation();
                lblPricePerHour.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfEmployeeID.Value != "")
            {
                entEMP_Employee.EmployeeID = Convert.ToInt32(hfEmployeeID.Value.Trim());
            }

            if (txtEmployeeName.Text.Trim() != "")
            {
                entEMP_Employee.EmployeeName = txtEmployeeName.Text.Trim();
            }

            if (txtPricePerHour.Text != "")
            {
                entEMP_Employee.PricePerHour = Convert.ToInt32(txtPricePerHour.Text);
            }

            if (txtDescription.Text.Trim() != "")
            {
                entEMP_Employee.Description = txtDescription.Text.Trim();
            }
            
            entEMP_Employee.EmployeeTypeID = 1;
            entEMP_Employee.CreateDateTime = entEMP_EmployeeWiseDepartment.CreateDateTime = DateTime.Now;
            entEMP_Employee.CreateBy = entEMP_EmployeeWiseDepartment.CreateBy = Convert.ToInt32(Session["UserID"]);
            entEMP_Employee.CreateIP = entEMP_EmployeeWiseDepartment.CreateIP = Session["IP"].ToString();
            entEMP_Employee.UpdateDateTime = entEMP_EmployeeWiseDepartment.UpdateDateTime = DateTime.Now;
            entEMP_Employee.UpdateBy = entEMP_EmployeeWiseDepartment.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entEMP_Employee.UpdateIP = entEMP_EmployeeWiseDepartment.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfEmployeeID.Value != "")
            {
                balEMP_EmployeeWiseDepartment.Delete(Convert.ToInt32(hfEmployeeID.Value));
                #region Insert Multiple Main-Model
                foreach (int selectedIndex in lbDepartment.GetSelectedIndices())
                {
                    entEMP_EmployeeWiseDepartment.EmployeeID = entEMP_Employee.EmployeeID;
                    entEMP_EmployeeWiseDepartment.DepartmentID = Convert.ToInt32(lbDepartment.Items[selectedIndex].Value);

                    balEMP_EmployeeWiseDepartment.Insert(entEMP_EmployeeWiseDepartment);
                }
                #endregion Insert Multiple Main-Model
                ClearControl();
                ClearValidation();
            }
            else
            {
                if (balEMP_Employee.Insert(entEMP_Employee))
                {
                    #region Insert Multiple Main-Model
                    foreach (int selectedIndex in lbDepartment.GetSelectedIndices())
                    {
                        entEMP_EmployeeWiseDepartment.EmployeeID = entEMP_Employee.EmployeeID;
                        entEMP_EmployeeWiseDepartment.DepartmentID = Convert.ToInt32(lbDepartment.Items[selectedIndex].Value);

                        balEMP_EmployeeWiseDepartment.Insert(entEMP_EmployeeWiseDepartment);
                    }
                    #endregion Insert Multiple Main-Model

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
            hfEmployeeID.Value = null;
            txtEmployeeName.Text = "";
            lbDepartment.ClearSelection();
            txtPricePerHour.Text = "";
            txtDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblEmployeeName.Visible = false;
            lblEmployeeDepartment.Visible = false;
            lblPricePerHour.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region PageIndex Change
        protected void gvEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployee.PageIndex = e.NewPageIndex;
            FillGridView();
            gvEmployee.DataBind();
        }
        #endregion PageIndex Change 

        #region Delete/Update
        protected void gvEmployee_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            EMP_EmployeeBAL balEMP_Employee = new EMP_EmployeeBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balEMP_Employee.Delete(Convert.ToInt32(e.CommandArgument)))
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
        private void FillDataByPK(SqlInt32 EmployeeID)
        {
            #region Variable
            EMP_EmployeeBAL balEMP_Employee = new EMP_EmployeeBAL();
            EMP_EmployeeENT entEMP_Employee = balEMP_Employee.SelectPK(EmployeeID);

            EMP_EmployeeWiseDepartmentBAL balEMP_EmployeeWiseDepartment = new EMP_EmployeeWiseDepartmentBAL();
            DataTable dtDepartmentForEmployee = balEMP_EmployeeWiseDepartment.SelectByEmployeeId(EmployeeID);

            #endregion Variable

            #region Fill Data
            if (!entEMP_Employee.EmployeeID.IsNull)
            {
                hfEmployeeID.Value = entEMP_Employee.EmployeeID.Value.ToString();
            }

            if (!entEMP_Employee.EmployeeName.IsNull)
            {
                txtEmployeeName.Text = entEMP_Employee.EmployeeName.Value;
            }

            if (!entEMP_Employee.PricePerHour.IsNull)
            {
                txtPricePerHour.Text = entEMP_Employee.PricePerHour.Value.ToString();
            }

            if (dtDepartmentForEmployee.Rows.Count > 0)
            {
                foreach (DataRow drDepartment in dtDepartmentForEmployee.Rows)
                {
                    string departmentId = drDepartment["DepartmentID"].ToString();

                    if (drDepartment["DepartmentID"].ToString() != String.Empty)
                    {
                        lbDepartment.Items.FindByValue(departmentId).Selected = true;
                    }
                }
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK
    }
}