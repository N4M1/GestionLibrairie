using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace GestionMVVM.View.MyUsers
{
    /// <summary>
    /// Logique d'interaction pour UserFournisseurs.xaml
    /// </summary>
    public partial class UserFournisseurs : UserControl
    {
        public UserFournisseurs()
        {
            InitializeComponent();
            dgFournisseurs.Items.Clear();

            input_Code_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Raison_sociale.Visibility = System.Windows.Visibility.Hidden;
            input_Rue_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Code_postal.Visibility = System.Windows.Visibility.Hidden;
            input_Localite.Visibility = System.Windows.Visibility.Hidden;
            input_Pays.Visibility = System.Windows.Visibility.Hidden;
            input_Tel_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Url_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Email_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Fax_fournisseur.Visibility = System.Windows.Visibility.Hidden;
           
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
        
            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            AfficherAll();
        }

        //Affichage de tous les fournisseurs
        private void Lister_Click_All(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;

            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                

                string request = "SELECT * FROM `fournisseurs`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");
             
                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;

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

        //Affichage des raisons sociales
        private void Lister_Click_Social(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = false;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;

            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();

                string request = "SELECT * FROM fournisseurs WHERE fournisseurs.Raison_sociale LIKE '%" + recherche.Text + "%'";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;

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

        //Affichage des localités
        private void Lister_Click_Localite(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = false;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;

            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


                string request = "SELECT * FROM fournisseurs WHERE fournisseurs.Localite LIKE '%" + recherche.Text + "%'";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;

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

        //Affichage des pays
        private void Lister_Click_Pays(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = false;
            b5.IsEnabled = true;
            b6.IsEnabled = true;

            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


                string request = "SELECT * FROM fournisseurs WHERE fournisseurs.Pays LIKE '%" + recherche.Text + "%'";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;

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

        //Ajout d'un fournisseur
        private void Ajouter_un_Fournisseur(object sender, RoutedEventArgs e)
        {
            Lister_Click_All(sender, e);

            input_Code_fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Raison_sociale.Visibility = System.Windows.Visibility.Visible;
            input_Rue_fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Code_postal.Visibility = System.Windows.Visibility.Visible;
            input_Localite.Visibility = System.Windows.Visibility.Visible;
            input_Pays.Visibility = System.Windows.Visibility.Visible;
            input_Tel_fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Url_fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Email_fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Fax_fournisseur.Visibility = System.Windows.Visibility.Visible;

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

            Annuler.Visibility = System.Windows.Visibility.Visible;
            Ajouter.Visibility = System.Windows.Visibility.Visible;
        }

        //Suppression d'un fournisseur
        private void Supprimer_un_Fournisseur(object sender, RoutedEventArgs e)
        {
            recherche.IsEnabled = false;
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                

                string request = "SELECT * FROM `fournisseurs`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                recherche.IsEnabled = true;
            }
            finally
            {
                connexion.Close();
                
            }
            recherche.IsEnabled = true;
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
        public class Fournisseur
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
                string request = "DELETE FROM fournisseurs WHERE Id_fournisseur=" + input;
                Console.WriteLine(request);
                
                MySqlCommand sql = new MySqlCommand(request, connexion);
                sql.ExecuteNonQuery();
                MessageBox.Show("Le fournisseur : '" + input + "' à été supprimé");
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

                connexion.Open();
                string request = "SELECT * FROM `fournisseurs`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;
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
            string Code_fournisseur = input_Code_fournisseur.Text;
            string Raison_sociale = input_Raison_sociale.Text;
            string Rue_fournisseur = input_Rue_fournisseur.Text;
            string Code_postal = input_Code_postal.Text;
            string Localite = input_Localite.Text;
            string Pays = input_Pays.Text;
            string Tel_fournisseur = input_Tel_fournisseur.Text;
            string Url_fournisseur = input_Url_fournisseur.Text;
            string Email_fournisseur = input_Email_fournisseur.Text;
            string Fax_fournisseur = input_Fax_fournisseur.Text;
            

            Lister_Click_All(sender, e);
            string connectionString = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO fournisseurs(Code_fournisseur, Raison_sociale, Rue_fournisseur, Code_postal, Localite, Pays, Tel_fournisseur, Url_fournisseur, Email_fournisseur, Fax_fournisseur) VALUES(@Code_fournisseur, @Raison_sociale, @Rue_fournisseur, @Code_postal, @Localite, @Pays, @Tel_fournisseur, @Url_fournisseur, @Email_fournisseur, @Fax_fournisseur)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Code_fournisseur", Code_fournisseur);
                cmd.Parameters.AddWithValue("@Raison_sociale", Raison_sociale);
                cmd.Parameters.AddWithValue("@Rue_fournisseur", Rue_fournisseur);
                cmd.Parameters.AddWithValue("@Code_postal", Code_postal);
                cmd.Parameters.AddWithValue("@Localite", Localite);
                cmd.Parameters.AddWithValue("@Pays", Pays);
                cmd.Parameters.AddWithValue("@Tel_fournisseur", Tel_fournisseur);
                cmd.Parameters.AddWithValue("@Url_fournisseur", Url_fournisseur);
                cmd.Parameters.AddWithValue("@Email_fournisseur", Email_fournisseur);
                cmd.Parameters.AddWithValue("@Fax_fournisseur", Fax_fournisseur);
                cmd.ExecuteNonQuery();
                Lister_Click_All(sender, e);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            input_Code_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Raison_sociale.Visibility = System.Windows.Visibility.Hidden;
            input_Rue_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Code_postal.Visibility = System.Windows.Visibility.Hidden;
            input_Localite.Visibility = System.Windows.Visibility.Hidden;
            input_Pays.Visibility = System.Windows.Visibility.Hidden;
            input_Tel_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Url_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Email_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Fax_fournisseur.Visibility = System.Windows.Visibility.Hidden;

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

            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            input_Code_fournisseur.Clear();
            input_Raison_sociale.Clear();
            input_Rue_fournisseur.Clear();
            input_Code_postal.Clear();
            input_Localite.Clear();
            input_Pays.Clear();
            input_Tel_fournisseur.Clear();
            input_Url_fournisseur.Clear();
            input_Email_fournisseur.Clear();
            input_Fax_fournisseur.Clear();

            MessageBox.Show("Le fournisseur '" + Raison_sociale + "' a été ajouté !");
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            input_Code_fournisseur.Clear();
            input_Raison_sociale.Clear();
            input_Rue_fournisseur.Clear();
            input_Code_postal.Clear();
            input_Localite.Clear();
            input_Pays.Clear();
            input_Tel_fournisseur.Clear();
            input_Url_fournisseur.Clear();
            input_Email_fournisseur.Clear();
            input_Fax_fournisseur.Clear();

            input_Code_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Raison_sociale.Visibility = System.Windows.Visibility.Hidden;
            input_Rue_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Code_postal.Visibility = System.Windows.Visibility.Hidden;
            input_Localite.Visibility = System.Windows.Visibility.Hidden;
            input_Pays.Visibility = System.Windows.Visibility.Hidden;
            input_Tel_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Url_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Email_fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Fax_fournisseur.Visibility = System.Windows.Visibility.Hidden;           

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

            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;
        }

        private void AfficherAll()
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


                string request = "SELECT * FROM `fournisseurs`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Fournisseur> listeFournisseurs = new List<Fournisseur>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Fournisseur fournisseur = new Fournisseur();

                    fournisseur.Id_fournisseur = rdr.GetInt32("Id_fournisseur");
                    fournisseur.Code_fournisseur = rdr.GetString("Code_fournisseur");
                    fournisseur.Raison_sociale = rdr.GetString("Raison_sociale");
                    fournisseur.Rue_fournisseur = rdr.GetString("Rue_fournisseur");
                    fournisseur.Code_postal = rdr.GetString("Code_postal");
                    fournisseur.Localite = rdr.GetString("Localite");
                    fournisseur.Pays = rdr.GetString("Pays");
                    fournisseur.Tel_fournisseur = rdr.GetString("Tel_fournisseur");
                    fournisseur.Url_fournisseur = rdr.GetString("Url_fournisseur");
                    fournisseur.Email_fournisseur = rdr.GetString("Email_fournisseur");
                    fournisseur.Fax_fournisseur = rdr.GetString("Fax_fournisseur");

                    listeFournisseurs.Add(fournisseur);
                }
                dgFournisseurs.ItemsSource = listeFournisseurs;

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

        //Barre de recherche
        private void recherche_TextChanged(object sender, TextChangedEventArgs e)
        {
            AfficherAll();
        }
    }
}
