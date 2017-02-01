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
    public partial class MiniPaint_Formulario51 : Form
    {
        public MiniPaint_Formulario51()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniPaint51 ana = new MiniPaint51();
            ana.Show();
            MiniPaint_Formulario51 form1 = new MiniPaint_Formulario51();
            this.Close();
           
        }
    }
}
