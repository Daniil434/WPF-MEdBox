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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewMir
{
    /// <summary>
    /// Логика взаимодействия для Doctors_menu.xaml
    /// </summary>
    public partial class Doctors_menu : Page
    {
        public Doctors_menu()
        {
            InitializeComponent();
            BloggingContext db = new BloggingContext();
            var AllData_spechialnost = db.Vrachs.ToList();
            var AllData_grahic_vrach = db.Vrachs.ToList();
            var AllData_grahic_hospital = db.Vrachs.ToList();
            AllData_spechialnost.Insert(0, new Vrach
            {
                spechialnost = "Всё"
            });
            AllData_grahic_vrach.Insert(0, new Vrach
            {
                Grahic_vrach = "Всё"
            });
            AllData_grahic_hospital.Insert(0, new Vrach
            {
                name_hospital = "Всё"
            });
            for (int i = 0; i < AllData_spechialnost.Count; i++)
            {
                for (int j = i + 1; j < AllData_spechialnost.Count; j++)
                {
                    if (AllData_spechialnost[i].spechialnost == AllData_spechialnost[j].spechialnost)
                    {
                        AllData_spechialnost.RemoveAt(j);
                    }
                }
            }
            for (int i = 0; i < AllData_grahic_vrach.Count; i++)
            {
                for (int j = i + 1; j < AllData_grahic_vrach.Count; j++)
                {
                    if (AllData_grahic_vrach[i].Grahic_vrach == AllData_grahic_vrach[j].Grahic_vrach)
                    {
                        AllData_grahic_vrach.RemoveAt(j);
                    }
                }
            }
            for (int i = 0; i < AllData_grahic_hospital.Count; i++)
            {
                for (int j = i + 1; j < AllData_grahic_hospital.Count; j++)
                {
                    if (AllData_grahic_hospital[i].name_hospital == AllData_grahic_hospital[j].name_hospital)
                    {
                        AllData_grahic_hospital.RemoveAt(j);
                    }
                }
            }
            ComboType_cpechialnoct.ItemsSource = AllData_spechialnost;

            ComboType_cpechialnoct.SelectedIndex = 0;
            ComboType_grahic_vrach.ItemsSource = AllData_grahic_vrach;

            ComboType_grahic_vrach.SelectedIndex = 0;
            ComboType_hospital.ItemsSource = AllData_grahic_hospital;

            ComboType_hospital.SelectedIndex = 0;
            List<Vrach> vraches = db.Vrachs.ToList();
            List_of_vrach.ItemsSource = vraches;
        }
        private void Update_Users_List()
        {
            BloggingContext db = new BloggingContext();
            var currentUser = db.Vrachs.ToList();

            if (ComboType_cpechialnoct.SelectedIndex > 0)
            {


                List<Vrach> gaf = new List<Vrach>();
                gaf.Add((Vrach)ComboType_cpechialnoct.SelectedItem);
                currentUser = currentUser.Where(p => p.spechialnost.Contains(gaf[0].spechialnost as string)).ToList();

            }
            if (ComboType_grahic_vrach.SelectedIndex > 0)
            {


                List<Vrach> gaf = new List<Vrach>();
                gaf.Add((Vrach)ComboType_grahic_vrach.SelectedItem);
                currentUser = currentUser.Where(p => p.Grahic_vrach.Contains(gaf[0].Grahic_vrach as string)).ToList();

            }
            if (ComboType_hospital.SelectedIndex > 0)
            {


                List<Vrach> gaf = new List<Vrach>();
                gaf.Add((Vrach)ComboType_hospital.SelectedItem);
                currentUser = currentUser.Where(p => p.name_hospital.Contains(gaf[0].name_hospital as string)).ToList();

            }
            currentUser = currentUser.Where(p => p.fio.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            List_of_vrach.ItemsSource = currentUser.OrderBy(p => p.fio).ToList();
        }
        private void ComboType_SelectionChanged_cpechialnoct(object sender, SelectionChangedEventArgs e)
        {
            Update_Users_List();
        }
        private void ComboType_SelectionChanged_grahic_vrach(object sender, SelectionChangedEventArgs e)
        {
            Update_Users_List();
        }
        private void ComboType_SelectionChanged_hospital(object sender, SelectionChangedEventArgs e)
        {
            Update_Users_List();
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_Users_List();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();

            List<Vrach> vraches = db.Vrachs.ToList();
            db.Vrachs.Remove(vraches[List_of_vrach.SelectedIndex]);
            db.SaveChanges();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add_all a = new Add_all();
            a.Show();

        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var db = new BloggingContext();
            List<User> users = db.Users.ToList();
            int i = List_of_vrach.SelectedIndex;
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
            ListView dg = List_of_vrach;
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
    }
}
