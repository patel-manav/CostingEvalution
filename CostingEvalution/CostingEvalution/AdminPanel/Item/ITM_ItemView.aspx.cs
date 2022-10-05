using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Item
{
    public partial class ITM_ItemView : System.Web.UI.Page
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
            ITM_ItemBAL balITM_Item = new ITM_ItemBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balITM_Item.SelectWithPrice();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvItem.DataSource = dt;
                gvItem.DataBind();
            }
            #endregion Bind Data
        }

        #endregion Fill GridView

        #region Insert Item Button
        protected void btnInsertItem_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveClientUrl("../Item/ITM_Item.aspx"));
        }
        #endregion Insert Item Button


        #region Delete/Update
        protected void gvItem_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            #endregion Variable

            #region Delete Record
            if (e.CommandName == "EditRecord" && e.CommandArgument != null)
            {
                int ItemID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect(Page.ResolveClientUrl("../Item/ITM_Item.aspx?ItemID="+ItemID));

            }
            #endregion Delete Record
        }
        #endregion Delete/Update


        #region PageIndex Change
        protected void gvItem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvItem.PageIndex = e.NewPageIndex;
            FillGridView();
            gvItem.DataBind();
        }
        #endregion PageIndex Change
    }
}