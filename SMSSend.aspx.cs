using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TextmagicRest.Model;
using TextmagicRest;

namespace Sampradana_SMSSending
{
    public partial class SMSSend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
           

            var client = new Client("test", "my-api-key");
            var link = client.SendMessage("Hello from TextMagic API", "8123131426");
            if (link.Success)
            {
                Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
            }
            else
            {
                Console.WriteLine("Message was not sent due to following exception: {0}", link.ClientException.Message);
           }
        }
    }
}