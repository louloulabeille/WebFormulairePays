using A005.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Controls;

namespace WebFormulairePays
{
    public partial class FormulaireSaisie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if ( !IsPostBack)
            {
                RecuptPays();
            }
        }


        /// <summary>
        /// remplie la liste box et ajoute les options de la liste
        /// </summary>
        protected void RecuptPays ()
        {
            Pays[] p = Pays.GetPays(MapPath(@"\XmlData\"));
            listPays.Items.Add("France");

            // option
            listPays.Rows = 1;  //-- affiche une ligne

            foreach (Pays pays in p )
            {
                if ( pays.LibellePays != "France" )
                {
                    listPays.Items.Add(pays.LibellePays);
                }
            }
        }
    }
}