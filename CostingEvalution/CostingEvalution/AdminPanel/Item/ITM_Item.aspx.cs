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
                FillDropDownList();
                initItemDataTable();
                RawMaterialRepeator();
                if (Request.QueryString["ItemID"] != null && Request.QueryString["ItemID"].ToString() != "")
                {
                    hfItemID.Value = Request.QueryString["ItemID"].ToString();
                    FIllUpdateData();
                }
            }
        }

        #region Fill Data For Update
        private void FIllUpdateData()
        {
            #region Variable
            ITM_ItemBAL balITM_Item = new ITM_ItemBAL();
            ITM_ItemENT entITM_Item = balITM_Item.SelectPK(Convert.ToInt32(hfItemID.Value.Trim()));

            ITM_ItemWiseMainModelBAL balITM_ItemWiseMainModel = new ITM_ItemWiseMainModelBAL();
            ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel = new ITM_ItemWiseMainModelENT();

            #endregion Variable

            #region Fill Item Name And Type
            if (!entITM_Item.ItemName.IsNull)
            {
                txtItemName.Text = entITM_Item.ItemName.Value;
            }
            if (!entITM_Item.ItemTypeID.IsNull)
            {
                ddlItemType.SelectedValue = entITM_Item.ItemTypeID.Value.ToString();
            }
            #endregion Fill Item Name And Type

            #region Fill Main Model
            DataTable dtMainModelForItem = balITM_ItemWiseMainModel.Select(Convert.ToInt32(hfItemID.Value.Trim()));

            if (dtMainModelForItem.Rows.Count > 0)
            {
                foreach (DataRow drMainModel in dtMainModelForItem.Rows)
                {
                    string mainModelId = drMainModel["MainModelID"].ToString();

                    if (drMainModel["MainModelID"].ToString() != String.Empty)
                    {
                        lbMainModel.Items.FindByValue(mainModelId).Selected = true;
                    }
                }
            }
            #endregion Fill Main Model


            ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialENT();
            ITM_ItemWiseRawMaterialBAL balITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialBAL();

        }
        #endregion Fill Data For Update


        #region FillDropDownList
        private void FillDropDownList()
        {
            CommonFillMethods.FillDropDownListItemType(ddlItemType);
            CommonFillMethods.FillDropDownListMainModel(lbMainModel);
        }
        #endregion FillDropDownList

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

        #region RawMaterial Repeator
        private void RawMaterialRepeator()
        {
            addRowToDataTable();
            bindDataTable();
        }
        #endregion RawMaterial Repeator

        #region Add Row In DataTable
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
        #endregion Add Row In DataTable

        #region Bind Raw Material Repeator
        private void bindDataTable()
        {
            if (dtItem != null && dtItem.Rows.Count > 0)
            {
                rpRawMaterial.DataSource = dtItem;
                rpRawMaterial.DataBind();
            }
        }
        #endregion Bind Raw Material Repeator

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

        #region Change Unit And Price Based On RawMaterial Selection
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
        #endregion Change Unit And Price Based On RawMaterial Selection

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

        #region Save Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            #region Variable
            ITM_ItemENT entITM_Item = new ITM_ItemENT();
            ITM_ItemBAL balITM_Item = new ITM_ItemBAL();

            ITM_ItemWiseMainModelENT entITM_ItemWiseMainModel = new ITM_ItemWiseMainModelENT();
            ITM_ItemWiseMainModelBAL balITM_ItemWiseMainModel = new ITM_ItemWiseMainModelBAL();

            ITM_ItemWiseRawMaterialENT entITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialENT();
            ITM_ItemWiseRawMaterialBAL balITM_ItemWiseRawMaterial = new ITM_ItemWiseRawMaterialBAL();

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
            else if (lbMainModel.GetSelectedIndices().Count() <= 0)
            {
                ClearValidation();
                lblMainModel.Visible = true;
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

            entITM_Item.CreateDateTime = entITM_ItemWiseMainModel.CreateDateTime = entITM_ItemWiseRawMaterial.CreateDateTime = DateTime.Now;
            entITM_Item.CreateBy = entITM_ItemWiseMainModel.CreateBy = entITM_ItemWiseRawMaterial.CreateBy = Convert.ToInt32(Session["UserID"]);
            entITM_Item.CreateIP = entITM_ItemWiseMainModel.CreateIP = entITM_ItemWiseRawMaterial.CreateIP = Session["IP"].ToString();
            entITM_Item.UpdateDateTime = entITM_ItemWiseMainModel.UpdateDateTime = entITM_ItemWiseRawMaterial.UpdateDateTime = DateTime.Now;
            entITM_Item.UpdateBy = entITM_ItemWiseMainModel.UpdateBy = entITM_ItemWiseRawMaterial.UpdateBy = Convert.ToInt32(Session["UserID"]);
            entITM_Item.UpdateIP = entITM_ItemWiseMainModel.UpdateIP = entITM_ItemWiseRawMaterial.UpdateIP = Session["IP"].ToString();

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
                    #region Insert Multiple Main-Model
                    foreach (int selectedIndex in lbMainModel.GetSelectedIndices())
                    {
                        entITM_ItemWiseMainModel.ItemID = entITM_Item.ItemID;
                        entITM_ItemWiseMainModel.MainModelID = Convert.ToInt32(lbMainModel.Items[selectedIndex].Value);

                        balITM_ItemWiseMainModel.Insert(entITM_ItemWiseMainModel);
                    }
                    #endregion Insert Multiple Main-Model

                    #region Insert Multiple Raw Material
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
                        entITM_ItemWiseRawMaterial.ItemID = entITM_Item.ItemID;
                        if (ddlRawMaterial.SelectedIndex > 0)
                        {
                            if (ddlRawMaterial.SelectedIndex != 0)
                            {
                                entITM_ItemWiseRawMaterial.RawMaterialID = Convert.ToInt32(ddlRawMaterial.SelectedValue);
                            }
                            if (txtRawMaterialQuantity.Text.Trim() != String.Empty)
                            {
                                entITM_ItemWiseRawMaterial.RawMaterialQuantity = Convert.ToInt32(txtRawMaterialQuantity.Text);
                            }
                            if (txtDescription.Text.Trim() != String.Empty)
                            {
                                entITM_ItemWiseRawMaterial.Description = txtDescription.Text;
                            }
                        }
                        balITM_ItemWiseRawMaterial.Insert(entITM_ItemWiseRawMaterial);
                    }

                    #endregion Insert Multiple Raw Material

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
            hfItemID.Value = null;
            txtItemName.Text = "";
            ddlItemType.SelectedIndex = 0;
            lbMainModel.ClearSelection();
        }
        #endregion Clear Control

        #region Clear Validation
        private void ClearValidation()
        {
            lblItemName.Visible = false;
            lblItemType.Visible = false;
            lblMainModel.Visible = false;
        }
        #endregion Clear Validation

        #endregion Clear Control
    }
}