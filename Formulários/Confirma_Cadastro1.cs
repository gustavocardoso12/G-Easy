using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Confirma_Cadastro1 : Form
    {
        public Confirma_Cadastro1()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_confirmado1 form = new Cadastro_confirmado1();
            form.Show();
            Confirma_Cadastro1 form1 = new Confirma_Cadastro1();
            this.Close();

        }
    }
}
