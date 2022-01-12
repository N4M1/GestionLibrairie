using System.Windows;

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
            livres.IsEnabled = false;
            fournisseurs.IsEnabled = true;
            commandes.IsEnabled = true;

            View.MyUsers.UserLivres userLivres = new View.MyUsers.UserLivres();
            grContent.Children.Clear();
            grContent.Children.Add(userLivres);
        }

        private void Fournisseur_Click(object sender, RoutedEventArgs e)
        {
            livres.IsEnabled = true;
            fournisseurs.IsEnabled = false;
            commandes.IsEnabled = true;

            View.MyUsers.UserFournisseurs userFournisseurs = new View.MyUsers.UserFournisseurs();
            grContent.Children.Clear();
            grContent.Children.Add(userFournisseurs);
        }

        private void Commandes_Click(object sender, RoutedEventArgs e)
        {
            livres.IsEnabled = true;
            fournisseurs.IsEnabled = true;
            commandes.IsEnabled = false;

            View.MyUsers.UserCommandes userCommandes = new View.MyUsers.UserCommandes();
            grContent.Children.Clear();
            grContent.Children.Add(userCommandes);
        }
    }
}
