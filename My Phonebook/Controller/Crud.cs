using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controller
{
    public class Crud
    {
        XDocument miXML = XDocument.Load(@"Contact.xml");
        DataSet ds = new DataSet();

        public void agregar(string name, string address, string detalle)
        { 
        
        }
        public void cargar()
        {
            ds.Clear();
            var Archivo = "Contact.xml";
            ds.ReadXml(Archivo);
        }
 
    }
}
