<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="ITM_ItemView.aspx.cs" Inherits="CostingEvalution.AdminPanel.Item.ITM_ItemView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Item Master</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <div class="col-md-1 offset-md-11">
            <asp:Button runat="server" ID="btnInsertItem" Text="Add Item" CssClass="btn btn-primary" Style="width: 100%" OnClick="btnInsertItem_Click" />
        </div>
    </div>

    <div class="row mt-3">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvItem" runat="server" ClientIDMode="Static" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvItem_PageIndexChanging" OnRowCommand="gvItem_RowCommand">
                <Columns>
                    <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
                    <asp:BoundField DataField="RawMaterialPrice" HeaderText="Raw Material Price" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("EmployeeDesignationID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("ItemID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
