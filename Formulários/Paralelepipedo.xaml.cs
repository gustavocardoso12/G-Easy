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
using System.Windows.Media.Media3D;
namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            metodo();
        }
        public void metodo()
        {
          Point3D ponto = new Point3D();
          ponto.X = 4;
          ponto.Y = 3;
          ponto.Z = 3;
            MeshBuilder mesh = new MeshBuilder();
            mesh.AddPyramid(ponto, 3, 4);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                    double calculo;
                    Caixa.Height = double.Parse(Altura.Text);
                    Caixa.Width = double.Parse(Largura.Text);
                    Caixa.Length = double.Parse(Comprimento.Text);
                    calculo = (double.Parse(Comprimento.Text) * double.Parse(Altura.Text) * double.Parse(Largura.Text));
                    resultado.Content = (calculo );
                    if ((Comprimento.Text == Altura.Text) && (Altura.Text == Largura.Text))
                    {
                        MSG21 M = new MSG21();
                        M.Show();

                    }
                
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
