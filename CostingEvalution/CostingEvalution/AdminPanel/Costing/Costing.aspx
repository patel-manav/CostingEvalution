<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="Costing.aspx.cs" Inherits="CostingEvalution.AdminPanel.Costing.Costing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Costing Master</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <div class="col-md-4">
            Select Main Model*
            <asp:DropDownList runat="server" ID="ddlMainModel" OnSelectedIndexChanged="ddlMainModel_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        </div>

        <%--<div class="col-md-1 mt-4">
            <asp:Button ID="Save" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save"/>
        </div>--%>

        <div class="col-md-1 mt-4">
            <asp:Button ID="Clear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="Clear_Click" />
        </div>

    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <table class="table table-hover" border="1">
                <tr>
                    <th class="col-md-1 text-center">
                        Sr No.
                    </th>
                    <th class="col-md-3 text-center">
                        Question List
                    </th>
                    <th>

                    </th>
                </tr>
                <tbody>
                    <%--<asp:Repeater ID="rpQuestionList" runat="server" OnItemDataBound="QuestionList_ItemDataBound">--%>
                    <asp:Repeater ID="rpQuestionList" runat="server">

                        <ItemTemplate>
                            <tr>
                                <%--<asp:HiddenField ID="hfId" runat="server" Value='<%#Eval("Id")%>' />--%>
                                <td class="text-center">
                                    <%# Container.ItemIndex + 1 %>
                                </td>
                                <td class="text-center">
                                    <%#Eval("QuestionName") %>
                                </td>
                                <td>
                                    <asp:DropDownList runat="server" ID="ddlItem" Style="width: 100%" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
