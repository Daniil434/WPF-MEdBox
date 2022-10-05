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

namespace NewMir
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public class danie
    {
        public static int indez_zaavki;
        public int Create_number_kabinet;
        public string Create_name_hospital;
    }
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Zakaz_Click(object sender, RoutedEventArgs e)
        {
            danie izm_danie = new danie();
            izm_danie.Create_number_kabinet=int.Parse(textBox_Create_number_kabinet.Text.Trim());
            izm_danie.Create_name_hospital = textBox_Create_name_hospital.Text.Trim();
            Window2 f = new Window2();
            f.izm_talon(izm_danie);
            Hide();
        }

        private void Button_Nazad_Click(object sender, RoutedEventArgs e)
        {
            Window2 b = new Window2();
            //b.Show();
            Hide();
        }
    }
}
