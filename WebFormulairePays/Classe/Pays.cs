using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;

namespace A005.Models
{
    /// <summary>
    /// Entité Pays 
    /// Comporte aussi les devises
    /// </summary>
    [Serializable]
    public class Pays
    {
        public string IdPays2 { get; set; }
        public string IdPays3 { get; set; }
        public int IdPaysNum { get; set; }
        public string IdDevise { get; set; }
        public string LibellePays { get; set; }
        public static Pays[] GetPays(string pathPays)
        {
            XmlSerializer xmlS = new XmlSerializer(typeof(Pays[]));
            StreamReader sR = new StreamReader(string.Format("{0}{1}",pathPays,"Pays.XML"));
            return (Pays[])xmlS.Deserialize(sR);
        }
    }
}