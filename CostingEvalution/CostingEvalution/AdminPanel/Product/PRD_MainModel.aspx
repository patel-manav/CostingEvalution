<%@ Page Title="" Language="C#" MasterPageFile="~/Content/MasterPage.Master" AutoEventWireup="true" CodeBehind="PRD_MainModel.aspx.cs" Inherits="CostingEvalution.AdminPanel.Product.PRD_MainModel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <!-- Google Font: Source Sans Pro -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
    <!-- Font Awesome -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/fontawesome-free/css/all.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- daterange picker -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/daterangepicker/daterangepicker.css")%>" rel="stylesheet" type="text/css" />
    <!-- iCheck for checkboxes and radio inputs -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/icheck-bootstrap/icheck-bootstrap.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- Bootstrap Color Picker -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap-colorpicker/css/bootstrap-colorpicker.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- Tempusdominus Bootstrap 4 -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- Select2 -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/select2/css/select2.min.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- Bootstrap4 Duallistbox -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap4-duallistbox/bootstrap-duallistbox.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- BS Stepper -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bs-stepper/css/bs-stepper.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- dropzonejs -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/dropzone/min/dropzone.min.css")%>" rel="stylesheet" type="text/css" />
    <!-- Theme style -->
    <link href="<%=ResolveClientUrl("~/Content/AdminPanel/assets/dist/css/adminlte.min.css")%>" rel="stylesheet" type="text/css" />
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
            <asp:ListBox ID="ddlQuestion" 
                runat="server" 
                CssClass="select2bs4" 
                SelectionMode="Multiple"
                Style="width: 100%;" 
                data-placeholder="Select a Question">
            </asp:ListBox>
            <%--<asp:DropDownList ID="ddlQuestion" 
                runat="server" 
                CssClass="select2bs4" 
                multiple="multiple" 
                data-placeholder="Select a Question" 
                Style="width: 100%;" 
                OnSelectedIndexChanged="ddlQuestion_SelectedIndexChanged" 
                AutoPostBack="true">
            </asp:DropDownList>--%>
        </div>


        <div class="col-md-1 mt-4">
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" CssClass="btn btn-primary" Style="width: 100%;" Text="Save" />
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
    <%--<asp:LinkButton ID="btnEdit" CommandName="EditRecord" CommandArgument='<%# Eval("QuestionID") %>' CssClass="fas fa-edit text-warning" runat="server"></asp:LinkButton>--%>
    <%-- </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>--%>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphScript" runat="server">
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/jquery/jquery.min.js") %>'></script>
    <!-- Bootstrap 4 -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap/js/bootstrap.bundle.min.js") %>'></script>
    <!-- Select2 -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/select2/js/select2.full.min.js") %>'></script>
    <!-- Bootstrap4 Duallistbox -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js") %>'></script>
    <!-- InputMask -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/moment/moment.min.js") %>'></script>
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/inputmask/jquery.inputmask.min.js") %>'></script>
    <!-- date-range-picker -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/daterangepicker/daterangepicker.js") %>'></script>
    <!-- bootstrap color picker -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js") %>'></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js") %>'></script>
    <!-- Bootstrap Switch -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bootstrap-switch/js/bootstrap-switch.min.js") %>'></script>
    <!-- BS-Stepper -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/bs-stepper/js/bs-stepper.min.js") %>'></script>
    <!-- dropzonejs -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/plugins/dropzone/min/dropzone.min.js") %>'></script>
    <!-- AdminLTE App -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/dist/js/adminlte.min.js") %>'></script>
    <!-- AdminLTE for demo purposes -->
    <script src='<%=ResolveClientUrl("~/Content/AdminPanel/assets/dist/js/demo.js") %>'></script>
    <script>
        $(function () {
            //Initialize Select2 Elements
            $('.select2').select2()

            //Initialize Select2 Elements
            $('.select2bs4').select2({
                theme: 'bootstrap4'
            })

            //Datemask dd/mm/yyyy
            $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
            //Datemask2 mm/dd/yyyy
            $('#datemask2').inputmask('mm/dd/yyyy', { 'placeholder': 'mm/dd/yyyy' })
            //Money Euro
            $('[data-mask]').inputmask()

            //Date picker
            $('#reservationdate').datetimepicker({
                format: 'L'
            });

            //Date and time picker
            $('#reservationdatetime').datetimepicker({ icons: { time: 'far fa-clock' } });

            //Date range picker
            $('#reservation').daterangepicker()
            //Date range picker with time picker
            $('#reservationtime').daterangepicker({
                timePicker: true,
                timePickerIncrement: 30,
                locale: {
                    format: 'MM/DD/YYYY hh:mm A'
                }
            })
            //Date range as a button
            $('#daterange-btn').daterangepicker(
                {
                    ranges: {
                        'Today': [moment(), moment()],
                        'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                        'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                        'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                        'This Month': [moment().startOf('month'), moment().endOf('month')],
                        'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                    },
                    startDate: moment().subtract(29, 'days'),
                    endDate: moment()
                },
                function (start, end) {
                    $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'))
                }
            )

            //Timepicker
            $('#timepicker').datetimepicker({
                format: 'LT'
            })

            //Bootstrap Duallistbox
            $('.duallistbox').bootstrapDualListbox()

            //Colorpicker
            $('.my-colorpicker1').colorpicker()
            //color picker with addon
            $('.my-colorpicker2').colorpicker()

            $('.my-colorpicker2').on('colorpickerChange', function (event) {
                $('.my-colorpicker2 .fa-square').css('color', event.color.toString());
            })

            $("input[data-bootstrap-switch]").each(function () {
                $(this).bootstrapSwitch('state', $(this).prop('checked'));
            })

        })
        // BS-Stepper Init
        document.addEventListener('DOMContentLoaded', function () {
            window.stepper = new Stepper(document.querySelector('.bs-stepper'))
        })

        // DropzoneJS Demo Code Start
        Dropzone.autoDiscover = false

        // Get the template HTML and remove it from the doumenthe template HTML and remove it from the doument
        var previewNode = document.querySelector("#template")
        previewNode.id = ""
        var previewTemplate = previewNode.parentNode.innerHTML
        previewNode.parentNode.removeChild(previewNode)

        var myDropzone = new Dropzone(document.body, { // Make the whole body a dropzone
            url: "/target-url", // Set the url
            thumbnailWidth: 80,
            thumbnailHeight: 80,
            parallelUploads: 20,
            previewTemplate: previewTemplate,
            autoQueue: false, // Make sure the files aren't queued until manually added
            previewsContainer: "#previews", // Define the container to display the previews
            clickable: ".fileinput-button" // Define the element that should be used as click trigger to select files.
        })

        myDropzone.on("addedfile", function (file) {
            // Hookup the start button
            file.previewElement.querySelector(".start").onclick = function () { myDropzone.enqueueFile(file) }
        })

        // Update the total progress bar
        myDropzone.on("totaluploadprogress", function (progress) {
            document.querySelector("#total-progress .progress-bar").style.width = progress + "%"
        })

        myDropzone.on("sending", function (file) {
            // Show the total progress bar when upload starts
            document.querySelector("#total-progress").style.opacity = "1"
            // And disable the start button
            file.previewElement.querySelector(".start").setAttribute("disabled", "disabled")
        })

        // Hide the total progress bar when nothing's uploading anymore
        myDropzone.on("queuecomplete", function (progress) {
            document.querySelector("#total-progress").style.opacity = "0"
        })

        // Setup the buttons for all transfers
        // The "add files" button doesn't need to be setup because the config
        // `clickable` has already been specified.
        document.querySelector("#actions .start").onclick = function () {
            myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED))
        }
        document.querySelector("#actions .cancel").onclick = function () {
            myDropzone.removeAllFiles(true)
        }
  // DropzoneJS Demo Code End
    </script>
</asp:Content>
