using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;


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

            input_ISBN.Visibility = System.Windows.Visibility.Hidden;
            input_Titre_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Theme_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_pages_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Format_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Prenom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Editeur.Visibility = System.Windows.Visibility.Hidden;
            input_Annee_edition.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_vente.Visibility = System.Windows.Visibility.Hidden;
            input_Langue_livre.Visibility = System.Windows.Visibility.Hidden;
            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            l6.Visibility = System.Windows.Visibility.Hidden;
            l7.Visibility = System.Windows.Visibility.Hidden;
            l8.Visibility = System.Windows.Visibility.Hidden;
            l9.Visibility = System.Windows.Visibility.Hidden;
            l10.Visibility = System.Windows.Visibility.Hidden;
            l11.Visibility = System.Windows.Visibility.Hidden;
            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            AfficherAll();

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


                string request = "SELECT * FROM livres WHERE livres.Editeur LIKE '%" + recherche.Text + "%'";
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
                
            }
        }

        private void Lister_Click_Auteur(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


                string request = "SELECT * FROM livres WHERE livres.Nom_auteur LIKE '%" + recherche.Text + "%'";
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
                
            }
        }

        private void Lister_Click_Titre(object sender, RoutedEventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                
                string request = "SELECT * FROM livres WHERE livres.Titre_livre LIKE '%"+recherche.Text+"%'";
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
                
            }
            
        }

        private void Ajouter_un_Livre(object sender, RoutedEventArgs e)
        {
            Lister_Click_All(sender, e);

            input_ISBN.Visibility = System.Windows.Visibility.Visible;
            input_Titre_livre.Visibility = System.Windows.Visibility.Visible;
            input_Theme_livre.Visibility = System.Windows.Visibility.Visible;
            input_Nbr_pages_livre.Visibility = System.Windows.Visibility.Visible;
            input_Format_livre.Visibility = System.Windows.Visibility.Visible;
            input_Nom_auteur.Visibility = System.Windows.Visibility.Visible;
            input_Prenom_auteur.Visibility = System.Windows.Visibility.Visible;
            input_Editeur.Visibility = System.Windows.Visibility.Visible;
            input_Annee_edition.Visibility = System.Windows.Visibility.Visible;
            input_Prix_vente.Visibility = System.Windows.Visibility.Visible;
            input_Langue_livre.Visibility = System.Windows.Visibility.Visible;

            l1.Visibility = System.Windows.Visibility.Visible;
            l2.Visibility = System.Windows.Visibility.Visible;
            l3.Visibility = System.Windows.Visibility.Visible;
            l4.Visibility = System.Windows.Visibility.Visible;
            l5.Visibility = System.Windows.Visibility.Visible;
            l6.Visibility = System.Windows.Visibility.Visible;
            l7.Visibility = System.Windows.Visibility.Visible;
            l8.Visibility = System.Windows.Visibility.Visible;
            l9.Visibility = System.Windows.Visibility.Visible;
            l10.Visibility = System.Windows.Visibility.Visible;
            l11.Visibility = System.Windows.Visibility.Visible;

            Annuler.Visibility = System.Windows.Visibility.Visible;
            Ajouter.Visibility = System.Windows.Visibility.Visible;
        }

        private void Supprimer_un_Livre(object sender, RoutedEventArgs e)
        {
            
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                

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
                
            }
            InputBox.Visibility = System.Windows.Visibility.Visible;

        }

        private void Lister_Click_All(object sender, RoutedEventArgs e)
        {
            AfficherAll();
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
                    

                    // Clear InputBox.
                    InputTextBox.Text = String.Empty;

                    Lister_Click_All(sender, e);
                }
        }
            
        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
          
            // NoButton Clicked! Let's hide our InputBox.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Clear InputBox.
            InputTextBox.Text = String.Empty;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            string ISBN = input_ISBN.Text;
            string Titre_livre = input_Titre_livre.Text;
            string Theme_livre = input_Theme_livre.Text;
            int Nbr_pages_livre = int.Parse(input_Nbr_pages_livre.Text); 
            string Format_livre = input_Format_livre.Text;
            string Nom_auteur = input_Nom_auteur.Text;
            string Prenom_auteur = input_Prenom_auteur.Text;
            string Editeur = input_Editeur.Text;
            int Annee_edition = int.Parse(input_Annee_edition.Text);
            double Prix_vente = 20;
            string Langue_livre = input_Langue_livre.Text;

            Lister_Click_All(sender, e);
            string connectionString = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO livres(ISBN, Titre_livre, Theme_livre, Nbr_pages_livre, Format_livre, Nom_auteur, Prenom_auteur, Editeur, Annee_edition, Prix_vente, Langue_livre) VALUES(@ISBN, @Titre_livre, @Theme_livre, @Nbr_pages_livre, @Format_livre, @Nom_auteur, @Prenom_auteur, @Editeur, @Annee_edition, @Prix_vente, @Langue_livre)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Titre_livre", Titre_livre);
                cmd.Parameters.AddWithValue("@Theme_livre", Theme_livre);
                cmd.Parameters.AddWithValue("@Nbr_pages_livre", Nbr_pages_livre);
                cmd.Parameters.AddWithValue("@Format_livre", Format_livre);
                cmd.Parameters.AddWithValue("@Nom_auteur", Nom_auteur);
                cmd.Parameters.AddWithValue("@Prenom_auteur", Prenom_auteur);
                cmd.Parameters.AddWithValue("@Editeur", Editeur);
                cmd.Parameters.AddWithValue("@Annee_edition", Annee_edition);
                cmd.Parameters.AddWithValue("@Prix_vente", Prix_vente);
                cmd.Parameters.AddWithValue("@Langue_livre", Langue_livre);
                cmd.ExecuteNonQuery();
                Lister_Click_All(sender, e);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            input_ISBN.Visibility = System.Windows.Visibility.Hidden;
            input_Titre_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Theme_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_pages_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Format_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Prenom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Editeur.Visibility = System.Windows.Visibility.Hidden;
            input_Annee_edition.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_vente.Visibility = System.Windows.Visibility.Hidden;
            input_Langue_livre.Visibility = System.Windows.Visibility.Hidden;

            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            l6.Visibility = System.Windows.Visibility.Hidden;
            l7.Visibility = System.Windows.Visibility.Hidden;
            l8.Visibility = System.Windows.Visibility.Hidden;
            l9.Visibility = System.Windows.Visibility.Hidden;
            l10.Visibility = System.Windows.Visibility.Hidden;
            l11.Visibility = System.Windows.Visibility.Hidden;

            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            input_ISBN.Clear();
            input_Titre_livre.Clear();
            input_Theme_livre.Clear();
            input_Nbr_pages_livre.Clear();
            input_Format_livre.Clear();
            input_Nom_auteur.Clear();
            input_Prenom_auteur.Clear();
            input_Editeur.Clear();
            input_Annee_edition.Clear();
            input_Prix_vente.Clear();
            input_Langue_livre.Clear();

            MessageBox.Show("Le livre '" + Titre_livre + "' a été ajouté !");
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            input_ISBN.Clear();
            input_Titre_livre.Clear();
            input_Theme_livre.Clear();
            input_Nbr_pages_livre.Clear();
            input_Format_livre.Clear();
            input_Nom_auteur.Clear();
            input_Prenom_auteur.Clear();
            input_Editeur.Clear();
            input_Annee_edition.Clear();
            input_Prix_vente.Clear();
            input_Langue_livre.Clear();

            input_ISBN.Visibility = System.Windows.Visibility.Hidden;
            input_Titre_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Theme_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_pages_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Format_livre.Visibility = System.Windows.Visibility.Hidden;
            input_Nom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Prenom_auteur.Visibility = System.Windows.Visibility.Hidden;
            input_Editeur.Visibility = System.Windows.Visibility.Hidden;
            input_Annee_edition.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_vente.Visibility = System.Windows.Visibility.Hidden;
            input_Langue_livre.Visibility = System.Windows.Visibility.Hidden;

            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            l6.Visibility = System.Windows.Visibility.Hidden;
            l7.Visibility = System.Windows.Visibility.Hidden;
            l8.Visibility = System.Windows.Visibility.Hidden;
            l9.Visibility = System.Windows.Visibility.Hidden;
            l10.Visibility = System.Windows.Visibility.Hidden;
            l11.Visibility = System.Windows.Visibility.Hidden;

            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;
        }

        private void recherche_TextChanged(object sender, TextChangedEventArgs e)
        {
            AfficherAll();
        }

        private void AfficherAll()
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


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

            }
        }
    }
}
