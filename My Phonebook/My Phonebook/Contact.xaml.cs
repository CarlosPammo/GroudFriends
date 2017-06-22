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
using Controller;
namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para Contact.xaml
    /// </summary>
    public partial class Contact : Window
    {
        private List<Contact> Contacts { get; set; }

        public bool accion;
        public Contact()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (accion == true)
            {
                //agregar(txtName.Text, TxtAddress.Text, txtDetails.Text);
            }
            else
            { }
        }
    }
}
