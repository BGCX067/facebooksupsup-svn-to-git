using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web
{
    public partial class timeline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idUser = 0;
            if (Session["id"] != null)
            {
                int.TryParse(Session["id"].ToString(), out idUser);
            }

            if (idUser > 0)
            {
                if (!IsPostBack)
                {
                    RepeaterWall.DataSource = Wall.GetAllByUserId(idUser);
                    RepeaterWall.DataBind();
                }
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }
        }
    }
}