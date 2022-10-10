using CostingEvalution.App_Code.BAL;
using CostingEvalution.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Costing
{
    public partial class Costing : System.Web.UI.Page
    {
        static DataTable dtItem;
        static int dtId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["UserID"] == null)
            {
                Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
            }
            if (!Page.IsPostBack)
            {
                FillDropDownList();
                //initItemDataTable();
                //QuestionRepeator();
                //ddlMainModel_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        #region Fill DropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListMainMosdel(ddlMainModel);
        }
        #endregion Fill DropDownList

        #region MainModel Index Change
        protected void ddlMainModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMainModel.SelectedIndex == 0)
            {
                rpQuestionList.DataSource = null;
                rpQuestionList.DataBind();
            }
            else
            {
                FillQuestionList(Convert.ToInt32(ddlMainModel.SelectedValue));
            }
        }
        #endregion MainModel Index Change

        #region Fill Question
        private void FillQuestionList(SqlInt32 mainModelID)
        {
            PRD_MainModelWiseQuestionBAL balPRD_MainModelWiseQuestion = new PRD_MainModelWiseQuestionBAL();
            DataTable dt = balPRD_MainModelWiseQuestion.Select(mainModelID);
            if (dt != null && dt.Rows.Count > 0)
            {
                rpQuestionList.DataSource = dt;
                rpQuestionList.DataBind();
            }
        }
        #endregion Fill Question

        //#region Init Item-DataTable
        //private void initItemDataTable()
        //{
        //    dtItem = new DataTable("dtItem");
        //    dtItem.Columns.Add("Id", typeof(int));
        //    dtItem.Columns.Add("QuestiontName", typeof(string));
        //    dtItem.Columns.Add("ItemId", typeof(int));
        //    dtItem.Columns.Add("ItemName", typeof(string));
        //    //dtItem.Columns.Add("RawMaterialPrice", typeof(Decimal));
        //    //dtItem.Columns.Add("RawMaterialQuantity", typeof(Decimal));
        //    //dtItem.Columns.Add("TotalAmount", typeof(Decimal));
        //    //dtItem.Columns.Add("Description", typeof(string));
        //}
        //#endregion Init Item-DataTable

        //#region Add Row In DataTable
        //private void addRowToDataTable()
        //{
        //    DataRow dtRow = dtItem.NewRow();
        //    dtRow["Id"] = dtId;
        //    dtRow["QuestiontName"] = "";
        //    dtRow["ItemId"] = 1;
        //    dtRow["ItemName"] = "";
        //    //dtRow["RawMaterialPrice"] = 0.0;
        //    //dtRow["RawMaterialQuantity"] = 0.0;
        //    //dtRow["Description"] = "";
        //    //dtRow["TotalAmount"] = 0.0;
        //    dtItem.Rows.Add(dtRow);
        //    dtId += 1;
        //}
        //#endregion Add Row In DataTable

        //#region Bind Raw Material Repeator
        //private void bindDataTable()
        //{
        //    if (dtItem != null && dtItem.Rows.Count > 0)
        //    {
        //        rpQuestionList.DataSource = dtItem;
        //        rpQuestionList.DataBind();
        //    }
        //}
        //#endregion Bind Raw Material Repeator

        //#region Question Repeator
        //private void QuestionRepeator()
        //{
        //    addRowToDataTable();
        //    bindDataTable();
        //}
        //#endregion Question Repeator


        //#region Fill RawMaterial DropDown In Repeater
        //protected void QuestionList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        RepeaterItem item = e.Item;
        //        HiddenField hfId = (HiddenField)item.FindControl("hfId");
        //        DropDownList ddlItem = (DropDownList)item.FindControl("ddlItem");
        //        CommonFillMethods.FillDropDownListItem(ddlItem);

        //        DataRow dr = dtItem.Select("Id = " + Convert.ToInt32(hfId.Value))[0];
        //        ddlItem.SelectedValue = dr["ItemId"].ToString();
        //    }
        //}
        //#endregion Fill RawMaterial DropDown In Repeater

        //#region SaveButton
        //protected void Save_Click(object sender, EventArgs e)
        //{
        //    SEC_UserWiseMenuBAL balSEC_UserWiseMenu = new SEC_UserWiseMenuBAL();

        //    SqlInt32 UserID = SqlInt32.Null;

        //    UserID = Convert.ToInt32(ddlUserID.SelectedValue);

        //    balSEC_UserWiseMenu.Delete(UserID);

        //    foreach (RepeaterItem item in MenuList.Items)
        //    {
        //        HiddenField hfMenuID = (HiddenField)item.FindControl("hfMenuID");
        //        CheckBox cbMenuID = (CheckBox)item.FindControl("cbMenuID");

        //        if (cbMenuID.Checked)
        //        {
        //            balSEC_UserWiseMenu.Insert(UserID, Convert.ToInt32(hfMenuID.Value));
        //        }
        //    }
        //    ClearGridAndUser();
        //}
        //#endregion SaveButton

        #region Clear Button

        private void ClearGridAndUser()
        {
            ddlMainModel.SelectedIndex = 0;
            rpQuestionList.DataSource = null;
            rpQuestionList.DataBind();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ClearGridAndUser();
        }
        #endregion Clear Button
    }
}