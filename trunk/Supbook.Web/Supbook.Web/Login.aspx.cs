using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web
{
    public partial class Login : System.Web.UI.Page
    {
        private SupbookEntities bdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            bdd = new SupbookEntities();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var query = from user in bdd.Utilisateurs
                        where user.Login == TextBoxUsername.Text && user.Password == TextBoxPassword.Text
                        select new
                        {
                            user.IdUser,
                            user.Login

                        };

            if (query.ToList().Count()>0)
            {
                Session["id"] = query.First().IdUser;
                Session["login"] = query.First().Login;
                Response.Redirect("/mypage.aspx");
            }
            else {

                LabelError.Visible = true;
            }

        }

        
    }
}