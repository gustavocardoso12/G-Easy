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
    /// Interaction logic for AreaDeSuperficie_Esfera.xaml
    /// </summary>
    public partial class AreaDeSuperficie_Esfera : UserControl
    {
        public AreaDeSuperficie_Esfera()
        {
            InitializeComponent();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                    Esfera.Radius = double.Parse(Raio.Text) - double.Parse(Raio.Text) * 0.6;
                    EsferaObjeto.Radius = double.Parse(Raio.Text) - double.Parse(Raio.Text) * 0.6;

                    quatrovezespi.Content = double.Parse(PI.Text) * 4;
                    raioaoquadrado.Content = (double.Parse(Raio.Text) * double.Parse(Raio.Text));
                    Res.Content = (double.Parse(Raio.Text) * double.Parse(Raio.Text)) * (double.Parse(PI.Text) * 4);
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
