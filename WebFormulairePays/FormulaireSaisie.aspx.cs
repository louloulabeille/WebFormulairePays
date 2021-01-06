using A005.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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
            Pays[] p = Pays.GetPays(MapPath(@"~\XmlData\"));

            // option
            listPays.Rows = 1;  //-- affiche une ligne

            foreach (Pays pays in p )
            {
                listPays.Items.Add(pays.LibellePays);
                if (pays.LibellePays == "FRANCE")
                {
                    listPays.SelectedValue = pays.LibellePays;
                }
            }
            
        }

        protected void btn_Envoyer_Click(object sender, EventArgs e)
        {
            if ( Page.IsValid )
            {
                if (!string.IsNullOrEmpty(FileUploadPhoto.FileName))
                {
                    try
                    {
                        FileUploadPhoto.SaveAs(MapPath(@"~/Photo/" + FileUploadPhoto.FileName));
                        ImagePhoto.ImageUrl = @"~/Photo/" + FileUploadPhoto.FileName;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            else
            {
                Response.Write("La page n'est pas valide");
            }
        }

        /// <summary>
        /// méthode de vérification des champs text
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        protected void Txt_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pattern = @"^[a-zA-Z]{4,255}$";
            Regex rgx = new Regex(pattern);

            args.IsValid = (args.Value.Length >= 4 && args.Value.Length <= 255 && rgx.IsMatch(args.Value));
        }
    }
}