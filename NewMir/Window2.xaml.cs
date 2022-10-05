using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    
    public class Get_USer
    {
        public List<User> User_get { get; set; }
    }

    public partial class Window2 : Page
    {
        bool gaf;
        
        public Window2()
        {
            InitializeComponent();
            
            BloggingContext db = new BloggingContext();
            var AllData = db.Users.ToList();
            AllData.Insert(0, new User
            {
                data = "Всё"
            });
            for(int i = 0; i < AllData.Count; i++)
            {
                for(int j=i+1; j < AllData.Count; j++)
                {
                    if (AllData[i].data == AllData[j].data)
                    {
                        AllData.RemoveAt(j);
                    }
                }
            }
            ComboType.ItemsSource = AllData;
            CheckActual.IsChecked = false;
            ComboType.SelectedIndex = 0;
            List<User> users = db.Users.ToList();
            List_of_Users.ItemsSource = users;

        }
        private void Update_Users_List()
        {
            BloggingContext db = new BloggingContext();
            var currentUser= db.Users.ToList();
           
            if (ComboType.SelectedIndex > 0)
            {
                
                
                List<User> gaf = new List<User>();
                gaf.Add((User)ComboType.SelectedItem);
                currentUser = currentUser.Where(p => p.data.Contains(gaf[0].data as string)).ToList();
                
            }
            currentUser = currentUser.Where(p => p.login.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            if (CheckActual.IsChecked.Value)
            {
                currentUser = currentUser.Where(p => p.prava_dostypa).ToList();
            }
            List_of_Users.ItemsSource = currentUser.OrderBy(p => p.fio).ToList();
        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var db = new BloggingContext();
        //    List<User> users = db.Users.ToList();
        //    List<User> profile_user=new List<User>();
        //    foreach (var user in users)
        //    {
        //        if (user.login == Indentificate.jaj)
        //        {
        //            profile_user.Add(user);
        //        }
        //    }
        //    List_of_Users.ItemsSource = profile_user;

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add_all a = new Add_all();
            a.Show();
            
        }

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    var db = new BloggingContext();
        //    if (gaf)
        //    {
        //        List<Talon> talons = db.Talons.ToList();
        //        List_of_Users.ItemsSource = talons;
        //    }
        //    else
        //    {
        //        List<User> users = db.Users.ToList();
        //        List_of_Users.ItemsSource = users;
        //    }   
        //}
        public void nyshno(Data data)
        {
            var db = new BloggingContext();
            List<User> users = db.Users.ToList();
            if(data.Reg_login != "")
            {
                users[Data.index].login = data.Reg_login;
            }
            if (data.Reg_password != "")
            {
                users[Data.index].password = data.Reg_password;
            }
            if (data.Reg_Email != "")
            {
                users[Data.index].email = data.Reg_Email;
            }
            if (data.Reg_Name != "")
            {
                users[Data.index].name = data.Reg_Name;
            }
            if (data.Reg_Fio != "")
            {
                users[Data.index].fio = data.Reg_Fio;
            }
            if (data.Reg_Otchestvo != "")
            {
                users[Data.index].otchestvo = data.Reg_Otchestvo;
            }
            if (data.Reg_Data != "")
            {
                users[Data.index].data = data.Reg_Data;
            }
            db.SaveChanges();
            
        }
        public void izm_talon(danie izm_danie)
        {
            var db = new BloggingContext();
            List<Talon> talons = db.Talons.ToList();
            int i = danie.indez_zaavki;
            MessageBox.Show(i.ToString());
            //db.Good_Talons.Add(new Good_Talon { name = talons[i].name, fio = talons[i].fio, otchestvo = talons[i].otchestvo, vrach = talons[i].vrach, data = talons[i].data, time = talons[i].time, number_kabinet = izm_danie.Create_number_kabinet, name_hospital = izm_danie.Create_name_hospital });
            db.Talons.Remove(talons[i]);
            db.SaveChanges();
            MessageBox.Show("Талон одобрен");
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
 
                Data.index = List_of_Users.SelectedIndex;

            //MessageBox.Show(List_of_Users.SelectedIndex.ToString());
            //Window1 h = new Window1();
            //h.Button_Zareg.Content = "Изменить";
            //h.Show();
            if (List_of_Users.SelectedItem != null)
            {
                List<User> gaf = new List<User>();
                gaf.Add((User)List_of_Users.SelectedItem);
                MessageBox.Show(gaf[0].login);
            }
           

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
           
                List<User> users = db.Users.ToList();
                db.Users.Remove(users[List_of_Users.SelectedIndex]);
                db.SaveChanges();     
        }

        //private void Button_Click_5(object sender, RoutedEventArgs e)
        //{
        //    var db = new BloggingContext();
        //    List<Talon> talons = db.Talons.ToList();
        //    List_of_Users.ItemsSource = talons;
        //    gaf = true;
        //}

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            List<User> users = db.Users.ToList();
            List_of_Users.ItemsSource = users;
            gaf = false;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            //Hide();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            List<User> users = db.Users.ToList();
            int i= List_of_Users.SelectedIndex;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("Твое мыло");
            mail.To.Add(new MailAddress(users[i].email));
            mail.Subject = "Export";
            mail.Body = "Database export from application";
            Attachment attachment = new Attachment(@"Database Export.xlsx");
            mail.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("Твое мыло", "Твой пароль");
            client.Send(mail);
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ListView dg = List_of_Users;
            dg.SelectAll();
            ApplicationCommands.Copy.Execute(null, dg);
            String result = (string)Clipboard.GetData(DataFormats.Text);
            try
            {
                StreamWriter sw = new StreamWriter("export.doc");
                sw.WriteLine(result);
                sw.Close();
                Process.Start("export.doc");
            }
            catch (Exception ex) { }
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_Users_List();
        }

        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {
            Update_Users_List();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_Users_List();
        }

    }
    
}
