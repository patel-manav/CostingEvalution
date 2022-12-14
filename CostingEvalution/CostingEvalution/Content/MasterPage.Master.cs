using CostingEvalution.App_Code.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CostingEvalution.Content
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["UserID"] = "1";
            //Session["UserName"] = "admin";
            //Session["UserDisplayName"] = "admin";
            try
            {
                #region CheckSession
                if (Session["UserName"] != null && Session["UserName"].ToString() != null && Session["UserID"].ToString() != null)
                {
                    UserDisplayName.Text = Session["UserDisplayName"].ToString();
                    FillMenu();
                }
                else
                {
                    Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
                }
                #endregion CheckSession
            }
            catch (Exception ex)
            {

            }
        }

        #region FillDynamicMenu
        public void FillMenu()
        {
            #region Variable
            SEC_MenuBAL balSEC_Menu = new SEC_MenuBAL();
            Int32 UserID = -1;
            #endregion Variable

            #region Validation Data
            if (Session["UserName"].ToString() != null || Session["UserID"].ToString() != null)
            {
                UserID = Int32.Parse(Session["UserID"].ToString());
            }
            else
            {
                Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
            }
            #endregion Validation Data

            #region FillMenu
            using (DataTable dt = balSEC_Menu.FillMenu(UserID))
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    Menu.DataSource = dt;
                    Menu.DataBind();
                    //String a = dt.Rows[0][3].ToString();
                    //Response.Redirect(a);
                    //Server.Transfer(a);

                }
            }
            #endregion FillMenu
        }
        #endregion FillDynamicMenu

        #region Logout
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Redirect(Page.ResolveClientUrl("../Security/SEC_Login.aspx"));
        }
        #endregion Logout

        #region ChangePassword
        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveClientUrl("../Security/SEC_ChangePassword.aspx"));
        }
        #endregion ChangePassword
    }
}