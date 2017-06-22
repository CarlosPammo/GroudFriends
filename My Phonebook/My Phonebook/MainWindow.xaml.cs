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

namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Controller.Crud n = new Controller.Crud();
            this.DGContacts.DataContext = ds;
            this.DGContacts.DataContext=""
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            Contact cont = new Contact();
            MainWindow mi = new MainWindow();
            mi.Hide();
            cont.Show();
        }
    }
}
