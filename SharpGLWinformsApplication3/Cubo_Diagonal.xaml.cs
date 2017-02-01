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
    /// Interaction logic for Cubo_Diagonal.xaml
    /// </summary>
    public partial class Cubo_Diagonal : UserControl
    {
        public Cubo_Diagonal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double aresta;
                aresta = double.Parse(Aresta.Text);

                    camera.CameraController.CameraUpDirection = new Vector3D(-0.622, 0.023, 0.783);
                    camera.CameraController.CameraPosition = new Point3D(-11.935 + aresta, 0.443, 2.675);

                    camera.CameraController.CameraLookDirection = new Vector3D(11.935 + aresta, -0.443, -2.675);
                    camera.CameraController.CameraTarget = new Point3D(0 + (aresta / 100), 0 + (aresta / 100), 0 + (aresta / 100));
                    Resultado.Content = aresta * 1.41;
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
