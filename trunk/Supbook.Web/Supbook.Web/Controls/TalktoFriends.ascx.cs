using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web.Controls
{
    public partial class TalktoFriends : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    int myIdUser = (int)Session["id"];

                    ddl_selectUser.DataSource = Utilisateur.GetFriendsById(myIdUser);
                    ddl_selectUser.DataBind();

                    lview_listUsers.DataSource = MPs.GetListMPsUser(myIdUser);
                    lview_listUsers.DataBind();
                }
            }
        }

        protected void bt_newPrivateMessage_Click(object sender, EventArgs e)
        {
            //Session["login"] = "79135@supinfo.com";

            MP msg = new MP();
            msg.TxtMP = tb_newPrivateMessage.Text;
            msg.DateMP = DateTime.Now;
            msg.IdUser = Utilisateur.GetByLogin(Session["login"].ToString()).IdUser;
            msg.IdContact = int.Parse(ddl_selectUser.SelectedValue);

            SupbookEntities ctx = new SupbookEntities();

            ctx.MPs.AddObject(msg);
            ctx.SaveChanges();
        }
    }
}