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
    /// Logique d'interaction pour frmController.xaml
    /// </summary>
    public partial class frmController : Window
    {
        edfEntities gst;
        public frmController()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstClient.ItemsSource = gst.client.ToList();
        }

        private void lstClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void InsererReleve_Click(object sender, RoutedEventArgs e)
        {
            var Releve = Convert.ToInt16(txtNewReleve.Text);
            gst.client
            if (Releve<)
            {

            }
        }
    }
}
