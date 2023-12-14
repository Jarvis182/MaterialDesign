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

namespace MaterialDesign
{
    /// <summary>
    /// Logique d'interaction pour PageReservations.xaml
    /// </summary>
    public partial class PageReservations : Page
    {
        public PageReservations()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBG.Text = "Nouvelle réservation de " + NomTextBox.Text + " - " + PrenomTextBox.Text + " - " + TelephoneTextBox.Text;
        }
    }
}
