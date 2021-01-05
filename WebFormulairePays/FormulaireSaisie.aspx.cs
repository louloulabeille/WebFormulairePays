using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormulairePays
{
    public partial class FormulaireSaisie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listPays.DataSource = "France";
        }
    }
}