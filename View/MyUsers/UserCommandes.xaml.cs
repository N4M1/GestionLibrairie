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

using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Windows;

namespace GestionMVVM.View.MyUsers
{
    /// <summary>
    /// Logique d'interaction pour UserCommandes.xaml
    /// </summary>
    public partial class UserCommandes : UserControl
    {
        public UserCommandes()
        {
            InitializeComponent();
            dgCommandes.Items.Clear();
        }

        private void Lister_Click_All(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Commander> listeCommandes = new List<Commander>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Commander commande= new Commander();

                    commande.Id_commande = rdr.GetInt32("Id_commande");
                    commande.Id_Livre = rdr.GetInt32("Id_Livre");
                    commande.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    commande.Date_achat = rdr.GetDateTime("Date_achat");
                    commande.Prix_achat = rdr.GetDecimal("Prix_achat");
                    commande.Nbr_exemplaires = rdr.GetInt32("Nbr_exemplaires");
                    ;

                    listeCommandes.Add(commande);
                }
                dgCommandes.ItemsSource = listeCommandes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
                MessageBox.Show("Au revoir !");
            }
        }

        private void Lister_Click_Editeur(object sender, RoutedEventArgs e)
        {

        }

        private void Lister_Click_Fournisseur(object sender, RoutedEventArgs e)
        {

        }

        private void Lister_Click_Date(object sender, RoutedEventArgs e)
        {

        }

        private void Ajouter_une_Commande(object sender, RoutedEventArgs e)
        {

        }

        private void Supprimer_une_Commande(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Commander> listeCommandes = new List<Commander>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Commander commande = new Commander();

                    commande.Id_commande = rdr.GetInt32("Id_commande");
                    commande.Id_Livre = rdr.GetInt32("Id_Livre");
                    commande.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    commande.Date_achat = rdr.GetDateTime("Date_achat");
                    commande.Prix_achat = rdr.GetDecimal("Prix_achat");
                    commande.Nbr_exemplaires = rdr.GetInt32("Nbr_exemplaires");

                    listeCommandes.Add(commande);
                }
                dgCommandes.ItemsSource = listeCommandes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connexion.Close();
                MessageBox.Show("Au revoir !");
            }

            InputBox.Visibility = System.Windows.Visibility.Visible;
        }

        //Livre
        public class Livre
        {
            public int Id_Livre { get; set; }
            public string ISBN { get; set; }
            public string Titre_livre { get; set; }
            public string Theme_livre { get; set; }
            public int Nbr_pages_livre { get; set; }
            public string Format_livre { get; set; }
            public string Nom_auteur { get; set; }
            public string Prenom_auteur { get; set; }
            public string Editeur { get; set; }
            public int Annee_edition { get; set; }
            public float Prix_vente { get; set; }
            public string Langue_livre { get; set; }
        }

        //Commander
        public class Commander
        {
            public int Id_commande { get; set; }
            public int Id_Livre { get; set; }
            public int Id_fournisseur { get; set; }
            public DateTime Date_achat { get; set; }
            public decimal Prix_achat { get; set; }
            public int Nbr_exemplaires { get; set; }
        }

        //Fournisseurs
        public class Fournisseurs
        {
            public int Id_fournisseur { get; set; }
            public string Code_fournisseur { get; set; }
            public string Raison_sociale { get; set; }
            public string Rue_fournisseur { get; set; }
            public string Code_postal { get; set; }
            public string Localite { get; set; }
            public string Pays { get; set; }
            public string Tel_fournisseur { get; set; }
            public string Url_fournisseur { get; set; }
            public string Email_fournisseur { get; set; }
            public string Fax_fournisseur { get; set; }
        }

        //Input Box Delete 
        private void CoolButton_Click(object sender, RoutedEventArgs e)
        {
            // CoolButton Clicked! Let's show our InputBox.
            InputBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // YesButton Clicked! Let's hide our InputBox and handle the input text.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Do something with the Input
            String input = InputTextBox.Text;

            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";
            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                string request = "DELETE FROM commander WHERE Id_commande=" + input;
                Console.WriteLine(request);

                MySqlCommand sql = new MySqlCommand(request, connexion);
                sql.ExecuteNonQuery();
                MessageBox.Show("La commande à l'id  '" + input + "' à été supprimée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                InputTextBox.Text = String.Empty;
                YesButton_Click(sender, e);
            }
            finally
            {
                connexion.Close();
                MessageBox.Show("Au revoir !");

                // Clear InputBox.
                InputTextBox.Text = String.Empty;

                connexion.Open();
                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Commander> listeCommandes = new List<Commander>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Commander commande = new Commander();

                    commande.Id_commande = rdr.GetInt32("Id_commande");
                    commande.Id_Livre = rdr.GetInt32("Id_Livre");
                    commande.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    commande.Date_achat = rdr.GetDateTime("Date_achat");
                    commande.Prix_achat = rdr.GetDecimal("Prix_achat");
                    commande.Nbr_exemplaires = rdr.GetInt32("Nbr_exemplaires");

                    listeCommandes.Add(commande);
                }
                dgCommandes.ItemsSource = listeCommandes;
            }
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            // NoButton Clicked! Let's hide our InputBox.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Clear InputBox.
            InputTextBox.Text = String.Empty;
        }

    }
}
