using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
     
        
        
        public UserControl4()
        {
            InitializeComponent();
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
             
                    cilindroobjeto.BaseRadius = double.Parse(Raio1.Text) - double.Parse(Raio1.Text)*0.5;
                    cilindroobjeto.Height = double.Parse(Altura.Text) - double.Parse(Altura.Text)*0.5;
                    cilindroobjeto.TopRadius = double.Parse(Raio1.Text) - double.Parse(Raio1.Text)*0.5;

                    label1.Content = ((double.Parse(Raio1.Text) * (double.Parse(Raio1.Text))));
                    label2.Content = ((double.Parse(Raio1.Text) * (double.Parse(Raio1.Text)) * 3.14));
                    label3.Content = ((double.Parse(Raio1.Text) * (double.Parse(Raio1.Text)) * 3.14) * double.Parse(Altura.Text));
                    label4.Content = (double.Parse(Altura.Text));
                    label4_Copy.Content = (double.Parse(Altura.Text));
              
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
            

          
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
 
       


           
        

       

     

    }
}
