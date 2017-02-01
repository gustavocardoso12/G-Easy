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
using System.Windows.Media.Media3D;
namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for Geratriz_Piramide.xaml
    /// </summary>
    public partial class Geratriz_Piramide : UserControl
    {
        public Geratriz_Piramide()
        {
            InitializeComponent();
            DemontrarAreaTotal.Visibility = Visibility.Hidden;
            Grade1.Visibility = Visibility.Hidden;
            botao2.Visibility = Visibility.Hidden;
            AreaTotal.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {

              
                    camera.Visibility = Visibility.Visible;
                    double a;
                    double b;
                    b = (double.Parse(Altura_Calculo_Geratriz.Text)) - ((double.Parse(Altura_Calculo_Geratriz.Text)) * 0.9);
                    a = ((double.Parse(Raio_Calculo_Geratriz.Text)) - ((double.Parse(Raio_Calculo_Geratriz.Text)) * 0.9));
                    mesh.Positions.Clear();
                    mesh.Positions.Add(new Point3D(0, b, -1));
                    mesh.Positions.Add(new Point3D(a, -1, a));
                    mesh.Positions.Add(new Point3D((a * -1), -1, a));
                    mesh.Positions.Add(new Point3D(a, -1, (a * -1)));
                    mesh.Positions.Add(new Point3D((a * -1), -1, (a * -1)));
                    botao1.Visibility = Visibility.Visible;
                    botao2.Visibility = Visibility.Visible;

                    mesh.Normals.Add(new Vector3D(0, 1, 0));
                    mesh.Normals.Add(new Vector3D(-1, 0, 1));
                    mesh.Normals.Add(new Vector3D(1, 0, 1));
                    mesh.Normals.Add(new Vector3D(-1, 0, -1));
                    mesh.Normals.Add(new Vector3D(1, 0, -1));

                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(3);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(3);
                    mesh.TriangleIndices.Add(4);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(4);
                    Alturaaoquadrado.Content = double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text);
                    RaioaoQuadrado.Content = (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text));
                    Res.Content = (double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text));
                    Res1.Content = Math.Sqrt(((double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text))));
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

        private void botao2_Click_1(object sender, RoutedEventArgs e)
        {
            Grade1.Visibility = Visibility.Visible;
            botao2.Visibility = Visibility.Hidden;
            Grade_Geratriz.Visibility = Visibility.Hidden;
            raio.Text = (double.Parse(Raio_Calculo_Geratriz.Text)).ToString();
            Geratriz.Text = (Math.Sqrt(((double.Parse(Altura_Calculo_Geratriz.Text) * double.Parse(Altura_Calculo_Geratriz.Text)) + (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Raio_Calculo_Geratriz.Text))))).ToString();
        }

        private void botao2_Click(object sender, RoutedEventArgs e)
        {
            raiovezesgeratriz.Content = double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Geratriz.Text);
            quatrovezesraioegeratriz.Content = (double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Geratriz.Text)) * 4;
            res_AL.Content = ((double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Geratriz.Text)) * 4) / 2;
            botao3.Visibility = Visibility.Hidden;
            DemontrarAreaTotal.Visibility = Visibility.Visible;
            
        }

        private void DemontrarAreaTotal_Click(object sender, RoutedEventArgs e)
        {
            AL_AT.Text = (((double.Parse(Raio_Calculo_Geratriz.Text) * double.Parse(Geratriz.Text)) * 4) / 2).ToString();
            lado.Text =((double.Parse(Raio_Calculo_Geratriz.Text))*2).ToString();
            lado1.Text = ((double.Parse(Raio_Calculo_Geratriz.Text))*2).ToString();
            DemontrarAreaTotal.Visibility = Visibility.Hidden;
            AreaTotal.Visibility = Visibility.Visible;
            Grade1.Visibility = Visibility.Hidden;
        }

        private void botaoAT_Click(object sender, RoutedEventArgs e)
        {
            ladovezeslado.Content = double.Parse(lado.Text) * double.Parse(lado1.Text);
            AL.Content = double.Parse(AL_AT.Text);
            Res_AT.Content = (double.Parse(lado.Text) * double.Parse(lado1.Text)) + double.Parse(AL_AT.Text);

        }
    }
}
