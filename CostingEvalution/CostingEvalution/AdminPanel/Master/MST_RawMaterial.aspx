<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="MST_RawMaterial.aspx.cs" Inherits="CostingEvalution.AdminPanel.Master.MST_RawMaterial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Raw Material</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfRawMaterialID" />

        <div class="col-md-3 form-group">
            Name*
            <asp:Label runat="server" ID="lblRawMaterialName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtRawMaterialName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            Unit*
            <asp:Label runat="server" ID="lblUnit" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlUnit" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
        </div>

        <div class="col-md-3 form-group">
            Price*
            <asp:Label runat="server" ID="lblRawMaterialPrice" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtRawMaterialPrice" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            Description
            <asp:TextBox runat="server" ID="txtRawMaterialDescription" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 offset-md-6 form-group">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />
        </div>

        <div class="col-md-3">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvRawMaterial" runat="server" ClientIDMode="Static" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvRawMaterial_PageIndexChanging" OnRowCommand="gvRawMaterial_RowCommand">
                <Columns>
                    <asp:BoundField DataField="RawMaterialName" HeaderText="Raw-Material Name" />
                    <asp:BoundField DataField="UnitName" HeaderText="Unit Name" />
                    <asp:BoundField DataField="RawMaterialPrice" HeaderText="Price" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="UpdateBy" HeaderText="EntryBy" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("EmployeeDesignationID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("RawMaterialID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
