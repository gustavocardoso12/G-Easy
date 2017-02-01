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
    /// Interaction logic for Paralelepipedo_Area.xaml
    /// </summary>
    public partial class Paralelepipedo_Area : UserControl
    {
        public Paralelepipedo_Area()
        {
            InitializeComponent();
            gradeAT.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
        
                    comprimento.Content = C.Text;
                    altura.Content = A.Text;
                    altura1.Content = A.Text;
                    largura.Content = L.Text;
                    largura1.Content = L.Text;
                    comprimento1.Content = C.Text;
                    gradeconfirmacao.Visibility = Visibility.Hidden;
                    gradeAT.Visibility = Visibility.Visible;
                    grade.Visibility = Visibility.Visible;
                    Caixa.Height = double.Parse(A.Text) - (double.Parse(A.Text) * 0.2);
                    Caixa.Width = double.Parse(L.Text) - (double.Parse(L.Text) * 0.2);
                    Caixa.Length = double.Parse(C.Text) - (double.Parse(C.Text) * 0.2);
                    if ((C.Text == A.Text) && (A.Text == L.Text))
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
         
            parte1.Content = 2 * double.Parse(C.Text) * double.Parse(L.Text);
            parte2.Content = 2 * double.Parse(C.Text) * double.Parse(A.Text);
            parte3.Content = 2 * double.Parse(L.Text) * double.Parse(A.Text);
            res.Content = (2 * double.Parse(C.Text) * double.Parse(L.Text)) + (2 * double.Parse(C.Text) * double.Parse(A.Text)) + (2 * double.Parse(L.Text) * double.Parse(A.Text));
        }
    }
}
