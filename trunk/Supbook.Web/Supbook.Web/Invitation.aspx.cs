using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Supbook.Web
{
    public partial class Invitation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Objet mail
            MailMessage msg = new MailMessage();
            // Expéditeur (obligatoire)
            msg.Sender = new MailAddress("plop@khoto.fr");
            // destinataire (il en faut au moins un)
            msg.To.Add(new MailAddress(tb_mail.Text));
            // Texte du mail (facultatif)
            msg.Body = "Bonjour\n" +
            "Vous avez reçut une invitation pour rejoinre Supbook\n" +
            " <a href=\" sup.myprogsoft.com/userInscription.aspx \">Clic ici</a>";

            // Serveur SMTP 587 ; wololo ; plop@khoto.fr ; leeloo.myprogsoft.com
            

            SmtpClient smtp = new SmtpClient("leeloo.myprogsoft.com",587);
            //smtp.Credentials = "wololo";
            // Envoi du mail
            smtp.Send(msg);
        }
    }
}