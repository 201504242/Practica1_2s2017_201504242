using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace appEscritorio
{
    public partial class enviarMensaje : Form
    {
        conexion con = new conexion();
        String server = dashboard.IpServidor;
        List<mensaje> mensajes = new List<mensaje>();
        public enviarMensaje()
        {
            InitializeComponent();
        }
        //CARGAR XML DE OPERACIONES
        private void button2_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                string retorno = con.getConexionPOST(con.getIP(), "leerXML", "ubicacion=" + path).ToString();
                String[] Spliter = retorno.Split('?');
                for (int i = 1; i < Spliter.Length; i = i +2)
                {
                    mensajes.Add(new mensaje(Spliter[i], Spliter[i + 1]));
                }
                foreach (var item in mensajes)
                {
                    string metodoMensaje = con.getConexionPOST(item.Ip, "mensaje", "inorden=" + item.Texto).ToString();
                    if (metodoMensaje.Equals("true"))
                    {
                        MessageBox.Show("EXITO");
                    }
                    else
                    {
                        MessageBox.Show("FALLO: " + item.Ip + " con: "+ item.Texto);
                    }
                }

            }

        }


        private void manual_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text;
            string[] lines = texto.Split('\n');

            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\p_ab1\\Desktop\\product.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Mensajes");
            createNode("1", writer);
            createNode("2", writer);
            createNode("3", writer);
            createNode("4", writer);

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
        }
        private void createNode(string pID, XmlTextWriter writer)
        {
            writer.WriteStartElement("Mensaje");
            writer.WriteStartElement("Nodo");
            writer.WriteStartElement("IP");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = "((2?8) * 7 ? (7 * (6 ? 1)))";
            string metodoMensaje = con.getConexionPOST(con.getIP(), "mensaje", "inorden="+ma).ToString();
            if (metodoMensaje.Equals("true"))
            {
                MessageBox.Show("todo bien");
            }
        }

    }
}
