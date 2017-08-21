using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace appEscritorio
{
    public partial class dashboard : Form
    {
        conexion con = new conexion();
        public string datos = "";
        public static string IpServidor = "";
        public dashboard()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nodo", 100);
            listView1.Columns.Add("IP", 100);
            listView1.Columns.Add("Mascara",100);
            listView1.Columns.Add("Estado", 100);

        }
        //BOTON ATRAS
        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
            Form1 f = new Form1();
            f.Show();
        }
        //BOTON DE LEER JSON
        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                
                 IpServidor = con.getConexionPOST(con.getIP(), "leerJSON", "ubicacion="+path).ToString();
                if (IpServidor != "False")
                {
                    datos = con.getConexionPOST(con.getIP(), "listarNodos", "").ToString();
                    con.getConexionPOST(con.getIP(), "cambiarIP", "");
                    imprimirList(datos);
                    MessageBox.Show("Leido y asignado IP local correctamente");
                    timer1.Enabled = true;                    
                }
                else
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Problema al leer o asignar Json");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();

                }
            }
        }
        //TIMER PARA ACTUALIZAR LISTVIEW
        private void timer1_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string comas = con.getConexionPOST(con.getIP(), "listarNodos", "").ToString();
            imprimirList(comas);
        }
        private void imprimirList(string arreglo)
        {
            Char deli = ',';
            string[] arr = new string[4];
            string[] Nodos = arreglo.Split(deli);
            for (int i = 1; i < Nodos.Length; i = i + 4)
            {
                arr = new string[4];
                arr[0] = "Nodo " + Nodos[i];
                arr[1] = Nodos[i + 1];
                arr[2] = Nodos[i + 2];
                arr[3] = Nodos[i + 3];
                if (arr[1].Equals(IpServidor))
                {
                    arr[3] = "True";
                }
                ListViewItem itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            label1.Text = "Este Nodo: " + con.getIP();
        }
    }
}
