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
using System.Text.RegularExpressions;

namespace NewMir
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    
    public class Buffer
    {
        
        public static string login;
        public string password;
        public string Email;
        public string Name;
        public string Fio;
        public string Otchestvo;
        public string Data;
        public static int index;
        //public void copy(Indentificate n)
        //{
            
        //}
        
    }
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }


        private void Button_Zakaz_Click(object sender, RoutedEventArgs e)
        {
                Regex regyl_Data = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
                //Regex regyl_Email = new Regex(@"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$");
                //Regex regyl_password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$");
                Regex regyl_FIO = new Regex(@"^[a-zA-Z][a-zA-Z-_\.]{1,15}$");
                string Create_vrach = textBox_Create_vrach.Text.Trim();
                string Create_data = textBox_Create_data.Text.Trim();
                string Create_time = textBox_Create_time.Text.Trim();
                bool pravda = true;
                if (!regyl_Data.IsMatch(Create_data))
                {
                textBox_Create_data.ToolTip = "Не корректное значение:День.Месяц.Год";
                textBox_Create_data.Foreground = Brushes.Red;
                    pravda = false;
                }
                else
                {
                textBox_Create_data.ToolTip = "";
                textBox_Create_data.Foreground = Brushes.Black;
                }
                
                if (!regyl_FIO.IsMatch(Create_vrach))
                {
                textBox_Create_vrach.ToolTip = "Не корректное значение";
                textBox_Create_vrach.Foreground = Brushes.Red;
                    pravda = false;
                }
                else
                {
                textBox_Create_vrach.ToolTip = "";
                textBox_Create_vrach.Foreground = Brushes.Black;
                }
                
                if (Create_time.Length==6)
                {
                textBox_Create_time.ToolTip = "Не корректное значение:Часы:минуты";
                textBox_Create_time.Foreground = Brushes.Red; ;
                    pravda = false;
                }
                else
                {
                textBox_Create_time.ToolTip = "";
                textBox_Create_time.Foreground = Brushes.Black;
                }
            
            if (pravda)
            {
                using (var db = new BloggingContext())
                {
                    // Note: This sample requires the database to be created before running.
                    MessageBox.Show($"Database path: Users.db.");
                    MessageBox.Show(Buffer.login);
                    // Create
                    List<User> users = db.Users.ToList();
                    foreach (var user in users)
                    {
                        if (user.login == Buffer.login)
                        {
                            //db.Talons.Add(new Talon { name = user.name, fio = user.fio, otchestvo = user.otchestvo, vrach = Create_vrach, data = Create_data, time = Create_time });

                            db.SaveChanges();
                            MessageBox.Show("Заказ отправлен на модернизацию");
                            Hide();
                        }
                    }
                    

                    
                }
            }
            //if ((string)Button_Zareg.Content == "Изменить")
            //{
            //    Window2 j = new Window2();
            //    MessageBox.Show("Good");
            //    Data data = new Data(Reg_login, Reg_password, Reg_Email, Reg_Name, Reg_Fio, Reg_Otchestvo, Reg_Data);
            //    Hide();
            //    j.nyshno(data);
            //}




        }

        private void Button_Nazad_Click(object sender, RoutedEventArgs e)
        {
            Window4 b = new Window4();
            b.Show();
            Hide();
        }
    }
}
