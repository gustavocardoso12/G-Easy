using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WiimoteLib;                       //WimoteLibの宣言
using System.Runtime.InteropServices;  //DllImportを使うための宣言


namespace MiniPaint
{
    public partial class MSG23 : Form
    {

        public MSG23()
        {

            InitializeComponent();



        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensagem_Numero_Vazio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2 F = new Form2();
            F.Show();
        }


    }
}
