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
using System.Xml.Serialization;

using System.Xml;
using System.Xml.Linq;
using System.Data;
using Modelo;


using System.IO;
namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int a=0;
        public List<Contacts> Contactoss { get; set; }
      
        public MainWindow()
        {
           InitializeComponent();
           Init();
          
        }

        public void Init()
        {
            string myfilr = "Contact.xml";
            //El unico cambio que hace es fileMode.Open  esto pemite obtener todos los datos del archivo
            FileStream fs = new FileStream(myfilr, FileMode.Open);
            XmlSerializer Xser = new XmlSerializer(typeof(List<Contacts>));

            Contactoss = (List<Contacts>)Xser.Deserialize(fs);
            fs.Close();

            DGContacts.DataContext = Contactoss;
            DGContacts.Items.Refresh();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
           // Contact cont = new Contact();
            MainWindow mi = new MainWindow();
            mi.Hide();
            //cont.Show();
            Contact editor = new Contact();
            editor.OnAccept += AddNewCoctact;
            editor.Show();
        }
        private void AddNewCoctact(Contacts contacto)
        {
            Contactoss.Add(contacto);
            DGContacts.DataContext = Contactoss;
            DGContacts.Items.Refresh();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Contacts selected = (Contacts)DGContacts.SelectedItem;
            Contact editor = new Contact(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }

        private void EditContact(Contacts contact)
        {
            DGContacts.Items.Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Contacts selected = (Contacts)DGContacts.SelectedItem;
            Contactoss.Remove(selected);
            DGContacts.Items.Refresh();
        }

        private void Save(object sender, EventArgs e)
        {
            XmlSerializer xser = new XmlSerializer(typeof(List<Contacts>));
            string myfilr = "Contact.xml";

            FileStream fs = new FileStream(myfilr, FileMode.Create);
            xser.Serialize(fs, Contactoss);

            fs.Close();
            MessageBox.Show("Guardado");
        }

        private void buscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //aver si asi da algo
            //lo que hace es verificar si son letras o numeros
            //ahi dice si es diferente de un numero
            var Filtrar=(from x in Contactoss
                       select x).ToList();
            if (buscar.Text != "")
            {
                if (!char.IsDigit(buscar.Text[0]))
                {

                    Filtrar = (from x in Contactoss
                               where ((x.Name != null) && (x.Name.StartsWith(buscar.Text)))
                               select x).ToList();
                    DGContacts.DataContext = Filtrar;
                }
                else
                {
                    Filtrar = (from x in Contactoss
                               where ((x.Num_movile != null) && (x.Num_movile.StartsWith(buscar.Text)))
                               select x).ToList();
                }
            }
            

            DGContacts.DataContext = Filtrar;
        }

        private void DGContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                               where ((x.Group != null) && (x.Group=="movil"))
                               select x).ToList();
            DGContacts.DataContext = Filtrar;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                           where ((x.Group != null) && (x.Group == "trabajo"))
                           select x).ToList();
            DGContacts.DataContext = Filtrar;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                           where ((x.Group != null) && (x.Group == "casa"))
                           select x).ToList();
            DGContacts.DataContext = Filtrar;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                           where ((x.Group != null) && (x.Group == "nuevo"))
                           select x).ToList();
            DGContacts.DataContext = Filtrar;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                           where ((x.Group != null) && (x.Group == "oficina"))
                           select x).ToList();
            DGContacts.DataContext = Filtrar;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //Lo qque hace es filtrar por Grupo
            var Filtrar = (from x in Contactoss
                           where ((x.Group != null) && (x.Group == "Otros"))
                           select x).ToList();
            DGContacts.DataContext = Filtrar;
        }


   

       
       


    }
}
