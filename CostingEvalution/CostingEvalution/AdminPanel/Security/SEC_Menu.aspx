<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEC_Menu.aspx.cs" Inherits="CostingEvalution.AdminPanel.Security.SEC_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Menu Master</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfMenuID" />
        <div class="col-md-3 form-group">
            Menu Name*
            <asp:Label runat="server" ID="lblMenuName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtMenuName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <%--<div class="col-md-3 form-group">
                    Menu Image
                    <asp:TextBox runat="server" ID="txtMenuImage" CssClass="form-control" AutoCompleteType="Disabled" />
                </div>--%>

        <div class="col-md-3 form-group">
            Menu URL*
            <asp:Label runat="server" ID="lblMenuURL" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtMenuURL" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            Menu Sequence*
             <asp:Label runat="server" ID="lblMenuSequence" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtMenuSequence" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-1 mt-4  form-group">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />
        </div>
        <div class="col-md-1  mt-4 form-group">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvMenu" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvMenu_PageIndexChanging" OnRowCommand="gvMenu_RowCommand">
                <Columns>
                    <asp:BoundField DataField="MenuName" HeaderText="Menu Name" />
                    <%--<asp:BoundField DataField="MenuImagePath" HeaderText="Image Path" />--%>
                    <asp:BoundField DataField="MenuURL" HeaderText="Menu URL" />
                    <asp:BoundField DataField="MenuSequence" HeaderText="Menu Sequence" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("MenuID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("MenuID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
