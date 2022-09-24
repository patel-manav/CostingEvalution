<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEC_User.aspx.cs" Inherits="CostingEvalution.AdminPanel.Security.SEC_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>User Panel</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfUserID" />
        <div class="col-md-3 form-group">
            User Name*
            <asp:Label runat="server" ID="lblUserName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>
        <div class="col-md-3 form-group">
            Display Name*
            <asp:Label runat="server" ID="lblDisplayName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtDisplayName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>
        <div class="col-md-3 form-group">
            Password*
            <asp:Label runat="server" ID="lblPassword" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:Label runat="server" ID="lblPasswordCharacter" Visible="false" ForeColor="Red" Font-Bold="true" Text="  Minimum 6 Character Required"></asp:Label>
            <asp:Label runat="server" ID="lblPasswordCheck" Visible="false" ForeColor="Red" Font-Bold="true" Text="  Password are not same"></asp:Label>
            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" oncopy="return false" onpaste="return false" oncut="return false" AutoCompleteType="Disabled" AutoPostBack="false" Type="Password"/>
        </div>
        <div class="col-md-3 form-group">
            Confirm Password*
            <asp:Label runat="server" ID="lblConfirmPassword" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:Label runat="server" ID="lblConfirmPasswordCheck" Visible="false" ForeColor="Red" Font-Bold="true" Text="  Password are not same"></asp:Label>
            <asp:TextBox runat="server" ID="txtConfirmPassword" CssClass="form-control" oncopy="return false" onpaste="return false" oncut="return false" AutoCompleteType="Disabled" AutoPostBack="false" Type="Password"/>
        </div>

        <div class="col-md-2 offset-md-8 form-group">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click"/>
        </div>
        <div class="col-md-2">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click"/>
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvUser" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnRowCommand="gvUser_RowCommand" OnPageIndexChanging="gvUser_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="User Name" />
                    <asp:BoundField DataField="UserDisplayName" HeaderText="Display Name" />
                    <%--<asp:BoundField DataField="Description" HeaderText="Description" />--%>
                   

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("UserID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("UserID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>


</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
