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
    /// Interaction logic for cubo.xaml
    /// </summary>
    public partial class cubo : UserControl
    {
        public cubo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((Prof.Text == Altura.Text) && (Altura.Text == Largura.Text))
            {
                try
                {

                        cubo1.SideLength = double.Parse(Prof.Text);
                        res.Content = (double.Parse(Prof.Text) * double.Parse(Altura.Text) * double.Parse(Largura.Text));
                   
                }
                catch (Exception ex)
                {
                    Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                    M.Show();
                }
            }
            else
            {
                Dimensoes_Iguais DI = new Dimensoes_Iguais();
                DI.Show();

            }
 
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
