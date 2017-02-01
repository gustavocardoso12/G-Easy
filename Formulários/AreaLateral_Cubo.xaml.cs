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
    /// Interaction logic for AreaLateral_Cubo.xaml
    /// </summary>
    public partial class AreaLateral_Cubo : UserControl
    {
        public AreaLateral_Cubo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double aresta;
                aresta = double.Parse(Aresta.Text);
                    cubo.SideLength = aresta;
                    Resultado1.Content = (aresta * aresta) * 6;
            }
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }
    }
}
