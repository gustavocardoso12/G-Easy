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
    public partial class MiniPaint_Formulario41 : Form
    {
        public MiniPaint_Formulario41()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniPaint_Formulario51 form = new MiniPaint_Formulario51();
            form.Show();
            MiniPaint_Formulario41 form1 = new MiniPaint_Formulario41();
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MiniPaint51 g = new MiniPaint51();
            g.Show();
        }
    }
}
