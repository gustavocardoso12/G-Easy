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
    /// Interaction logic for AreaLateralCone.xaml
    /// </summary>
    public partial class AreaLateralCone : UserControl
    {
        public AreaLateralCone()
        {
            InitializeComponent();

            Grade1.Visibility = Visibility.Hidden;
            botao2.Visibility = Visibility.Hidden;
            AreaTotal.Visibility = Visibility.Hidden;
            DemontrarAreaTotal.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConeObjeto.BaseRadius = double.Parse(Raio1.Text);
            ConeObjeto.TopRadius = double.Parse(Geratriz.Text);

           

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                    ConeObjeto.BaseRadius = double.Parse(Raio_Calculo_Geratriz.Text) - double.Parse(Raio_Calculo_Geratriz.Text) * 0.7;
                    ConeObjeto.Height = double.Parse(Altura_Calculo_Geratriz.Text) - double.Parse((Altura_Calculo_Geratriz.Text)) * 0.5;
                    Alturaaoquadrado.Content = double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text);
                    RaioaoQuadrado.Content = double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text);
                    Res.Content = (double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text));
                    Res1.Content = Math.Sqrt(((double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text))));

                    botao2.Visibility = Visibility.Visible;
                    botao1.Visibility = Visibility.Hidden;
                    Raio_Calculo_Geratriz.IsEnabled = false;
                    Altura_Calculo_Geratriz.IsEnabled = false;
                
                
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void botao2_Click(object sender, RoutedEventArgs e)
        {
            botao3.Visibility = Visibility.Hidden;

            raiovezespi.Content = double.Parse(Raio1.Text) * 3.14;
            Geratriz1.Content = double.Parse(Geratriz.Text);
            res.Content = (double.Parse(Raio1.Text) * 3.14) * double.Parse(Geratriz.Text);
           botao2.Visibility = Visibility.Hidden;
          
           DemontrarAreaTotal.Visibility = Visibility.Visible;
        }

        private void botao2_Click_1(object sender, RoutedEventArgs e)
        {
            Grade1.Visibility = Visibility.Visible;
            Grade_Geratriz.Visibility = Visibility.Hidden;
            Geratriz.Text = (Math.Sqrt(((double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text))))).ToString();
            Raio1.Text = Raio_Calculo_Geratriz.Text;
            botaoAT.Visibility = Visibility.Hidden;
        }

        private void botao3_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botaoAT_Click(object sender, RoutedEventArgs e)
        {
            pivezesraio_AT.Content = 3.14 * (double.Parse(Raio_AT.Text) * double.Parse(Raio_AT.Text));
            AL.Content = AL_AT.Text;
            Res_AT.Content = 3.14 * (double.Parse(Raio_AT.Text) * double.Parse(Raio_AT.Text)) + double.Parse(AL_AT.Text);

        }

        private void DemontrarAreaTotal_Click(object sender, RoutedEventArgs e)
        {
            AreaTotal.Visibility = Visibility.Visible;
            Grade1.Visibility = Visibility.Hidden;
            AL_AT.Text = ((double.Parse(Raio1.Text) * 3.14) * double.Parse(Geratriz.Text)).ToString();
            Raio_AT.Text = Raio_Calculo_Geratriz.Text;
            botaoAT.Visibility = Visibility.Visible;
        }
    }
}
