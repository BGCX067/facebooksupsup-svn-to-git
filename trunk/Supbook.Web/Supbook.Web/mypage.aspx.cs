using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web
{
    public partial class mypage : System.Web.UI.Page
    {
        SupbookEntities sup = new SupbookEntities();
        Wall monwall = new Wall();
        int userId = 0;
        int id = 0;
        List<Wall> malist = new List<Wall>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                String s = Request.QueryString["id"];
                if (s != null && !string.IsNullOrWhiteSpace(s))
                {
                    int.TryParse(Request.Params["id"].ToString(), out userId);
                }
                else
                {
                    int.TryParse(Session["id"].ToString(), out userId);
                }
                id = userId;
                malist = sup.Walls.Where(aa => aa.IdUser == id).ToList();
                Listedesannonces.DataSource = sup.Walls.Where(aa => aa.IdUser == id).ToList();
                Listedesannonces.DataBind();
            }

            // Récupération ID du connecté
            int loggedInId = 0;
            if( Session["id"]!= null)
            {
                int.TryParse(Session["id"].ToString(), out loggedInId);
            }

            // Récupération utilisateur de la page visitée
            if (loggedInId > 0)
            {
                Utilisateur theUser = Utilisateur.GetByID(id);
                if (theUser != null)
                {
                    // Vérification droit de publier
                    // Autoriser pour l'utilisateur
                    if (theUser.PreventPublicPublish &&
                        theUser.IdUser != loggedInId)
                    {
                        this.PanelPublishStatus.Visible = false;
                    }
                }
            }
            else
            {
                // Pas connecté
                Response.Redirect("/Login.aspx");
            }
        }

        public void add(Object Sender, EventArgs E)
        {
            int.TryParse(Request.Params["id"].ToString(), out userId);
            id = userId;
            if (monmessage.Text != "A propos de moi")
            {
                monwall.IdUser = id;
                monwall.DateWall = DateTime.Today;
                monwall.TxtWall = monmessage.Text;
                monwall.TitreWall = "";
                sup.AddToWalls(monwall);
                monmessage.Text = "A propos de moi";
             }
                Listedesannonces.DataSource = sup.Walls.Where(aa => aa.IdUser == id).ToList();
                Listedesannonces.DataBind();
            }
        }
    }

