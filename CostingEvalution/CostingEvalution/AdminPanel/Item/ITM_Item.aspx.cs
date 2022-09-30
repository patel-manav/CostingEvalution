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

namespace CostingEvalution.AdminPanel.Item
{
    public partial class ITM_Item : System.Web.UI.Page
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
                //FillGridView();
            }
        }

        #region FillDropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListItemType(ddlItemType);
            CommonFillMethods.FillDropDownListMainModel(lbMainModel);

        }
        #endregion FillDropDownList

        #region Fill GridView
        //private void FillGridView()
        //{
        //    #region Variable
        //    ITM_ItemBAL balITM_Item = new ITM_ItemBAL();
        //    #endregion Variable

        //    #region Bind Data
        //    DataTable dt = balITM_Item.Select();

        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        gvQuestion.DataSource = dt;
        //        gvQuestion.DataBind();
        //    }
        //    #endregion Bind Data

        //}
        #endregion Fill GridView

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            ITM_ItemENT entITM_Item = new ITM_ItemENT();
            ITM_ItemBAL balITM_Item = new ITM_ItemBAL();

            ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel = new ITM_ItemWiseMainModelENT();
            ITM_ItemWiseMainModelBAL balITM_ItemWiseMainModel = new ITM_ItemWiseMainModelBAL();

            #endregion Variable

            #region Validation
            if (txtItemName.Text.Trim() == "")
            {
                ClearValidation();
                lblItemName.Visible = true;
                return;
            }
            else if (ddlItemType.SelectedIndex == 0)
            {
                ClearValidation();
                ddlItemType.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfItemID.Value != "")
            {
                entITM_Item.ItemID = Convert.ToInt32(hfItemID.Value.Trim());
            }

            if (txtItemName.Text.Trim() != "")
            {
                entITM_Item.ItemName = txtItemName.Text.Trim();
            }

            if (ddlItemType.SelectedIndex != 0)
            {
                entITM_Item.ItemTypeID = Convert.ToInt32(ddlItemType.SelectedValue.ToString());
            }

            entITM_Item.CreateDateTime = entITM_ItemWiseMainModel.CreateDateTime = DateTime.Now;
            entITM_Item.CreateBy = entITM_ItemWiseMainModel.CreateBy = Convert.ToInt32(Session["UserID"]);
            entITM_Item.CreateIP = entITM_ItemWiseMainModel.CreateIP = Session["IP"].ToString();
            entITM_Item.UpdateDateTime = entITM_ItemWiseMainModel.UpdateDateTime = DateTime.Now;
            entITM_Item.UpdateBy = entITM_ItemWiseMainModel.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entITM_Item.UpdateIP = entITM_ItemWiseMainModel.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfItemID.Value != "")
            {
                if (balITM_Item.Update(entITM_Item))
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
                if (balITM_Item.Insert(entITM_Item))
                {
                    #region SelectMultipleModel
                    foreach (int selectedIndex in lbMainModel.GetSelectedIndices())
                    {
                        //Console.WriteLine(ddlQuestion.Items[selectedIndex].Value);
                        entITM_ItemWiseMainModel.ItemID = entITM_Item.ItemID;
                        entITM_ItemWiseMainModel.MainModelID = Convert.ToInt32(lbMainModel.Items[selectedIndex].Value);

                        balITM_ItemWiseMainModel.Insert(entITM_ItemWiseMainModel);
                    }
                    #endregion SelectMultipleModel
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
            //FillGridView();
            hfItemID.Value = null;
            txtItemName.Text = "";
            ddlItemType.SelectedIndex = 0;
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblItemName.Visible = false;
            lblItemType.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        //protected void gvMainModel_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    #region Variable
        //    PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
        //    #endregion Variable

        //    #region Clear Validation
        //    ClearValidation();
        //    #endregion Clear Validation

        //    #region Delete Record
        //    if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        //    {
        //        if (balPRD_MainModel.Delete(Convert.ToInt32(e.CommandArgument)))
        //        {
        //            ClearControl();
        //        }
        //        else
        //        {

        //        }
        //    }
        //    #endregion Delete Record

        //    #region Call FillDataByPK
        //    else if (e.CommandName == "EditRecord" && e.CommandArgument != null)
        //    {
        //        FillDataByPK(Convert.ToInt32(e.CommandArgument));
        //    }
        //    #endregion Call FillDataByPK
        //}
        #endregion Delete/Update

        #region FillDataByPK
        //private void FillDataByPK(SqlInt32 MainModelID)
        //{
        //    #region Variable
        //    PRD_MainModelBAL balPRD_MainModel = new PRD_MainModelBAL();
        //    PRD_MainModelENT entPRD_MainModel = balPRD_MainModel.SelectPK(MainModelID);
        //    #endregion Variable

        //    #region Fill Data
        //    if (!entPRD_MainModel.MainModelID.IsNull)
        //    {
        //        hfMainModelID.Value = entPRD_MainModel.MainModelID.Value.ToString();
        //    }
        //    if (!entPRD_MainModel.MainModelName.IsNull)
        //    {
        //        txtMainModelName.Text = entPRD_MainModel.MainModelName.Value;
        //    }
        //    //if (!entPRD_Question.ItemTypeID.IsNull)
        //    //{
        //    //    ddlItemType.SelectedValue = entPRD_Question.ItemTypeID.Value.ToString();
        //    //}
        //    //if (!entPRD_Question.Description.IsNull)
        //    //{
        //    //    txtQuestionDescription.Text = entPRD_Question.Description.Value.ToString();
        //    //}
        //    #endregion Fill Data
        //}
        #endregion FillDataByPK

        #region PageIndex Change
        //protected void gvMainModel_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    gvMainModel.PageIndex = e.NewPageIndex;
        //    FillGridView();
        //    gvMainModel.DataBind();
        //}
        #endregion PageIndex Change 
    }
}