﻿using System;
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
    public partial class adminMensajes : Form
    {
        public adminMensajes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            enviarMensaje env = new enviarMensaje();
            env.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            colaMensajes me = new colaMensajes();
            me.Show();
        }
    }
}
