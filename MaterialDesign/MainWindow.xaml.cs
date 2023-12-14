using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new Recettes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new PageRecettes();
        }

        private void Button_RESERVATIONS_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new PageReservations();
        }

    }
}