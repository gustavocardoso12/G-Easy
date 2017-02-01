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
    /// Interaction logic for TrianguloeQuadCircuferencia.xaml
    /// </summary>
    public partial class TrianguloeQuadCircuferencia : UserControl
    {
        public TrianguloeQuadCircuferencia()
        {
            InitializeComponent();
            gradeap.Visibility = Visibility.Hidden;
            grade1.Visibility = Visibility.Hidden;
            gradeconfirma.Visibility = Visibility.Hidden;
            grade2.Visibility = Visibility.Hidden;
            gradeap_Copy.Visibility = Visibility.Hidden;
            gradeconfirma_Copy.Visibility = Visibility.Hidden;
            Bgrade.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                
                    ScaleTransform scaleTransform1 = new ScaleTransform(0.4 + ((double.Parse(raio.Text))) / 20, 0.4 + ((double.Parse(raio.Text))) / 20, -40, -40);
                    grade1.RenderTransform = scaleTransform1;
                    grade2.RenderTransform = scaleTransform1;
                    gradeconfirma.Visibility = Visibility.Hidden;
                    gradeap.Visibility = Visibility.Visible;
                    grade1.Visibility = Visibility.Visible;

                    raio1.Text = raio.Text;
                
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            res.Content = double.Parse(raio.Text) / 2;
            Bgrade.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            res1.Content = double.Parse(raio2.Text)*1.41;
            res1_Copy.Content = (double.Parse(raio2.Text) * 1.41) / 2;
            Bgrade.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Escolha.Visibility = Visibility.Hidden;
            gradeconfirma.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            gradeconfirma_Copy.Visibility = Visibility.Visible;
            Escolha.Visibility = Visibility.Hidden;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
              
                    raio2.Text = raio3.Text;
                    ScaleTransform scaleTransform1 = new ScaleTransform(0.4 + ((double.Parse(raio3.Text))) / 20, 0.4 + ((double.Parse(raio3.Text))) / 20, -40, -40);

                    grade2.RenderTransform = scaleTransform1;
                    grade2.Visibility = Visibility.Visible;
                    gradeconfirma_Copy.Visibility = Visibility.Hidden;
                    gradeap_Copy.Visibility = Visibility.Visible;
                
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            gradeap.Visibility = Visibility.Hidden;
            grade1.Visibility = Visibility.Hidden;
            gradeconfirma.Visibility = Visibility.Hidden;
            grade2.Visibility = Visibility.Hidden;
            gradeap_Copy.Visibility = Visibility.Hidden;
            gradeconfirma_Copy.Visibility = Visibility.Hidden;
            Escolha.Visibility = Visibility.Visible;
            Bgrade.Visibility = Visibility.Hidden;
        }
    }
}
