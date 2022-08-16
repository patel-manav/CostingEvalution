using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.AdminPanel.Security
{
    public partial class SEC_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            if (!Page.IsPostBack)
            {

            }
            if (Page.IsPostBack)
            {
                txtUserPassword.Attributes["value"] = txtUserPassword.Text;
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            #region Variable
            SEC_UserBAL balSEC_User = new SEC_UserBAL();
            #endregion Variable

            #region Validation
            if (txtUserName.Text == "")
            {
                lblUserName.Visible = true;
                lblUserPassword.Visible = false;
                lblPasswordIncorrect.Visible = false;
                return;
            }
            if (txtUserPassword.Text == "")
            {
                lblUserName.Visible = false;
                lblUserPassword.Visible = true;
                lblPasswordIncorrect.Visible = false;
                return;
            }
            #endregion Validation

            #region GatherData
            String UserName = txtUserName.Text;
            String UserPassword = txtUserPassword.Text;
            #endregion GatherData

            #region FetchData
            DataTable dt = balSEC_User.UserSignIn(UserName, UserPassword);

            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0][1].ToString() == txtUserName.Text && dt.Rows[0][3].ToString() == txtUserPassword.Text)
                {
                    //UserID
                    Session["UserID"] = dt.Rows[0][0].ToString();

                    //UserName
                    Session["UserName"] = dt.Rows[0][1].ToString();

                    //UserDisplayName
                    Session["UserDisplayName"] = dt.Rows[0][2].ToString();

                    IPHostEntry iph;
                    string myip = "";
                    iph = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in iph.AddressList)
                    {
                        if (ip.AddressFamily == AddressFamily.InterNetwork)
                        {
                            myip = ip.ToString();
                        }
                    }

                    Session["IP"] = myip;


                    Response.Redirect(Page.ResolveClientUrl("../Master/MST_Unit.aspx"));
                    lblUserName.Visible = false;
                    lblUserPassword.Visible = false;
                }
                else
                {
                    txtUserName.Text = "";
                    txtUserPassword.Text = "";
                    lblPasswordIncorrect.Visible = true;
                    lblUserPassword.Visible = false;
                    lblUserName.Visible = false;
                    txtUserPassword.Attributes["value"] = "";
                    Session.RemoveAll();
                }
            }
            else
            {
                txtUserPassword.Attributes["value"] = "";
                txtUserName.Text = "";
                txtUserPassword.Text = "";
                lblPasswordIncorrect.Visible = true;
                lblUserPassword.Visible = false;
                lblUserName.Visible = false;
                Session.RemoveAll();
            }
            #endregion FetchData
        }
    }
}