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
    /// Логика взаимодействия для Hospitals_menu.xaml
    /// </summary>
    public partial class Hospitals_menu : Page
    {
        public Hospitals_menu()
        {
            InitializeComponent();
            BloggingContext db = new BloggingContext();
            var AllData = db.Hospitals.ToList();
            AllData.Insert(0, new Hospital
            {
                all_vrach = "Всё"
            });
            for (int i = 0; i < AllData.Count; i++)
            {
                for (int j = i + 1; j < AllData.Count; j++)
                {
                    if (AllData[i].all_vrach == AllData[j].all_vrach)
                    {
                        AllData.RemoveAt(j);
                    }
                }
            }
            ComboType.ItemsSource = AllData;
            
            ComboType.SelectedIndex = 0;
            List<Hospital> hospitals = db.Hospitals.ToList();
            List_of_Hospital.ItemsSource = hospitals;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_all a = new Add_all();
            a.Show();
        }

        private void Update_Hospital_List()
        {
            BloggingContext db = new BloggingContext();
            var currentHospital = db.Hospitals.ToList();
            var currentHospital2= db.Hospitals.ToList();
            if (ComboType.SelectedIndex > 0)
            {


                List<Hospital> gaf = new List<Hospital>();
                gaf.Add((Hospital)ComboType.SelectedItem);
                currentHospital = currentHospital.Where(p => p.all_vrach.Contains(gaf[0].all_vrach as string)).ToList();

            }
            currentHospital = currentHospital.Where(p => p.name.ToLower().Contains(TBoxSearch_name.Text.ToLower())).ToList();
            currentHospital = currentHospital.Where(p => p.adres.ToLower().Contains(TBoxSearch_adres.Text.ToLower())).ToList();
            List_of_Hospital.ItemsSource = currentHospital.OrderBy(p => p.name).ToList();
        }
        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_Hospital_List();
        }

        private void TBoxSearch_TextChanged_name(object sender, TextChangedEventArgs e)
        {
            Update_Hospital_List();
        }
        private void TBoxSearch_TextChanged_adres(object sender, TextChangedEventArgs e)
        {
            Update_Hospital_List();
        }
    }
}
