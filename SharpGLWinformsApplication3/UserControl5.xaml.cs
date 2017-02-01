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
    /// Interaction logic for UserControl5.xaml
    /// </summary>
    public partial class UserControl5 : UserControl
    {
        
        public UserControl5()
        {
            InitializeComponent();
          
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           

           
          
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
             

                double a;
                double b;
                b = (double.Parse(Altura.Text)) - ((double.Parse(Altura.Text)) * 0.8);
                a = (double.Parse(LB.Text)) - ((double.Parse(LB.Text)) * 0.8); ;
                mesh.Positions.Clear();
                mesh.Positions.Add(new Point3D(0, b, -1));
                mesh.Positions.Add(new Point3D(a, -1, a));
                mesh.Positions.Add(new Point3D((a * -1), -1, a));
                mesh.Positions.Add(new Point3D(a, -1, (a * -1)));
                mesh.Positions.Add(new Point3D((a * -1), -1, (a * -1)));

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
                Basevezesbase.Content = (double.Parse(LB.Text) * double.Parse(LB1.Text));
                Altura1.Content = Altura.Text;
                penultimo.Content = ((double.Parse(LB.Text)) * double.Parse(LB1.Text)) * double.Parse(Altura.Text);
                RES.Content = (((double.Parse(LB.Text)) * double.Parse(LB1.Text)) * double.Parse(Altura.Text)) / 3;
            
             
                
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
