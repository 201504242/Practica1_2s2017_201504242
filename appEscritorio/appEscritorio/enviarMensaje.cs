using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
