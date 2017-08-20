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
    public partial class cliente : Form
    {
        conexion con = new conexion();
        public cliente()
        {
            InitializeComponent();
        }
        // BOTON ADMIN MENSAJES
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminMensajes ad = new adminMensajes();
            ad.Show();
        }
        //BOTON ATRAS
        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
        //BOTON REPORTES
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes repo = new reportes();
            repo.Show();

        }
        //BOTON PROBAR CONEXION
        private void button4_Click(object sender, EventArgs e)
        {
            Object retorno = con.getConexionPOST(con.getIP(), "prueba", "data=EXITO&hola=" + 10).ToString();
            if (!retorno.Equals("error"))
            {
                MessageBox.Show("Peticion a : " + con.getIP() + ":5000/prueba");
            }
            else
            {
                Form1 re = new Form1();
                re.Show();
                MessageBox.Show("ERROR de conexion con el servidor");
                this.Hide();
            }
        }
    }
}
