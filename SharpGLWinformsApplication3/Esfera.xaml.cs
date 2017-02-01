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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            
                    EsferaObjeto.Radius = double.Parse(Raio.Text);
                    double primeiraparte;
                    primeiraparte = (double.Parse(Raio.Text) * double.Parse(Raio.Text) * double.Parse(Raio.Text)) * 3.14;
                    label1.Content = (primeiraparte);
                    label2.Content = (primeiraparte * 4);
                    label3.Content = (primeiraparte / 3);
              
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
