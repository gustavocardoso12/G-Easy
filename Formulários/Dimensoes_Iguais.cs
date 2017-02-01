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
    public partial class Dimensoes_Iguais : Form
    {

        public Dimensoes_Iguais()
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


    }
}
