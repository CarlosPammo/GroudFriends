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
namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int a=0;
        public List<Contacts> Contactoss { get; set; }
        //DataSet ds = new DataSet("Table");
       // XmlSerializer XMLC = new XmlSerializer(typeof(Contact));
       //Contact datos = (Contact)XmlConvert.Deserialize(xml);
        public MainWindow()
        {
           InitializeComponent();
           Init();
           /* var file = @"Contact.xml";
            ds.ReadXml(file);
            DGContacts.DataContext = ds.Tables[0].DefaultView;*/
            
        }

        public void Init()
        {
            Contactoss = new List<Contacts>
				           {
							   new Contacts
								   {
										Name = "Carlos",
										Address = "Por aqui",
                                        Detalle = "cuajskd",
                                        Num_movile= "558525",
                                        Num_work="555555",
                                        Num_office="8566",
                                        Num_staff="526",
                                        Num_other="1236546",
                                        Email_work="gfsgffgdc",
                                        Email_home="hgbchgchg",
                                        Email_other="hgcchgdfhg",
                                        groud="trabajo"
								   },
								   
				           };

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


   

       
       


    }
}
