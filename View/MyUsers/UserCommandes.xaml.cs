using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

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

            input_Id_Livre.Visibility = System.Windows.Visibility.Hidden;
            input_Id_Fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Date_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_exemplaires.Visibility = System.Windows.Visibility.Hidden;

            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            AfficherAll();
        }

        //Affichage de toutes les commandes
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
                

                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {

                    Models.Commander commande= new Models.Commander();

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
                
            }
        }

        //Affichage des éditeurs
        private void Lister_Click_Editeur(object sender, RoutedEventArgs e)
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

                string request = "SELECT * FROM commander INNER JOIN livres ON livres.Id_Livre = commander.Id_Livre WHERE livres.Editeur LIKE '%"+recherche.Text+"%'";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {
                    Models.Commander commande = new Models.Commander();

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

            }
        }

        //Affichage des fournisseurs
        private void Lister_Click_Fournisseur(object sender, RoutedEventArgs e)
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

                string request = "SELECT * FROM commander INNER JOIN fournisseurs ON fournisseurs.Id_fournisseur = commander.Id_fournisseur WHERE fournisseurs.Raison_sociale LIKE '%" + recherche.Text + "%'";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {
                    Models.Commander commande = new Models.Commander();

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

            }
        }

        //Affichage des dates
        private void Lister_Click_Date(object sender, RoutedEventArgs e)
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

                string request = "SELECT Date_achat FROM commander WHERE commander.Date_achat LIKE '%" + recherche.Text + "%'";
                
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {
                    Models.Commander commande = new Models.Commander();

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

            }
        }

        //Ajout d'une commande
        private void Ajouter_une_Commande(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = false;
            b6.IsEnabled = true;
            Lister_Click_All(sender, e);

            input_Id_Livre.Visibility = System.Windows.Visibility.Visible;
            input_Id_Fournisseur.Visibility = System.Windows.Visibility.Visible;
            input_Date_achat.Visibility = System.Windows.Visibility.Visible;
            input_Prix_achat.Visibility = System.Windows.Visibility.Visible;
            input_Nbr_exemplaires.Visibility = System.Windows.Visibility.Visible;

            l1.Visibility = System.Windows.Visibility.Visible;
            l2.Visibility = System.Windows.Visibility.Visible;
            l3.Visibility = System.Windows.Visibility.Visible;
            l4.Visibility = System.Windows.Visibility.Visible;
            l5.Visibility = System.Windows.Visibility.Visible;

            Annuler.Visibility = System.Windows.Visibility.Visible;
            Ajouter.Visibility = System.Windows.Visibility.Visible;
        }

        //Supression d'une commande
        private void Supprimer_une_Commande(object sender, RoutedEventArgs e)
        {
            recherche.IsEnabled = false;
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();
                

                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Models.Commander commande = new Models.Commander();

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
                recherche.IsEnabled = true;
            }
            finally
            {
                connexion.Close();
                
            }
            recherche.IsEnabled = true;
            InputBox.Visibility = System.Windows.Visibility.Visible;
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
                

                // Clear InputBox.
                InputTextBox.Text = String.Empty;

                connexion.Open();
                string request = "SELECT * FROM `commander`";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["Titre_livre"].ToString());

                    Models.Commander commande = new Models.Commander();

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

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            input_Id_Livre.Visibility = System.Windows.Visibility.Hidden;
            input_Id_Fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Date_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_exemplaires.Visibility = System.Windows.Visibility.Hidden;

            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            input_Id_Livre.Clear();
            input_Id_Fournisseur.Clear();
            input_Date_achat.Clear();
            input_Prix_achat.Clear();
            input_Nbr_exemplaires.Clear();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            input_Id_Livre.Visibility = System.Windows.Visibility.Hidden;
            input_Id_Fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Date_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_exemplaires.Visibility = System.Windows.Visibility.Hidden;

            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;

            int Id_Livre;
            try
            {
                Id_Livre = int.Parse(input_Id_Fournisseur.Text);
            }
            catch (Exception ex)
            {
                Id_Livre = 0;
            }

            int Id_fournisseur;
            try
            {
                Id_fournisseur = int.Parse(input_Id_Fournisseur.Text);
            }
            catch (Exception ex)
            {
                Id_fournisseur = 0;
            }
            string Date_achat = "2020-02-17 18:45:47";
            double Prix_achat = 17.0;
            int Nbr_exemplaires;
            try
            {
                Nbr_exemplaires = int.Parse(input_Id_Fournisseur.Text);
            }
            catch (Exception ex)
            {
                Nbr_exemplaires = 0;
            }

            Lister_Click_All(sender, e);
            string connectionString = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO commander(Id_Livre, Id_fournisseur, Date_achat, Prix_achat, Nbr_exemplaires) VALUES(@Id_Livre, @Id_fournisseur, @Date_achat, @Prix_achat, @Nbr_exemplaires)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Id_Livre", Id_Livre);
                cmd.Parameters.AddWithValue("@Id_fournisseur", Id_fournisseur);
                cmd.Parameters.AddWithValue("@Date_achat", Date_achat);
                cmd.Parameters.AddWithValue("@Prix_achat", Prix_achat);
                cmd.Parameters.AddWithValue("@Nbr_exemplaires", Nbr_exemplaires);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La commande avec le fournisseur '" + Id_fournisseur + "' a été ajoutée !");
                Lister_Click_All(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Les IDs sont incorrects !");
                Ajouter_une_Commande(sender, e);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            input_Id_Livre.Visibility = System.Windows.Visibility.Hidden;
            input_Id_Fournisseur.Visibility = System.Windows.Visibility.Hidden;
            input_Date_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Prix_achat.Visibility = System.Windows.Visibility.Hidden;
            input_Nbr_exemplaires.Visibility = System.Windows.Visibility.Hidden;
            
            l1.Visibility = System.Windows.Visibility.Hidden;
            l2.Visibility = System.Windows.Visibility.Hidden;
            l3.Visibility = System.Windows.Visibility.Hidden;
            l4.Visibility = System.Windows.Visibility.Hidden;
            l5.Visibility = System.Windows.Visibility.Hidden;
            

            Annuler.Visibility = System.Windows.Visibility.Hidden;
            Ajouter.Visibility = System.Windows.Visibility.Hidden;


            input_Id_Livre.Clear();
            input_Id_Fournisseur.Clear();
            input_Date_achat.Clear();
            input_Prix_achat.Clear();
            input_Nbr_exemplaires.Clear(); 
        }

        private void AfficherAll()
        {
            String cs = @"server=localhost;userid=root;password=;database=gestionlibrairie";

            MySqlConnection connexion = new MySqlConnection(cs);

            try
            {
                connexion.Open();


                string request = "SELECT * FROM commander INNER JOIN livres ON livres.Id_Livre = commander.Id_Livre";
                MySqlCommand sql = new MySqlCommand(request, connexion);
                MySqlDataReader rdr = sql.ExecuteReader();

                List<Models.Commander> listeCommandes = new List<Models.Commander>();
                List<Models.Livre> listeLivres = new List<Models.Livre>();

                while (rdr.Read())
                {
                    Models.Commander commande = new Models.Commander();

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

            }
        }

        //Barre de recherche
        private void recherche_TextChanged(object sender, TextChangedEventArgs e)
        {
            AfficherAll();
        }
    }
}
