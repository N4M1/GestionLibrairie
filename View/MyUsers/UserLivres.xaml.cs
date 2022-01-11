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
    /// Logique d'interaction pour UserLivres.xaml
    /// </summary>
    public partial class UserLivres : UserControl
    {
        
        public UserLivres()
        {
            InitializeComponent();
            dgLivres.Items.Clear();
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
        public class commander
        {
            public int Id_commande { get; set; }
            public int Id_Livre { get; set; }
            public int Id_fournisseur { get; set; }
            public DateTime Date_achat { get; set; }
            public float Prix_achat { get; set; }
            public int Nbr_exemplaire { get; set; }
        }

        //Fournisseurs
        public class fournisseurs
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


        //Livres
        private void Lister_Click_Editeur(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM `livres` ORDER BY `livres`.`Editeur` ASC";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listelivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listelivres.Add(livre);
                }
                dgLivres.ItemsSource = listelivres;
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

        private void Lister_Click_Auteur(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM `livres` ORDER BY `livres`.`Nom_auteur` ASC";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listelivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listelivres.Add(livre);
                }
                dgLivres.ItemsSource = listelivres;
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

        private void Lister_Click_Titre(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM `livres` ORDER BY `livres`.`Titre_livre` ASC";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listelivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listelivres.Add(livre);
                }
                dgLivres.ItemsSource = listelivres;
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

        private void Ajouter_un_Livre(object sender, RoutedEventArgs e)
        {

        }

        private void Supprimer_un_Livre(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM livres";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listelivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listelivres.Add(livre);
                }
                dgLivres.ItemsSource = listelivres;
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

        private void Lister_Click_All(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                MessageBox.Show("Vous êtes co !");

                string request = "SELECT * FROM livres";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listelivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listelivres.Add(livre);
                }
                dgLivres.ItemsSource = listelivres;
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
                string request = "DELETE FROM livres WHERE Id_Livre=" + input;
                Console.WriteLine(request);

                MySqlCommand sql = new MySqlCommand(request, connexion);
                sql.ExecuteNonQuery();
                MessageBox.Show("Le livre à l'id  '" + input + "' à été supprimé");
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
                string request = "SELECT * FROM `livres`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Livre> listeLivres = new List<Livre>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Livre livre = new Livre();

                    livre.Id_Livre = rdr.GetInt32("Id_Livre");
                    livre.ISBN = rdr.GetString("ISBN");
                    livre.Titre_livre = rdr.GetString("Titre_livre");
                    livre.Theme_livre = rdr.GetString("Theme_livre");
                    livre.Nbr_pages_livre = rdr.GetInt32("Nbr_pages_livre");
                    livre.Format_livre = rdr.GetString("Format_livre");
                    livre.Nom_auteur = rdr.GetString("Nom_auteur");
                    livre.Prenom_auteur = rdr.GetString("Prenom_auteur");
                    livre.Editeur = rdr.GetString("Editeur");
                    livre.Annee_edition = rdr.GetInt32("Annee_edition");
                    livre.Prix_vente = rdr.GetFloat("Prix_vente");
                    livre.Langue_livre = rdr.GetString("Langue_livre");

                    listeLivres.Add(livre);
                }
                dgLivres.ItemsSource = listeLivres;
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
