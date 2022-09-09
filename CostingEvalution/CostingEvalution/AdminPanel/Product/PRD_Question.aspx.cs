using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code.ENT;
using CostingEvalution.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Product
{
    public partial class PRD_Question : System.Web.UI.Page
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
            CommonFillMethods.FillDropDownListItemType(ddlItemType);
        }
        #endregion FillDropDownList

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            PRD_QuestionBAL balPRD_Question = new PRD_QuestionBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balPRD_Question.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvQuestion.DataSource = dt;
                gvQuestion.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        [Obsolete]
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            PRD_QuestionENT entPRD_Question = new PRD_QuestionENT();
            PRD_QuestionBAL balPRD_Question = new PRD_QuestionBAL();
            #endregion Variable

            #region Validation
            if (txtQuestionName.Text.Trim() == "")
            {
                ClearValidation();
                lblQuestionName.Visible = true;
                return;
            }
            else if (ddlItemType.SelectedIndex == 0)
            {
                ClearValidation();
                lblItemType.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfQuestionID.Value != "")
            {
                entPRD_Question.QuestionID = Convert.ToInt32(hfQuestionID.Value.Trim());
            }

            if (txtQuestionName.Text.Trim() != "")
            {
                entPRD_Question.QuestionName = txtQuestionName.Text.Trim();
            }

            if (ddlItemType.SelectedIndex != 0)
            {
                entPRD_Question.ItemTypeID = Convert.ToInt32(ddlItemType.SelectedValue.ToString());
            }

            if (txtQuestionDescription.Text.Trim() != "")
            {
                entPRD_Question.Description = txtQuestionDescription.Text.Trim();
            }

            entPRD_Question.CreateDateTime = DateTime.Now;
            entPRD_Question.CreateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_Question.CreateIP = Session["IP"].ToString();
            entPRD_Question.UpdateDateTime = DateTime.Now;
            entPRD_Question.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_Question.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfQuestionID.Value != "")
            {
                if (balPRD_Question.Update(entPRD_Question))
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
                if (balPRD_Question.Insert(entPRD_Question))
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
            hfQuestionID.Value = null;
            txtQuestionName.Text = "";
            ddlItemType.SelectedIndex = 0;
            txtQuestionDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblQuestionName.Visible = false;
            lblItemType.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvQuestion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            PRD_QuestionBAL balPRD_Question = new PRD_QuestionBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balPRD_Question.Delete(Convert.ToInt32(e.CommandArgument)))
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
            PRD_QuestionBAL balPRD_Question = new PRD_QuestionBAL();
            PRD_QuestionENT entPRD_Question = balPRD_Question.SelectPK(EmployeeDesignationID);
            #endregion Variable

            #region Fill Data
            if (!entPRD_Question.QuestionID.IsNull)
            {
                hfQuestionID.Value = entPRD_Question.QuestionID.Value.ToString();
            }
            if (!entPRD_Question.QuestionName.IsNull)
            {
                txtQuestionName.Text = entPRD_Question.QuestionName.Value;
            }
            if (!entPRD_Question.ItemTypeID.IsNull)
            {
                ddlItemType.SelectedValue = entPRD_Question.ItemTypeID.Value.ToString();
            }
            if (!entPRD_Question.Description.IsNull)
            {
                txtQuestionDescription.Text = entPRD_Question.Description.Value.ToString();
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvQuestion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvQuestion.PageIndex = e.NewPageIndex;
            FillGridView();
            gvQuestion.DataBind();
        }
        #endregion PageIndex Change 
    }
}