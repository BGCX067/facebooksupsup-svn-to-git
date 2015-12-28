using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supbook.Web
{
    public partial class MessageFormControle : System.Web.UI.UserControl
    {
        public event EventHandler<MessageEventArgs> OnValidate;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_send_message_Click(object sender, EventArgs e)
        {
            if(OnValidate!=null)
                OnValidate(this, new MessageEventArgs() { message=tb_message.Text});
        }
    }

    public class MessageEventArgs: EventArgs
    {
        public String message {get; set;}
    }
}