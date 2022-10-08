<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="EMP_EmployeeType.aspx.cs" Inherits="CostingEvalution.AdminPanel.Employee.EMP_EmployeeType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Employee Type</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfEmployeeTypeID" />

        <div class="col-md-3 form-group">
            Employee Type*
            <asp:Label runat="server" ID="lblEmployeeTypeName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmployeeTypeName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            For Hour/Price
            <asp:Label runat="server" ID="lblEmployeeTypeForNosHour" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:DropDownList runat="server" ID="ddlEmployeeTypeForNosHour" AutoPostBack="true" style="width:100%" CssClass="form-control"></asp:DropDownList>
        </div>

        <div class="col-md-3">
            Description
            <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" OnClick="btnSave_Click" />

        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </div>


       <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvEmployeeType" runat="server" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvEmployeeType_PageIndexChanging" OnRowCommand="gvEmployeeType_RowCommand">
                <Columns>
                    <asp:BoundField DataField="EmployeeTypeName" HeaderText="Employee Type" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />

                  <%--  <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>--%>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("MenuID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <%--<asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("EmployeeTypeID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>--%>
                        <%--</ItemTemplate>

                    </asp:TemplateField>--%>
                </Columns>
            </asp:GridView>
        </div>
    </div>




</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
