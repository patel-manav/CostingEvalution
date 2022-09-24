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
using CostingEvalution.App_Code.DAL;

namespace CostingEvalution.AdminPanel.Product
{
    public partial class PRD_MainModel : System.Web.UI.Page
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
            CommonFillMethods.FillDropDownListQuestion(lbQuestion);
            //ddlQuestion.Items[0].Selected = true;p
        }

        #endregion FillDropDownList

        #region Fill GridView
        private void FillGridView()
        {
            #region Variable
            PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balPRD_MainModel.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvMainModel.DataSource = dt;
                gvMainModel.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            PRD_MainModelENT entPRD_MainModel = new PRD_MainModelENT();
            PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();

            PRD_MainModelWiseQuestionENT entPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionENT();
            PRD_MainModelWiseQuestionBAL balPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionBAL();
            #endregion Variable

            #region Validation
            if (txtMainModelName.Text.Trim() == "")
            {
                ClearValidation();
                lblMainModelName.Visible = true;
                return;
            }
            else if (lbQuestion.Items.Count == 0)
            {
                ClearValidation();
                lblQuestion.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfMainModelID.Value != "")
            {
                entPRD_MainModel.MainModelID = Convert.ToInt32(hfMainModelID.Value.Trim());
            }
            
            if (txtMainModelName.Text.Trim() != "")
            {
                entPRD_MainModel.MainModelName = txtMainModelName.Text.Trim();
            }
      
            entPRD_MainModel.CreateDateTime = DateTime.Now;
            entPRD_MainModel.CreateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_MainModel.CreateIP = Session["IP"].ToString();
            entPRD_MainModel.UpdateDateTime = DateTime.Now;
            entPRD_MainModel.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_MainModel.UpdateIP = Session["IP"].ToString();

            entPRD_MainModelWiseQuestion.CreateDateTime = DateTime.Now;
            entPRD_MainModelWiseQuestion.CreateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_MainModelWiseQuestion.CreateIP = Session["IP"].ToString();
            entPRD_MainModelWiseQuestion.UpdateDateTime = DateTime.Now;
            entPRD_MainModelWiseQuestion.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entPRD_MainModelWiseQuestion.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfMainModelID.Value != "")
            {
                if (balPRD_MainModel.Update(entPRD_MainModel))
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
                if (balPRD_MainModel.Insert(entPRD_MainModel))
                {
                    #region SelectMultipleQuestion
                    foreach (int selectedIndex in lbQuestion.GetSelectedIndices())
                    {
                        //Console.WriteLine(ddlQuestion.Items[selectedIndex].Value);
                        entPRD_MainModelWiseQuestion.MainModelID = entPRD_MainModel.MainModelID;
                        entPRD_MainModelWiseQuestion.QuestionID = Convert.ToInt32(lbQuestion.Items[selectedIndex].Value);

                        balPRD_MainModelWiseQuestion.Insert(entPRD_MainModelWiseQuestion);
                    }
                    #endregion SelectMultipleQuestion
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
            hfMainModelID.Value = null;
            txtMainModelName.Text = "";
            lbQuestion.Items.Remove(lbQuestion.SelectedItem);
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblMainModelName.Visible = false;
            lblQuestion.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvMainModel_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balPRD_MainModel.Delete(Convert.ToInt32(e.CommandArgument)))
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
        private void FillDataByPK(SqlInt32 MainModelID)
        {
            #region Variable
            PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
            PRD_MainModelENT entPRD_MainModel = balPRD_MainModel.SelectPK(MainModelID);
            #endregion Variable

            #region Fill Data
            if (!entPRD_MainModel.MainModelID.IsNull)
            {
                hfMainModelID.Value = entPRD_MainModel.MainModelID.Value.ToString();
            }
            if (!entPRD_MainModel.MainModelName.IsNull)
            {
                txtMainModelName.Text = entPRD_MainModel.MainModelName.Value;
            }
            //if (!entPRD_Question.ItemTypeID.IsNull)
            //{
            //    ddlItemType.SelectedValue = entPRD_Question.ItemTypeID.Value.ToString();
            //}
            //if (!entPRD_Question.Description.IsNull)
            //{
            //    txtQuestionDescription.Text = entPRD_Question.Description.Value.ToString();
            //}
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvMainModel_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMainModel.PageIndex = e.NewPageIndex;
            FillGridView();
            gvMainModel.DataBind();
        }
        #endregion PageIndex Change 
    }
}