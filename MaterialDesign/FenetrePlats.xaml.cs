using Microsoft.VisualBasic;
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

namespace MaterialDesign
{
    /// <summary>
    /// Logique d'interaction pour FenetrePlats.xaml
    /// </summary>
    public partial class FenetrePlats : Window
    {
        public FenetrePlats()
        {
            InitializeComponent();
        }

        private void Button_PS5()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Commandez la PS5 Limited Edtion 2023");
        }
    }
}
