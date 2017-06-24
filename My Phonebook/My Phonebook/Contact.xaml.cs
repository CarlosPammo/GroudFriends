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
using Modelo;
namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para Contact.xaml
    /// </summary>
    public partial class Contact : Window
    {
        private Contacts contacto { get; set; }

        public delegate void GetContact(Contacts contacto);
        public event GetContact OnAccept;
       
        public Contact()
        {
            InitializeComponent();
            contacto = new Contacts();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        // Contacts contacto = new Contacts();
         contacto.Name = txtName.Text;
         contacto.Address = TxtAddress.Text;
         contacto.Detalle = txtDetails.Text;
         contacto.Num_movile = txtMovile.Text;
         contacto.Num_work = txtWork.Text;
         contacto.Num_staff= txtStaff.Text;
         contacto.Num_office = txtoffice.Text;
         contacto.Num_other = txtOther.Text;
         contacto.Email_work = txtEmailWork.Text;
         contacto.Email_home = txtEmailHome.Text;
         contacto.Email_other = txtEmailOther.Text;
         contacto.groud = BoxtGrupo.Text;
         OnAccept(contacto);
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public Contact(Contacts contactos)
            : this()
		{
            txtName.Text = contactos.Name;
            TxtAddress.Text = contactos.Address;
            txtDetails.Text = contactos.Detalle;
            txtMovile.Text = contactos.Num_movile;
            txtWork.Text = contactos.Num_work;
            txtoffice.Text = contactos.Num_office;
            txtOther.Text = contactos.Num_other;
            txtEmailWork.Text = contactos.Email_work;
            txtEmailHome.Text = contactos.Email_home;
            txtEmailOther.Text = contactos.Email_other;
            BoxtGrupo.Text = contactos.groud;
            txtStaff.Text = contactos.Num_staff;
            contacto = contactos;
		}

        private void txtMovile_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
