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
    /// Interaction logic for PiramideAreaLateral.xaml
    /// </summary>
    public partial class Triangulo_Area : UserControl
    {
        public Triangulo_Area()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double a;
                double b;
                b = (double.Parse(altura.Text)) - ((double.Parse(altura.Text)) * 0.5);
                a = (double.Parse(_base.Text)) - ((double.Parse(_base.Text)) * 0.5); ;
                mesh.Positions.Clear();

                mesh.Positions.Add(new Point3D(b * -1, 0, 0));
                mesh.Positions.Add(new Point3D(1, a, 0));
                mesh.Positions.Add(new Point3D(a, 0, 0));
                mesh.Positions.Add(new Point3D(0, 0, 0));
                mesh.Positions.Add(new Point3D(0, 0, 0));

                mesh.Normals.Add(new Vector3D(0, 1, 0));
                mesh.Normals.Add(new Vector3D(-1, 0, 1));
                mesh.Normals.Add(new Vector3D(1, 0, 1));
                mesh.Normals.Add(new Vector3D(-1, 0, -1));
                mesh.Normals.Add(new Vector3D(1, 0, -1));
                res.Content = double.Parse(_base.Text) * double.Parse(altura.Text);
                res_Copy.Content = (double.Parse(_base.Text) * double.Parse(altura.Text)) / 2;
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
