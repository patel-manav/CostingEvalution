<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEC_MenuPermission.aspx.cs" Inherits="CostingEvalution.AdminPanel.Security.SEC_MenuPermission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Menu Permission</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <div class="col-md-4">
            User*
            <asp:DropDownList runat="server" ID="ddlUserID" OnSelectedIndexChanged="ddlUserID_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-1 mt-4">
            <asp:Button ID="Save" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="Save_Click" />
        </div>
        <div class="col-md-1 mt-4">
            <asp:Button ID="Clear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="Clear_Click" />
        </div>

    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">

            <table class="table table-hover" border="1">
                <tr>
                    <th class="col-md-1 text-center">Sr No.
                    </th>
                    <th class="col-md-3 text-center">Menu Name
                    </th>
                    <th></th>
                </tr>
                <tbody>
                    <asp:Repeater ID="MenuList" runat="server">
                        <itemtemplate>
                            <tr>
                                <td class="text-center">
                                    <%# Container.ItemIndex + 1 %>
                                </td>
                                <td class="text-center">
                                    <%#Eval("MenuName") %>
                                </td>
                                <td>
                                    <asp:CheckBox ID="cbMenuID" runat="server" Checked='<%#Eval("UserWiseMenuID").ToString() != String.Empty? true:false %>' />
                                    <asp:HiddenField ID="hfMenuID" runat="server" Value='<%#Eval("MenuID")%>' />
                                </td>
                            </tr>
                        </itemtemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
  
</asp:Content>
