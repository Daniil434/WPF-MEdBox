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
using System.Text.RegularExpressions;

namespace NewMir
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Indentificate
    {
        public string login;
        public string password;
        public string Email;
        public string Name;
        public string Fio;
        public string Otchestvo;
        public string Data;
        public static int index;
        public static string jaj;
        public void gaf(int index_Izm)
        {
            index = index_Izm;
        }
        public Indentificate(string Reg_login, string Reg_password, string Reg_Email, string Reg_Name, string Reg_Fio, string Reg_Otchestvo, string Reg_Data)
        {
            this.login = Reg_login;
            this.password = Reg_password;
            this.Email = Reg_Email;
            this.Name = Reg_Name;
            this.Fio = Reg_Fio;
            this.Otchestvo = Reg_Otchestvo;
            this.Data = Reg_Data;
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loading_icon fsf = new Loading_icon();
            fsf.Show();
            this.Hide();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            //a.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Avt_login = textBox_Avt_login.Text.Trim();
            string Avt_password = passBox_Avt_password.Password.Trim();
            Regex regyl_login = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            bool pravda = true;
            if (!regyl_login.IsMatch(Avt_login))
            {
                textBox_Avt_login.ToolTip = "Не корректное значение";
                textBox_Avt_login.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Avt_login.ToolTip = "";
                textBox_Avt_login.Foreground = Brushes.Black;
            }
            if (Avt_password =="")
            {
                passBox_Avt_password.ToolTip = "Не корректное значение";
                passBox_Avt_password.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                passBox_Avt_password.ToolTip = "";
                passBox_Avt_password.Foreground = Brushes.Black;
            }
            if (pravda)
            {
                using (var db = new BloggingContext())
                {
                    List<User> users = db.Users.ToList();
                    bool proverka = true;
                    foreach (var user in users)
                    {
                        string str_proverka = user.login;
                        if (user.prava_dostypa)
                        {
                            string str_proverka_parol = user.password;
                            if(str_proverka_parol == Avt_password)
                            {
                                Indentificate indentificate = new Indentificate(user.login, user.password, user.email, user.name, user.fio, user.otchestvo, user.data);
                                Indentificate.jaj = user.login;
                                Admin_menu b = new Admin_menu();
                                
                                b.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            
                            string str_proverka_parol = user.password;
                            if (str_proverka_parol == Avt_password && Avt_login == user.login)
                            {
                                Indentificate.jaj = user.login;
                                Indentificate indentificate = new Indentificate(user.login, user.password, user.email, user.name, user.fio, user.otchestvo, user.data);
                                Window4 l = new Window4();
                                Buffer.login = user.login;
                                l.Name_User.Text = "Добро пожаловать " + str_proverka;
                                l.Show();
                                Hide();
                            }
                        }
                            
                        
                    }
                    if (proverka)
                    {
                        textBox_Avt_login.ToolTip = "Неверный логин или пароль";
                        textBox_Avt_login.Foreground = Brushes.Red;
                        passBox_Avt_password.ToolTip = "Неверный логин или пароль";
                        passBox_Avt_password.Foreground = Brushes.Red;
                    }
                    
                    
                }
            }
        }
    }
}
