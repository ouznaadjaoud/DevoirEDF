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
using ProjetEDFWPF;

namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities edf;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             edf = new edfEntities();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (txtLogin.Text == "")
            {
                MessageBox.Show("saisir un Login");
            }
            else if (txtMdp.Text== "")
            {
                MessageBox.Show("saisir un mdp");
            }

            controleur lectrl = edf.controleur.ToList().Find(ctrl => ctrl.login == txtLogin.Text && ctrl.mdp == txtMdp.Text);
            else if (lectrl == null)
            {
                MessageBox.Show("le controleur n'existe pas");
            }
            else if (lectrl.statut == "ctrl")
            {
                frmController controller = new frmController();
                controller.Show();
            }
            else  (lectrl.statut == "admin")
            {
                frmAdmin admin = new frmAdmin();
                admin.Show();
            }
           
            

            
        }
    }
}
