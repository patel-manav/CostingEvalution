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

        <%--  <div class="col-md-1 mt-4">
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Add" />
        </div>--%>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>



    <div class="container row mt-5">        
            <asp:Repeater ID="rpRawMaterial" runat="server">
                <ItemTemplate>
                    <table class="table table-bordered">
                        <tr>
                            <td>RawMaterial Name:</td>
                            <td><asp:DropDownList runat="server" ID="ddlRawMaterial" DataSource="<%#Eval("RawMaterialiD")%>" DataSourceID></asp:DropDownList></td>
                            <td>Unit</td>
                            <td>Price</td>
                        </tr>
                        <tr>
                            <td><%#Eval("RawMaterialName")%></td>
                            <td><%#Eval("UnitName")%></td>
                            <td><%#Eval("RawMaterialPrice")%></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
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
