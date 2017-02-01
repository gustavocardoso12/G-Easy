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
using HelixToolkit.Wpf;
namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for Esfera_Setor.xaml
    /// </summary>
    public partial class Esfera_Setor : UserControl
    {
        public Esfera_Setor()
        {
            InitializeComponent();
            gradesetor.Visibility = Visibility.Hidden;
            gradeconfirmacao.Visibility = Visibility.Visible;
          
        }

        private void botaoAT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             
                    EsferaObjeto.Radius = double.Parse(Raio.Text) - (double.Parse(Raio.Text) * 0.3);
                    plano.Width = double.Parse(Raio.Text) * 1.3;
                    plano.Length = double.Parse(Raio.Text) * 1.3;
                    raioaoquadrado.Content = double.Parse(Raio.Text) * double.Parse(Raio.Text);
                    distanciaaoquadrado.Content = double.Parse(Distancia.Text) * double.Parse(Distancia.Text);
                    Raiz.Content = (double.Parse(Raio.Text) * double.Parse(Raio.Text)) + (double.Parse(Distancia.Text) * double.Parse(Distancia.Text));
                    Res.Content = Math.Sqrt((double.Parse(Raio.Text) * double.Parse(Raio.Text)) + (double.Parse(Distancia.Text) * double.Parse(Distancia.Text)));
                
                }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }

        private void botaoAT2_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                Distancia.Text = texto.Text;
                double a = double.Parse(texto.Text);
                if (a > 0)
                {
                    gradesetor.Visibility = Visibility.Visible;
                    gradeconfirmacao.Visibility = Visibility.Hidden;
                }
              
                if (double.Parse(texto.Text) < 0)
                {
                    MessageBox.Show("Não São Aceitos Valores Negativos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("digite números neste campo");
            }
           
            
        }
    }
}
