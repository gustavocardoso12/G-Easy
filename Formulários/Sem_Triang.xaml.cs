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
    /// Interaction logic for Sem_Triang.xaml
    /// </summary>
    public partial class Sem_Triang : UserControl
    {
        public Sem_Triang()
        {
            InitializeComponent();
            grade1_Copy.Visibility = Visibility.Hidden;
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grade1_Copy.Visibility = Visibility.Visible;
            
           
            try
            {
                double a = double.Parse(pro.Text);
                
                
                    ScaleTransform scaleTransform1 = new ScaleTransform(-1 - (((double.Parse(pro.Text))) / 600), (1.2 + ((double.Parse(pro.Text))) / 600), 0,0 );
                    triangulo1.RenderTransform = scaleTransform1;
                }
               
          
            catch (Exception ex)
            {
               Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }
    }
}
