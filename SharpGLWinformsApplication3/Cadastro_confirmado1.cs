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
    public partial class Cadastro_confirmado1 : Form
    {
        public Cadastro_confirmado1()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Alunos1 D = new FRM_Alunos1();
            D.Show();
            Cadastro_confirmado1 form1 = new Cadastro_confirmado1();
            this.Close();

        }
    }
}
