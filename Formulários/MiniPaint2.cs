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
    
    public partial class MiniPaint2 : Form
         
    {
       
        public MiniPaint2()
        {
            InitializeComponent();
          
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MiniPaint2_Load(object sender, EventArgs e)
        {
       
          
            // TODO: This line of code loads data into the 'oKDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.oKDataSet.Cliente);
            // TODO: This line of code loads data into the 'oKDataSet.Tipo_Usuario' table. You can move, or remove it, as needed.
            this.tipo_UsuarioTableAdapter.Fill(this.oKDataSet.Tipo_Usuario);


            this.clienteBindingSource.AddNew();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
       
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void nome_CompletoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Aluno")
                {
                    cod_Tipo_UsuarioTextBox.Text = "1";
                }
                else
                {
                    cod_Tipo_UsuarioTextBox.Text = "2";
                }

                AppDomain.CurrentDomain.SetData("DataDirectory",@"C:\G-Easy");
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OK.accdb;Persist Security Info=True;";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdDataBase = new OleDbCommand("Select * from Cliente where  Email='" + this.emailTextBox.Text + "' and NomeUsuario='" + this.nomeUsuarioTextBox.Text + "' and CPF='" + this.cPFMaskedTextBox.Text + "';", conDataBase);
                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;

                if (Validacao.ValidaCPF.IsCpf(cPFMaskedTextBox.Text))
                {
                   
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }


                    if (count < 1)
                    {

                        if (this.Validate())
                        {

                            if ((cPFMaskedTextBox.Text == "") || (nome_CompletoTextBox.Text == "") || (nomeUsuarioTextBox.Text == "") || (emailTextBox.Text == "") || (comboBox1.Text == ""))
                            {
                                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                                M.Show();
                            }
                            else
                            {
                                this.Validate();
                                this.clienteBindingSource.EndEdit();
                                this.tableAdapterManager.UpdateAll(this.oKDataSet);
                                if (cod_Tipo_UsuarioTextBox.Text == "2")
                                {
                                    MiniPaint_Formulario41 form = new MiniPaint_Formulario41();
                                    form.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    Confirma_Cadastro1 c = new Confirma_Cadastro1();
                                    c.Show();

                                    this.Hide();
                                }

                            }

                        }
                    }
                    else
                    {
                        Dados_Ja_Cadastrados DJC = new Dados_Ja_Cadastrados();
                        DJC.Show();
                    }
                }
                else
                {
                    MSG25 CPF = new MSG25();
                    CPF.Show();
                }
                  
                }
            
            catch (Exception ex)
            {
                Dados_Ja_Cadastrados DJC = new Dados_Ja_Cadastrados();
                DJC.Show();
            }
           
                
            }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            MiniPaint2 form = new MiniPaint2();
            this.Close();
            MiniPaint51 form1 = new MiniPaint51();
            form1.Show();
        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oKDataSet);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            senhaUsuarioTextBox.PasswordChar = checkBox1.Checked ? '\0' : '*'; ;
        }

        private void senhaUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

      

  

       
    }
}
