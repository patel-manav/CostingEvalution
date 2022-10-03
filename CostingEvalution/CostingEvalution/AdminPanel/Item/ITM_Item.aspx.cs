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
using System.Configuration;
using System.Data.SqlClient;
using CostingEvalution.AdminPanel.Master;
using System.Net;

namespace CostingEvalution.AdminPanel.Item
{
    public partial class ITM_Item : System.Web.UI.Page
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
                initItemDataTable();
                FillDropDownList();
                RawMaterialRepeator();
            }
        }

        #region Init Item-DataTable
        private void initItemDataTable()
        {
            dtItem = new DataTable("dtItem");
            dtItem.Columns.Add("Id", typeof(int));
            dtItem.Columns.Add("RawMaterialNameId", typeof(int));
            dtItem.Columns.Add("RawMaterialName", typeof(string));
            dtItem.Columns.Add("UnitName", typeof(string));
            dtItem.Columns.Add("RawMaterialPrice", typeof(Decimal));
            dtItem.Columns.Add("RawMaterialQuantity", typeof(Decimal));
            dtItem.Columns.Add("TotalAmount", typeof(Decimal));
            dtItem.Columns.Add("Description", typeof(string));
        }
        #endregion Init Item-DataTable

        #region FillDropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListItemType(ddlItemType);
            CommonFillMethods.FillDropDownListMainModel(lbMainModel);
        }
        #endregion FillDropDownList

        #region RawMaterial Repeator
        private void RawMaterialRepeator()
        {
            #region Bind Data
            addRowToDataTable();
            bindDataTable();
            #endregion Bind Data
        }
        #endregion RawMaterial Repeator

        #region AddRowIn-DataTable
        private void addRowToDataTable()
        {
            DataRow dtRow = dtItem.NewRow();
            dtRow["Id"] = dtId;
            dtRow["RawMaterialNameId"] = 1;
            dtRow["RawMaterialName"] = "";
            dtRow["UnitName"] = "";
            dtRow["RawMaterialPrice"] = 0.0;
            dtRow["RawMaterialQuantity"] = 0.0;
            dtRow["Description"] = "";
            dtRow["TotalAmount"] = 0.0;
            dtItem.Rows.Add(dtRow);
            dtId += 1;
        }
        #endregion AddRowIn-DataTable

        #region Bind RawMaterial Repeator
        private void bindDataTable()
        {
            if (dtItem != null && dtItem.Rows.Count > 0)
            {
                rpRawMaterial.DataSource = dtItem;
                rpRawMaterial.DataBind();
            }
        }
        #endregion Bind RawMaterial Repeator

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

        #region Fill RawMaterial DropDown In Repeater
        protected void rpRawMaterial_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                RepeaterItem item = e.Item;
                HiddenField hfId = (HiddenField)item.FindControl("hfId");
                DropDownList ddlRawMaterial = (DropDownList)item.FindControl("ddlRawMaterial");
                CommonFillMethods.FillDropDownListRawMaterial(ddlRawMaterial);

                DataRow dr = dtItem.Select("Id = " + Convert.ToInt32(hfId.Value))[0];
                ddlRawMaterial.SelectedValue = dr["RawMaterialNameId"].ToString();
            }
        }
        #endregion Fill RawMaterial DropDown In Repeater

        #region Change Unit_Price Based On RawMaterial Selection
        protected void ddlRawMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = sender as DropDownList;
            RepeaterItem item = ddl.NamingContainer as RepeaterItem;

            DataTable dt = new MST_RawMaterialBAL().SelectForItem(Convert.ToInt32(ddl.SelectedValue));

            Label lblUnitName = (Label)item.FindControl("lblUnitName");
            Label lblRawMaterialPrice = (Label)item.FindControl("lblRawMaterialPrice");
            Label lblTotalAmount = (Label)item.FindControl("lblTotalAmount");
            TextBox txtRawMaterialQuantity = (TextBox)item.FindControl("txtRawMaterialQuantity");

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                if (dr["UnitName"] != null)
                {
                    lblUnitName.Text = dr["UnitName"].ToString();
                }

                if (dr["RawMaterialPrice"] != null)
                {
                    lblRawMaterialPrice.Text = dr["RawMaterialPrice"].ToString();
                }
                lblTotalAmount.Text = String.Empty;
                txtRawMaterialQuantity.Text = String.Empty;
            }
            else
            {
                lblRawMaterialPrice.Text = String.Empty;
                lblUnitName.Text = String.Empty;
                lblTotalAmount.Text = String.Empty;
                txtRawMaterialQuantity.Text = String.Empty;
            }
            CalculateGrandTotalAmount();
        }
        #endregion Change Unit_Price Based On RawMaterial Selection

        #region Calculation TotalAmount(Price*Quantity)
        protected void txtRawMaterialQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            RepeaterItem item = txtBox.NamingContainer as RepeaterItem;

            Label lblRawMaterialPrice = (Label)item.FindControl("lblRawMaterialPrice");
            Label lblTotalAmount = (Label)item.FindControl("lblTotalAmount");

            if (lblRawMaterialPrice.Text.Trim() != String.Empty && txtBox.Text.Trim() != String.Empty)
            {
                lblTotalAmount.Text = (Convert.ToDecimal(lblRawMaterialPrice.Text) * Convert.ToDecimal(txtBox.Text)).ToString();
            }
            CalculateGrandTotalAmount();
        }
        #endregion Calculation TotalAmount(Price*Quantity)

        #region Add Click
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            FillDataTableFromRepeater();
            addRowToDataTable();
            bindDataTable();
        }
        #endregion Add Click

        #region For Consitant Data Whenever Add New Row or Select RawMaterial
        private void FillDataTableFromRepeater()
        {
            foreach (RepeaterItem item in rpRawMaterial.Items)
            {
                HiddenField hfId = (HiddenField)item.FindControl("hfId");
                DropDownList ddlRawMaterial = (DropDownList)item.FindControl("ddlRawMaterial");
                Label lblUnitName = (Label)item.FindControl("lblUnitName");
                Label lblRawMaterialPrice = (Label)item.FindControl("lblRawMaterialPrice");
                TextBox txtRawMaterialQuantity = (TextBox)item.FindControl("txtRawMaterialQuantity");
                Label lblTotalAmount = (Label)item.FindControl("lblTotalAmount");
                TextBox txtDescription = (TextBox)item.FindControl("txtDescription");

                DataRow dr = dtItem.Select("Id = " + Convert.ToInt32(hfId.Value))[0];

                if (ddlRawMaterial.SelectedIndex > 0)
                {
                    if (ddlRawMaterial.SelectedIndex != 0)
                    {
                        dr["RawMaterialNameId"] = ddlRawMaterial.SelectedValue;
                        dr["RawMaterialName"] = ddlRawMaterial.SelectedItem;
                    }
                    if (lblUnitName.Text.Trim() != String.Empty)
                    {
                        dr["UnitName"] = lblUnitName.Text;
                    }
                    if (lblRawMaterialPrice.Text.Trim() != String.Empty)
                    {
                        dr["RawMaterialPrice"] = lblRawMaterialPrice.Text;
                    }
                    if (txtRawMaterialQuantity.Text.Trim() != String.Empty)
                    {
                        dr["RawMaterialQuantity"] = txtRawMaterialQuantity.Text;
                    }
                    if (txtDescription.Text.Trim() != String.Empty)
                    {
                        dr["Description"] = txtDescription.Text;
                    }
                    if (lblTotalAmount.Text.Trim() != String.Empty)
                    {
                        dr["TotalAmount"] = Convert.ToDecimal(lblRawMaterialPrice.Text) * Convert.ToDecimal(txtRawMaterialQuantity.Text);
                    }
                }
            }
        }
        #endregion For Consitant Data Whenever Add New Row or Select RawMaterial

        #region Delete Perticular Row From Repetor
        protected void rpRawMaterial_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            FillDataTableFromRepeater();
            if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
            {
                DataRow dr = dtItem.Select("Id = " + Convert.ToInt32(e.CommandArgument))[0];
                dtItem.Rows.Remove(dr);
            }
            bindDataTable();
            CalculateGrandTotalAmount();
        }
        #endregion Delete Perticular Row From Repetor

        #region Calculate Grand-Total Amount(Sum of All Total Amount)
        private void CalculateGrandTotalAmount()
        {
            FillDataTableFromRepeater();
            var total = dtItem.Compute("Sum(TotalAmount)", string.Empty);
            lblGrandTotalAmount.Text = total.ToString();
        }
        #endregion Calculate Grand-Total Amount(Sum of All Total Amount)
    }
}