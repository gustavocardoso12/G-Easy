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
    /// Interaction logic for AreaLateralCilindro.xaml
    /// </summary>
    public partial class AreaLateralCilindro : UserControl
    {
        public AreaLateralCilindro()
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
                    doisvezesraio.Content = ((double.Parse(Raio1.Text) * 2));
                    pivezesaltura.Content = (double.Parse(Altura.Text) * 3.14);
                    res.Content = ((double.Parse(Raio1.Text) * 2)) * (double.Parse(Altura.Text) * 3.14);
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
