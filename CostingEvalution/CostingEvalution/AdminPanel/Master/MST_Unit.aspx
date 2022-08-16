<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="MST_Unit.aspx.cs" Inherits="CostingEvalution.AdminPanel.Master.MST_Unit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Unit</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfUnitID" />

        <div class="col-md-3 form-group">
            Name*
            <asp:Label runat="server" ID="lblUnitName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtUnitName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3">
            Description
            <asp:TextBox runat="server" ID="txtUnitDescription" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-2 mt-4">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />
        </div>

        <div class="col-md-2 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvUnit" runat="server" ClientIDMode="Static" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvUnit_PageIndexChanging" OnRowCommand="gvUnit_RowCommand">
                <Columns>
                    <asp:BoundField DataField="UnitName" HeaderText="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="UpdateBy" HeaderText="EntryBy" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("EmployeeDesignationID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("UnitID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
