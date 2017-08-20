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
                string retorno = con.getConexionPOST(con.getIP(), "mensaje", "inorden=" + path).ToString();

            }

        }


        private void manual_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text;

        }
    }
}
