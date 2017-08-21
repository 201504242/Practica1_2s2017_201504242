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
    public partial class colaMensajes : Form
    {
        conexion con = new conexion();
        int tama = 0;
        public colaMensajes()
        {
            InitializeComponent();
        }

        private void colaMensajes_Load(object sender, EventArgs e)
        {
            string num  = con.getConexionPOST(con.getIP(), "tamaCola", "ip="+ con.getIP()).ToString();
            label2.Text = num;
            tama = Convert.ToInt32(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tama >0)
            {
                string datos = con.getConexionPOST(con.getIP(), "operar", "ip=" + con.getIP()).ToString();
                string[] spi = datos.Split(',');
                textBox1.Text = spi[0];
                textBox4.Text = spi[1];
                textBox5.Text = spi[2];
                textBox6.Text = spi[3];
                tama = tama - 1;
                label2.Text = tama.ToString();
            }
            else
            {
                MessageBox.Show("La cola esta Vacia");
            }
            
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 m = new Form1();
            m.Show();
        }
    }
}
