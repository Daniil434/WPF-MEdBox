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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        bool raw;
        bool raw_story;
        public Window4()
        {
            InitializeComponent();
            BloggingContext db = new BloggingContext();
            List<Talon> talons = db.Talons.ToList();
            List_of_Talons.ItemsSource = talons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 a = new Window3();
            a.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            if (raw)
            {
                List<Good_Talon> good_Talons = db.Good_Talons.ToList();
                List_of_Talons.ItemsSource = good_Talons;
            }
            else if (raw_story)
            {
                List<Story> stories = db.Stores.ToList();
                List_of_Talons.ItemsSource = stories;
            }
            else
            {
                List<Talon> talons = db.Talons.ToList();
                List_of_Talons.ItemsSource = talons;
            }
                
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            
                List<Story> stories = db.Stores.ToList();
                List_of_Talons.ItemsSource = stories;
            raw_story = true;
            raw = false;
            
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            if (raw)
            {
                List<Good_Talon> good_Talons = db.Good_Talons.ToList();
                int i = List_of_Talons.SelectedIndex;
                //db.Stores.Add(new Story { name = good_Talons[i].name, fio = good_Talons[i].fio, otchestvo = good_Talons[i].otchestvo, vrach = good_Talons[i].vrach, data = good_Talons[i].data, time = good_Talons[i].time, number_kabinet = good_Talons[i].number_kabinet, name_hospital = good_Talons[i].name_hospital });

                db.Good_Talons.Remove(good_Talons[i]);
                MessageBox.Show("Удалено");
            }
            else if (raw_story)
            {
                List<Story> stories = db.Stores.ToList();
                db.Stores.Remove(stories[List_of_Talons.SelectedIndex]);
            }
            else
            {
                List<Talon> talons = db.Talons.ToList();
                db.Talons.Remove(talons[List_of_Talons.SelectedIndex]);
            }
            db.SaveChanges();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hey");
            var db = new BloggingContext();
            List<Good_Talon> good_Talons = db.Good_Talons.ToList();
            List_of_Talons.ItemsSource = good_Talons;
            raw = true;
            raw_story = false;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            List<Talon> talons = db.Talons.ToList();
            List_of_Talons.ItemsSource = talons;
            raw = false;
            raw_story = false;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Hide();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            List<User> users = db.Users.ToList();
            List<User> profile_user = new List<User>();
            foreach (var user in users)
            {
                if (user.login == Indentificate.jaj)
                {
                    profile_user.Add(user);
                }
            }
            List_of_Talons.ItemsSource = profile_user;
        }
    }
}
