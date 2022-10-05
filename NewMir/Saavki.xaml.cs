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

namespace NewMir
{
    /// <summary>
    /// Логика взаимодействия для Saavki.xaml
    /// </summary>
    public partial class Saavki : Page
    {
        public Saavki()
        {
            InitializeComponent();
            var db = new BloggingContext();
            List<Talon> talons = db.Talons.ToList();
            List_of_Saavki.ItemsSource = talons;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            danie.indez_zaavki = List_of_Saavki.SelectedIndex;
            MessageBox.Show(danie.indez_zaavki.ToString());
            Window5 j = new Window5();
            j.Show();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();

            List<Talon> talons = db.Talons.ToList();
            db.Talons.Remove(talons[List_of_Saavki.SelectedIndex]);
            db.SaveChanges();

        }
    }
}
