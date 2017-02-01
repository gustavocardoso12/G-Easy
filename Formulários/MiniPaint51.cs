using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MiniPaint
{
  
    public partial class MiniPaint51 : Form
    {
        
      
        public MiniPaint51()
        {
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
         
           

           
            System.Drawing.Drawing2D.GraphicsPath XY = new System.Drawing.Drawing2D.GraphicsPath();
            XY.AddEllipse(50, 40, 700, 400);
            this.Region = new Region(XY);
            MiniPaint51 form = new MiniPaint51();
            form.StartPosition = FormStartPosition.CenterParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text =="Aluno"){
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = "2";
            }
            try
                {
                    string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OK.accdb;Persist Security Info=True;";
            OleDbConnection conDataBase = new OleDbConnection(constring);
            OleDbCommand cmdDataBase = new OleDbCommand("Select * from  Cliente where Cod_Tipo_Usuario=" +int.Parse(textBox1.Text)+ " and NomeUsuario='" + this.T1.Text + "' and SenhaUsuario='" + this.T2.Text + "';", conDataBase);
          
                OleDbDataReader myReader;
           
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count=count+1;
                }

               
           
             
                if (count == 1 )
                {

                    if (textBox1.Text == "2")
                    {


                        ESSE1 d = new ESSE1();
                        d.Show();
                        MiniPaint51 form1 = new MiniPaint51();
                        this.Dispose(true);
                    }
                    else{
                        FRM_Alunos1 F = new FRM_Alunos1();
                        F.Show();
                        MiniPaint51 form1 = new MiniPaint51();
                        this.Dispose(true);
                    }
                    
                }
                else if (count > 1)
                {
                    Dados_Ja_Cadastrados D = new Dados_Ja_Cadastrados();
                    D.Show();
                }
                else
                {
                    Dados_Invalidos D = new Dados_Invalidos();
                    D.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            


        }
           
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MiniPaint51 form1 = new MiniPaint51();
            this.Close();
            MiniPaint2 form = new MiniPaint2();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            MiniPaint51 form1 = new MiniPaint51();
            this.Close();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void T2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            T2.PasswordChar = checkBox1.Checked ? '\0' : '*'; ;
        }
    }
}
