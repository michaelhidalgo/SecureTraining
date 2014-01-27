using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace Function
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var watch = new Stopwatch();
            watch.Start();

            RegEx.Validate();
            watch.Stop();
            this.lblRsults.Text = String.Format("Tiempo transcurrido {0} segundos" , watch.ElapsedMilliseconds/1000.0m);
           

        }
    }
}