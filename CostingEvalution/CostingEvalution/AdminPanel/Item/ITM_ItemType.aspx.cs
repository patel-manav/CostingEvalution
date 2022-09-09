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

namespace CostingEvalution.AdminPanel.Item
{
    public partial class ITM_ItemType : System.Web.UI.Page
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
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            #endregion Variable

            #region Bind Data
            DataTable dt = balITM_ItemType.Select();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvItemType.DataSource = dt;
                gvItemType.DataBind();
            }
            #endregion Bind Data

        }

        #endregion Fill GridView

        #region Save Click
        [Obsolete]
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            ITM_ItemTypeENT entITM_ItemType = new ITM_ItemTypeENT();
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            #endregion Variable

            #region Validation
            if (txtItemTypeName.Text.Trim() == "")
            {
                ClearValidation();
                lblItemTypeName.Visible = true;
                return;
            }
            #endregion Validation

            #region Gather Data
            if (hfItemTypeID.Value != "")
            {
                entITM_ItemType.ItemTypeID = Convert.ToInt32(hfItemTypeID.Value.Trim());
            }

            if (txtItemTypeName.Text.Trim() != "")
            {
                entITM_ItemType.ItemTypeName = txtItemTypeName.Text.Trim();
            }

            if (txtItemTypeDescription.Text.Trim() != "")
            {
                entITM_ItemType.Description = txtItemTypeDescription.Text.Trim();
            }



            entITM_ItemType.CreateDateTime = DateTime.Now;
            entITM_ItemType.CreateBy = Convert.ToInt32(Session["UserID"]);
            entITM_ItemType.CreateIP = Session["IP"].ToString();
            entITM_ItemType.UpdateDateTime = DateTime.Now;
            entITM_ItemType.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entITM_ItemType.UpdateIP = Session["IP"].ToString();

            #endregion Gather Data

            #region Insert/Update
            if (hfItemTypeID.Value != "")
            {
                if (balITM_ItemType.Update(entITM_ItemType))
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
                if (balITM_ItemType.Insert(entITM_ItemType))
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
            hfItemTypeID.Value = null;
            txtItemTypeName.Text = "";
            txtItemTypeDescription.Text = "";
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblItemTypeName.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control

        #region Delete/Update
        protected void gvItemType_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            #region Variable
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            #endregion Variable

            #region Clear Validation
            ClearValidation();
            #endregion Clear Validation

            #region Delete Record
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                if (balITM_ItemType.Delete(Convert.ToInt32(e.CommandArgument)))
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
            ITM_ItemTypeBAL balITM_ItemType = new ITM_ItemTypeBAL();
            ITM_ItemTypeENT entITM_ItemType = balITM_ItemType.SelectPK(EmployeeDesignationID);
            #endregion Variable

            #region Fill Data
            if (!entITM_ItemType.ItemTypeID.IsNull)
            {
                hfItemTypeID.Value = entITM_ItemType.ItemTypeID.Value.ToString();
            }
            if (!entITM_ItemType.ItemTypeName.IsNull)
            {
                txtItemTypeName.Text = entITM_ItemType.ItemTypeName.Value;
            }
            if (!entITM_ItemType.Description.IsNull)
            {
                txtItemTypeDescription.Text = entITM_ItemType.Description.Value.ToString();
            }
            #endregion Fill Data
        }
        #endregion FillDataByPK

        #region PageIndex Change
        protected void gvItemType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvItemType.PageIndex = e.NewPageIndex;
            FillGridView();
            gvItemType.DataBind();
        }
        #endregion PageIndex Change
    }
}