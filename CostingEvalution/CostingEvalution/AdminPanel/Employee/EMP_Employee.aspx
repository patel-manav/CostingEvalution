<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="EMP_Employee.aspx.cs" Inherits="CostingEvalution.AdminPanel.Employee.EMP_Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Employee Master</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfEmployeeID" />

        <div class="col-md-3 form-group">
            Employee Name*
            <asp:Label runat="server" ID="lblEmployeeName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmployeeName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            Department*
            <asp:Label runat="server" ID="lblEmployeeDepartment" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:ListBox ID="lbDepartment"
                runat="server"
                CssClass="select2bs4"
                SelectionMode="Multiple"
                Style="width: 100%;"
                data-placeholder="Select a Department"></asp:ListBox>
        </div>

        <div class="col-md-3  form-group">
            Price Per Hour
            <asp:Label runat="server" ID="lblPricePerHour" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtPricePerHour" CssClass="form-control" AutoCompleteType="Disabled"/>
        </div>

        <div class="col-md-3 form-group">
            Description
            <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-1 offset-md-10 form-group">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click"/>

        </div>

        <div class="col-md-1">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click"/>
        </div>
    </div>


       <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvEmployee" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvEmployee_PageIndexChanging" OnRowCommand="gvEmployee_RowCommand">
                <Columns>
                    <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" />
                    <asp:BoundField DataField="PricePerHour" HeaderText="Price Per Hour" />
                    <asp:BoundField DataField="Department" HeaderText="Department" />

                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("MenuID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("EmployeeID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
