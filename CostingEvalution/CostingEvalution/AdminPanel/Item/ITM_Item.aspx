﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="ITM_Item.aspx.cs" Inherits="CostingEvalution.AdminPanel.Item.ITM_Item" %>

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
            Main Model*
            <asp:Label runat="server" ID="lblMainModel" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlMainModel" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Add" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" />
        </div>
    </div>




    <%--<div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvQuestion" runat="server" ClientIDMode="Static" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvQuestion_PageIndexChanging" OnRowCommand="gvQuestion_RowCommand">
                <Columns>
                    <asp:BoundField DataField="QuestionName" HeaderText="Raw-Material Name" />
                    <asp:BoundField DataField="ItemTypeName" HeaderText="ItemType" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>--%>
    <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("EmployeeDesignationID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
    <%-- <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("QuestionID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>--%>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>