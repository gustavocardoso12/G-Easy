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

namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for AreaTotalCilindro.xaml
    /// </summary>
    public partial class AreaTotalCilindro : UserControl
    {
        public AreaTotalCilindro()
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
                    doisvezesraiovezespi.Content = double.Parse(Raio1.Text) * 2 * 3.14;
                    raiomaisaltura.Content = double.Parse(Raio1.Text) + double.Parse(Altura.Text);
                    res.Content = (double.Parse(Raio1.Text) * 2 * 3.14) * (double.Parse(Raio1.Text) + double.Parse(Altura.Text));
                    RaioCopia.Text = Raio1.Text;
              
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
