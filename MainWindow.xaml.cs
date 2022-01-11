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

namespace GestionMVVM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Livres_Click(object sender, RoutedEventArgs e)
        {
            View.MyUsers.UserLivres userLivres = new View.MyUsers.UserLivres();
            grContent.Children.Clear();
            grContent.Children.Add(userLivres);
        }

        private void Fournisseur_Click(object sender, RoutedEventArgs e)
        {
            View.MyUsers.UserFournisseurs userFournisseurs = new View.MyUsers.UserFournisseurs();
            grContent.Children.Clear();
            grContent.Children.Add(userFournisseurs);
        }

        private void Commandes_Click(object sender, RoutedEventArgs e)
        {
            View.MyUsers.UserCommandes userCommandes = new View.MyUsers.UserCommandes();
            grContent.Children.Clear();
            grContent.Children.Add(userCommandes);
        }



    }
}
