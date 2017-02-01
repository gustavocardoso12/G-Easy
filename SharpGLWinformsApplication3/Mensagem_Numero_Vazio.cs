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
    public partial class Mensagem_Numero_Vazio : Form
    {

        public Mensagem_Numero_Vazio()
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
