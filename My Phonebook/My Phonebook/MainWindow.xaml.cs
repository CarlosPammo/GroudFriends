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
namespace My_Phonebook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet ds = new DataSet("Table");
       // XmlSerializer XMLC = new XmlSerializer(typeof(Contact));
       //Contact datos = (Contact)XmlConvert.Deserialize(xml);
        public MainWindow()
        {
           InitializeComponent();
            var file = @"Contact.xml";
            ds.ReadXml(file);
            DGContacts.DataContext = ds.Tables[0].DefaultView;
            
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            Contact cont = new Contact();
            MainWindow mi = new MainWindow();
            mi.Hide();
            cont.Show();
        }

        private void Consulta(object sender, KeyEventArgs e)
        {
          //  if (e.KeyboardDevice == "")
           // { }
        }


    }
}
