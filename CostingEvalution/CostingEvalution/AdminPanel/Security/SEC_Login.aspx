<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SEC_Login.aspx.cs" Inherits="CostingEvalution.AdminPanel.Security.SEC_Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Costing Evalution</title>

    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
    <link rel="stylesheet" href='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/fontawesome-free/css/all.min.css") %>'>
    <link rel="stylesheet" href='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/icheck-bootstrap/icheck-bootstrap.min.css") %>'>
    <link rel="stylesheet" href='<%=ResolveClientUrl("~/Content/AdminPanel/assets/dist/css/adminlte.min.css") %>'>
</head>
<body class="hold-transition login-page">
<%--<body class="hold-transition login-page" style="background-image:url('../../Content/AdminPanel/assets/t1.jpg'); background-repeat:no-repeat;">--%>

    <form runat="server">
        <div class="login-box">
            <!-- /.login-logo -->
            <div class="card card-outline card-primary">
                <div class="card-header text-center">
                    <p class="h2"><b>Costing </b>Evaluation</p>
                </div>
                <div class="card-body">
                    <p class="login-box-msg">SIGN IN TO START YOUR SESSION</p>
                    <asp:Label runat="server" ID="lblUserName" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
                    <div class="input-group mb-3">
                        <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control" placeholder="User Name" AutoCompleteType="Disabled" />
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-user"></span>
                            </div>
                        </div>
                    </div>

                    <asp:Label runat="server" ID="lblUserPassword" Visible="false" ForeColor="Red" Font-Bold="true" Text="  This Field Is Required"></asp:Label>
                    <div class="input-group mb-3">
                        <asp:TextBox runat="server" ID="txtUserPassword" TextMode="Password" CssClass="form-control" placeholder="Password" CausesValidation="false" AutoPostBack="false" />
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12 form-group text-center">
                            <asp:Label runat="server" ID="lblPasswordIncorrect" Visible="false" ForeColor="Red" Font-Bold="true" Text="Invalid Sign-In Credentials"></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12">
                            <asp:Button runat="server" ID="btnSignIn" CssClass="btn btn-primary btn-block" Text="Sign In" OnClick="btnSignIn_Click" CausesValidation="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/jquery/jquery.min.js") %>'></script>
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap/js/bootstrap.bundle.min.js") %>'></script>
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/dist/js/adminlte.min.js") %>'></script>
</body>
</html>
