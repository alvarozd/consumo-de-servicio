using lectorxml.WebReference;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lectorxml
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string user = "GRCEOPORTALV";
        string pass = "UfTgN-kE2a566&/";
        private void button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.DT_EstadoCuenta_req consulta = new ServiceReference1.DT_EstadoCuenta_req();
            ServiceReference1.DT_EstadoCuenta_res respuesta = new ServiceReference1.DT_EstadoCuenta_res();
            ServiceReference1.EstCuenta_OutClient salida = new ServiceReference1.EstCuenta_OutClient();
            


             consulta.contrato = "342692";
            salida.ClientCredentials.UserName.UserName = user;
            salida.ClientCredentials.UserName.Password = pass;
           respuesta = salida.EstCuenta_Sync(consulta);



            string cod = JsonConvert.SerializeObject(respuesta);
            cod = cod.Replace("{\"OclFactData\":\"", string.Empty);
            cod = cod.Replace("\\n\",\"OnuErrorcode\":\"0\",\"osbErrorMessage\":\"Operacion Exitosa\"}", string.Empty);
            cod = cod.Replace("\\n", string.Empty);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(cod);
            string json = JsonConvert.SerializeXmlNode(xmlDocument);


            textBox1.Text = json; 
           


        
            
          
        }
    }
}
