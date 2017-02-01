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
    /// Interaction logic for Diagonal_caixa.xaml
    /// </summary>
    public partial class Diagonal_caixa : UserControl
    {
        public Diagonal_caixa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                    Caixa.Width = double.Parse(profundidade.Text.Replace(".",","));
                    Caixa.Length = double.Parse(largura.Text);
                    Caixa.Height = double.Parse(comprimento.Text);

                    comprimentoaoquadrado.Content = double.Parse(comprimento.Text) * double.Parse(comprimento.Text);
                    larguraaoquadrado.Content = double.Parse(largura.Text) * double.Parse(largura.Text);
                    profundidadeaoquadrado.Content = double.Parse(profundidade.Text) * double.Parse(profundidade.Text);
                    res.Content = (double.Parse(comprimento.Text) * double.Parse(comprimento.Text)) + (double.Parse(largura.Text) * double.Parse(largura.Text)) + (double.Parse(profundidade.Text) * double.Parse(profundidade.Text));
               
                }
            catch (Exception ex) {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
                    
}



        }
    }
}
