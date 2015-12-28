using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Supbook.Web;
using System.IO;
using System.Data.SqlClient;

namespace Supbook.Web
{
    public partial class userInscription : System.Web.UI.Page
    {
        SupbookEntities ctx = new SupbookEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_valid_Click(object sender, EventArgs e)
        {
            
            String photoFolder = Server.MapPath("/") + "/photos";
            String filename = Path.GetRandomFileName();
            if (fu_photo.HasFile)
                try
                {
                    photoFolder = Server.MapPath("/") + "/photos";
                    filename = Path.GetRandomFileName();

                    if (!Directory.Exists(photoFolder))
                        Directory.CreateDirectory(photoFolder);

                    fu_photo.SaveAs(photoFolder + filename);

                    lb_error.Text = "Fichier uploadé";
                }
                catch (Exception ex)
                {
                    lb_error.Text = "ERROR: " + ex.Message.ToString();
                }
            else
            {
                lb_error.Text = "You have not specified a file.";
            }

            if (cal_born_date.SelectedDate == DateTime.MinValue)
            {
                lb_date_naissance_error.Text = "Vous devez choisir une date de naissance";
                return;
            }

            Utilisateur newUser = new Utilisateur();
            newUser.Nom = tb_nom.Text;
            newUser.Prenom = tb_prenom.Text;
            newUser.DateDeNaissance = cal_born_date.SelectedDate;
            newUser.Login = tb_mail.Text;
            newUser.Mail = tb_mail.Text;
            newUser.Password = tb_pass.Text;
            newUser.Adresse = tb_adresse.Text;
            newUser.ImagePath = "/photos/" + filename;
            ctx.Utilisateurs.AddObject(newUser);
            
            try
            {
                ctx.SaveChanges();
                Response.Redirect("Login.aspx");
            }
            catch (SqlException)
            {
                lb_error.Text = "Une erreur SQL est apparue";
            }
            catch (Exception)
            {
                lb_error.Text = "Une erreur est apparue";
            }
           

            
        }
    }
}