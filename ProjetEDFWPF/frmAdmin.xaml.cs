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
using System.Windows.Shapes;


namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour frmAdmin.xaml
    /// </summary>
    public partial class frmAdmin : Window
    {
        edfEntities gst;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstController.ItemsSource = gst.controleur.ToList();
        }

        private void lstController_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lesClientsDuController = gst.client.ToList().FindAll(i => i.idcontroleur == (lstController.SelectedItem as controleur).id);
            lstClients.ItemsSource = lesClientsDuController;
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ajoutController_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")

            {
                MessageBox.Show("saisir un Nom");
            }
            else if (txtPr.Text =="")
            {
                MessageBox.Show("saisir un prenom");
            }
            else
            {
                controleur unNouveauControleur = new controleur();
                {
                    //int id =  ;
                    string nom = txtName.Text;
                    string prenom = txtPr.Text;
                    string login =txtName.Text.Substring(0,1) + txtPr.Text.Substring(0, 1);
                    string mdp = txtName.Text.Substring(0, 1)+txtPr.Text.Substring(0,1)+"123";
                   // string statut;

                };
                gst.controleur.Add(unNouveauControleur);
                gst.SaveChanges();

            }
        }
    }
}
