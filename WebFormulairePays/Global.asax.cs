using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormulairePays
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code qui s’exécute au démarrage de l’application
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application.Add("dateDebut", DateTime.Now);
            Application.Add("nbSession",0); //-- initalitation du nombre de session ouvert
            Application.Add("nbRequete", 0);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Add("dateDebut", DateTime.Now);

            Application.Lock();
            Application.Set("nbSession", Convert.ToInt32(Application.Get("nbSession")) + 1);
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application.Add("nbSession", Convert.ToInt32(Application.Get("nbSession")) -1 );
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Application.Lock();
            Context.Items.Add("dateDebut",DateTime.Now);
            Application.Set("nbRequete", Convert.ToInt32(Application.Get("nbRequete")) + 1);
            Application.UnLock();
        }
    }
}