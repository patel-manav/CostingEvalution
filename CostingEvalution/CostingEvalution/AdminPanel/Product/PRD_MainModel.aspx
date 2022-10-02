<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="PRD_MainModel.aspx.cs" Inherits="CostingEvalution.AdminPanel.Product.PRD_MainModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeading" runat="server">
    <b>Main Model</b>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainBody" runat="server">
    <div class="row">
        <asp:HiddenField runat="server" ID="hfMainModelID" />

        <div class="col-md-3 form-group">
            Name*
            <asp:Label runat="server" ID="lblMainModelName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:TextBox runat="server" ID="txtMainModelName" CssClass="form-control" AutoCompleteType="Disabled" />
        </div>

        <div class="col-md-3 form-group">
            Question*
            <asp:Label runat="server" ID="lblQuestion" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
            <asp:ListBox ID="lbQuestion"
                runat="server"
                CssClass="select2bs4"
                SelectionMode="Multiple"
                Style="width: 100%;"
                data-placeholder="Select a Question"></asp:ListBox>
        </div>


        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" />
        </div>

        <div class="col-md-1 mt-4">
            <asp:Button ID="btnClear" runat="server" CssClass="btn btn-secondary" Style="width: 100%;" Text="Clear" />
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-md-12 table-responsive">
            <asp:GridView ID="gvMainModel" runat="server" ClientIDMode="Static" CssClass="table table-hover" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvMainModel_PageIndexChanging" OnRowCommand="gvMainModel_RowCommand">
                <Columns>
                    <asp:BoundField DataField="MainModelName" HeaderText="Main Model" />
                    <asp:BoundField DataField="QuestionName" HeaderText="Question" />


                    <asp:TemplateField ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <%--<asp:LinkButton ID="btnDelete" CommandName="DeleteRecord" CommandArgument='<%# Eval("EmployeeDesignationID") %>' CssClass="fa fa-trash-alt mr-2 text-danger" runat="server"></asp:LinkButton>--%>
                            <asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("MainModelID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
</asp:Content>
