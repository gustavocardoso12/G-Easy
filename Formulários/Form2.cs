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
    
    public partial class Form2 : Form
    {


       
        
        
           
        
        public Form2()
        {
            InitializeComponent();
        }

       public void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OK.accdb;Persist Security Info=True;";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdDataBase = new OleDbCommand("update Cliente SET SenhaUsuario='"+textBox3.Text+"'where Email='" + this.textBox1.Text + "' and CPF='" + this.maskedTextBox1.Text + "';", conDataBase);
                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                    
                   MiniPaint51 form = new MiniPaint51();
                    form.Show();
                    Form2 form1 = new Form2();
                    this.Close();


               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OK.accdb;Persist Security Info=True;";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdDataBase = new OleDbCommand("Select * from Cliente where Email='" + this.textBox1.Text + "' and CPF='" + this.maskedTextBox1.Text + "';", conDataBase);
                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    button1.Visible = true;
                    label5.Visible = true;
                    textBox3.Visible = true;
                   


                }
                else if (count > 1)
                {
                    Dados_Ja_Cadastrados DJ = new Dados_Ja_Cadastrados();
                    DJ.Show();
                }
                else
                {
                    MSG24 M = new MSG24();
                    M.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniPaint2 form = new MiniPaint2();
            this.Close();
            MiniPaint51 form1 = new MiniPaint51();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MSG23 M = new MSG23();
            M.Show();
        }

    }
   
}
