using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            BemVindo bemVindo = new BemVindo();

            var userLogin = this.txbLogin.Text;

            if (userLogin != "Vanderlei")
            {
                MessageBox.Show("Login inválido!");
                return;
            }

            bemVindo.Show();
            this.Close();
        }

        private void btnCadastreSe_Click(object sender, RoutedEventArgs e)
        {
            CadastreSe cadastreSe = new CadastreSe();
            cadastreSe.Show();
        }
    }
}
