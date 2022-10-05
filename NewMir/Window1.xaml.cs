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
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;

namespace NewMir
{
    public class Data
    {
        public string Reg_login;
        public string Reg_password;
        public string Reg_Email;
        public string Reg_Name;
        public string Reg_Fio;
        public string Reg_Otchestvo;
        public string Reg_Data;
        public static int index;
        public void gaf(int index_Izm) 
        {
            index = index_Izm;
        }
        public Data(string Reg_login, string Reg_password, string Reg_Email, string Reg_Name, string Reg_Fio, string Reg_Otchestvo, string Reg_Data)
        {
            this.Reg_login = Reg_login;
            this.Reg_password = Reg_password;
            this.Reg_Email = Reg_Email;
            this.Reg_Name = Reg_Name;
            this.Reg_Fio = Reg_Fio;
            this.Reg_Otchestvo = Reg_Otchestvo;
            this.Reg_Data = Reg_Data;
        }
    }
    public enum Regyl
    {
        a=1,
        b=3
    }
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Page
    {
        
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regyl_Data = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
            Regex regyl_Email = new Regex(@"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$");
            //Regex regyl_password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$");
            Regex regyl_login = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            Regex regyl_FIO = new Regex(@"^[a-zA-Z][a-zA-Z-_\.]{1,15}$");
            string Reg_login = textBox_Reg_login.Text.Trim();
            string Reg_password = passBox_Reg_password.Password.Trim();
            string Reg_password_2 = passBox_Reg_password_2.Password.Trim();
            string Reg_Email = textBox_Reg_Email.Text.Trim();
            string Reg_Name = textBox_Reg_Name.Text.Trim();
            string Reg_Fio = textBox_Reg_Fio.Text.Trim();
            string Reg_Otchestvo = textBox_Reg_Otchestvo.Text.Trim();
            string Reg_Data = textBox_Reg_Data.Text.Trim();
            bool pravda = true;
            if (!regyl_Data.IsMatch(Reg_Data))
            {
                textBox_Reg_Data.ToolTip = "Не корректное значение:День.Месяц.Год";
                textBox_Reg_Data.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Reg_Data.ToolTip = "";
                textBox_Reg_Data.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(Reg_Otchestvo))
            {
                textBox_Reg_Otchestvo.ToolTip = "Не корректное значение";
                textBox_Reg_Otchestvo.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Reg_Otchestvo.ToolTip = "";
                textBox_Reg_Otchestvo.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(Reg_Fio))
            {
                textBox_Reg_Fio.ToolTip = "Не корректное значение";
                textBox_Reg_Fio.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Reg_Fio.ToolTip = "";
                textBox_Reg_Fio.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(Reg_Name))
            {
                textBox_Reg_Name.ToolTip = "Не корректное значение";
                textBox_Reg_Name.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Reg_Name.ToolTip = "";
                textBox_Reg_Name.Foreground = Brushes.Black;
            }
            if (!regyl_login.IsMatch(Reg_login))
            {
                textBox_Reg_login.ToolTip = "Не корректное значение";
                textBox_Reg_login.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Reg_login.ToolTip = "";
                textBox_Reg_login.Foreground = Brushes.Black;
            }
            if (Reg_password =="")
            {
                passBox_Reg_password.ToolTip = "Не корректное значение";
                passBox_Reg_password.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                passBox_Reg_password.ToolTip = "";
                passBox_Reg_password.Foreground = Brushes.Black;
            }
            if (Reg_password != Reg_password_2)
            {
                passBox_Reg_password_2.ToolTip = "Пароли не совпадают";
                passBox_Reg_password_2.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                passBox_Reg_password_2.ToolTip = "";
                passBox_Reg_password_2.Foreground = Brushes.Black;
            }
            if (!regyl_Email.IsMatch(Reg_Email))
            {
                textBox_Reg_Email.ToolTip = "Не корректное значение:/.../@/..././...";
                textBox_Reg_Email.Foreground = Brushes.Red; ;
                pravda = false;
            }
            else
            {
                textBox_Reg_Email.ToolTip = "";
                textBox_Reg_Email.Foreground = Brushes.Black;
            }


            if ((string)Button_Zareg.Content == "Изменить")
            {
                Window2 j = new Window2();
                MessageBox.Show("Good");
                Data data = new Data(Reg_login, Reg_password, Reg_Email, Reg_Name, Reg_Fio, Reg_Otchestvo, Reg_Data);
                //Hide();
                j.nyshno(data);
            }

            if (pravda)
            {
                using (var db = new BloggingContext())
                {
                    // Note: This sample requires the database to be created before running.
                    //MessageBox.Show($"Database path: Users.db.");
                    // Create
                    List<User> users = db.Users.ToList();
                    int f=users.Count+1;
                    SaveFileDialog save = new SaveFileDialog();
                    //{
                    //    Filter = "JPG Files (" + f + ".jpg)|" + f + ".jpg"
                    //};

                    JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                        jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(Image_Create_Menu.Source as BitmapSource));
                        save.FileName = "C:\\Users\\User\\Desktop\\PRG\\NewMir\\NewMir\\User_Photo\\"+f+".jpg";
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            jpegBitmapEncoder.Save(fileStream);
                    
                    db.Users.Add(new User { login = Reg_login, password = Reg_password, email = Reg_Email, data = Reg_Data, fio = Reg_Fio, name = Reg_Name, otchestvo = Reg_Otchestvo,img=save.FileName });

                    db.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно");
                    
                    foreach (var user in users)
                    {
                        if(user.login== Reg_login)
                        {
                            Indentificate indentificate = new Indentificate(user.login, user.password, user.email, user.name, user.fio, user.otchestvo, user.data);
                            Window4 l = new Window4();
                            
                            Buffer.login = user.login;
                            l.Name_User.Text = "Добро пожаловать " + Reg_login;
                            l.Show();
                            //Hide();
                        }
                    }
                    
                    
                }
            }

        }

        private void Button_Vixod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            //Hide();
        }
        private void Click_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                Image_Create_Menu.Source = new BitmapImage(new Uri(openDialog.FileName));
                
            }
        }
    }
}
