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
using HelixToolkit;
using HelixToolkit.Wpf;
namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for Prisma.xaml
    /// </summary>

    public partial class Prisma : UserControl
    {

        public Prisma()
        {
            InitializeComponent();
            gradesetor.Visibility = Visibility.Hidden;

            
        }

        private void botaoAT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                    double b;
                    b = (double.Parse(Altura.Text)) - ((double.Parse(Altura.Text)) * 0.8);




                    mesh.Positions.Clear();
                    mesh.Positions.Add(new Point3D(1.000000, 0.000000, 2 + b));
                    mesh.Positions.Add(new Point3D(-0.499998, 0.866026, 2 + b));
                    mesh.Positions.Add(new Point3D(-0.500003, -0.866024, 2 + b));
                    mesh.Positions.Add(new Point3D(1.00, -0.10000, 2 + b));
                    mesh.Positions.Add(new Point3D(1.0000, 0.000, 0.000000));
                    mesh.Positions.Add(new Point3D(-0.199998, 0.866026, 0.000000));
                    mesh.Positions.Add(new Point3D(-0.5, -0.866024, 0.00));
                    mesh.Positions.Add(new Point3D(0, 0.7, 0));



                    mesh.Normals.Add(new Vector3D(1.570796, -0.000002, 1.047197));
                    mesh.Normals.Add(new Vector3D(-0.785397, 1.360353, 1.047199));
                    mesh.Normals.Add(new Vector3D(-0.785400, -1.360346, 1.047196));
                    mesh.Normals.Add(new Vector3D(0.000000, 0.000000, 6.283185));
                    mesh.Normals.Add(new Vector3D(1.570796, -0.000002, -1.047197));
                    mesh.Normals.Add(new Vector3D(-0.785397, 1.360353, -1.047199));
                    mesh.Normals.Add(new Vector3D(-0.785400, -1.360346, -1.047196));
                    mesh.Normals.Add(new Vector3D(0.000000, 0.000000, -6.283185));


                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(4);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(7);
                    mesh.TriangleIndices.Add(6);
                    mesh.TriangleIndices.Add(6);
                    mesh.TriangleIndices.Add(4);
                    mesh.TriangleIndices.Add(3);
                    mesh.TriangleIndices.Add(6);
                    mesh.TriangleIndices.Add(4);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(3);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(6);
                    mesh.TriangleIndices.Add(1);
                    mesh.TriangleIndices.Add(3);
                    mesh.TriangleIndices.Add(7);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(6);
                    mesh.TriangleIndices.Add(2);
                    mesh.TriangleIndices.Add(0);
                    mesh.TriangleIndices.Add(4);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(7);
                    mesh.TriangleIndices.Add(5);
                    mesh.TriangleIndices.Add(1);
                    raiovezesalturabase.Content = double.Parse(raio.Text) * double.Parse(alt_base.Text);
                    alt_prisma.Content = double.Parse(Altura.Text);
                    Res.Content = (double.Parse(raio.Text) * double.Parse(alt_base.Text)) * double.Parse(Altura.Text);
               
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }

        private void botaoAT2_Click(object sender, RoutedEventArgs e)
        {
            raio.Text = texto.Text;
            alt_base.Text = texto.Text;
            gradeconfirmacao.Visibility = Visibility.Hidden;
            gradesetor.Visibility = Visibility.Visible;
        }


       
       
        }
    }

    

