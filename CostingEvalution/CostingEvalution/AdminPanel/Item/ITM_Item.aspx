<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="ITM_Item.aspx.cs" Inherits="CostingEvalution.AdminPanel.Item.ITM_Item" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Item Master</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfItemID" />

        <div class="col-md-3 form-group">
            Name*
            <asp:Label runat="server" ID="lblItemName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtItemName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>


        <div class="col-md-3 form-group">
            ItemType*
            <asp:Label runat="server" ID="lblItemType" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlItemType" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
        </div>

        <div class="col-md-3 form-group">
            MainModel*
            <asp:Label runat="server" ID="lblMainModel" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:ListBox ID="lbMainModel"
                runat="server"
                CssClass="select2bs4"
                SelectionMode="Multiple"
                Style="width: 100%;"
                data-placeholder="Select a MainModel"></asp:ListBox>
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Add" OnClick="btnAdd_Click" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>

    <div class="container row mt-5">
        <table class="table table-bordered table-responsive">
            <tr>
                <th>RawMaterial Name</th>
                <th>Unit</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Amount</th>
                <th>Remark</th>
                <th>Action</th>
            </tr>
            <asp:Repeater ID="rpRawMaterial" runat="server" OnItemDataBound="rpRawMaterial_ItemDataBound" OnItemCommand="rpRawMaterial_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <asp:HiddenField ID="hfId" runat="server" Value='<%#Eval("Id")%>' />
                        <td>
                            <asp:DropDownList runat="server" ID="ddlRawMaterial" Style="width: 100%" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlRawMaterial_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="lblUnitName" Text='<%#Eval("UnitName")%>'></asp:Label></td>
                        <td>
                            <asp:Label runat="server" ID="lblRawMaterialPrice" Text='<%#Eval("RawMaterialPrice")%>'></asp:Label></td>
                        <td>
                            <asp:TextBox runat="server" ID="txtRawMaterialQuantity" Text='<%#Eval("RawMaterialQuantity")%>' CssClass="form-control" OnTextChanged="txtRawMaterialQuantity_TextChanged" AutoPostBack="true"></asp:TextBox></td>
                        <td>
                            <asp:Label runat="server" ID="lblTotalAmount" Text='<%#Eval("TotalAmount")%>'></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" Text='<%#Eval("Description")%>'></asp:TextBox></td>
                        <td>
                            <asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("Id") %>' Visible='<%# Container.ItemIndex == 0 ? false : true %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Label runat="server" ID="lblGrandTotalAmount"></asp:Label>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
