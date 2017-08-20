using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEscritorio
{
    public partial class Form1 : Form
    {
        conexion con = new conexion();
        public Form1()
        {

            InitializeComponent();
        }


        public string consola(string comando) {
            Process eje = new Process();
            eje.StartInfo.FileName = "cmd.exe";
            eje.StartInfo.Arguments = "/c" + comando;
            eje.StartInfo.RedirectStandardError = true;
            eje.StartInfo.RedirectStandardOutput = true;
            eje.StartInfo.UseShellExecute = false;
            eje.StartInfo.CreateNoWindow = true;
            eje.Start();
            String a = eje.StandardOutput.ReadToEnd();
            return a;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            consola("cd C:\\Users\\p_ab1\\Desktop");
            consola("dir");
           
            //ExecuteComman =d("cd\\");
           // ExecuteCommand("C:\\Users\\p_ab1\\Desktop\\Practica1_2s2017_201504242");
            //ExecuteCommand("dir");
            //ExecuteCommand("python SERVER.py");

            //System.Diagnod C:\Users\p_ab1\Desktop\Practica1_2s2017_201504242stics.Process proc = new System.Diagnostics.Process();
            //proc.EnableRaisingEvents = false;
            //proc.StartInfo.FileName = "C";
            //proc.Start();
        }

        static void ExecuteCommand(string _Command)
        {
            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
            //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
            //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd",  _Command);
            // Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            string result = proc.StandardOutput.ReadToEnd();
            //Muestra en pantalla la salida del Comando
            Console.WriteLine(result);
        }


        private void cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            cliente c = new cliente();
            c.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard das = new dashboard();
            das.Show();
        }
    }
}
