using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web
{
    public partial class privateSingleMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lview_MPs.DataSource = MPs.GetAllMPsByIdUser(int.Parse(Request.Params["id"]));
                lview_MPs.DataBind();
            }
        }
    }
}