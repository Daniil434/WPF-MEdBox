using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для add_vrach.xaml
    /// </summary>
    public partial class add_vrach : Page
    {
        public add_vrach()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regyl_Data = new Regex(@"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d-(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d");
            Regex regyl_Email = new Regex(@"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$");
            //Regex regyl_password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$");
            Regex regyl_login = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            Regex regyl_FIO = new Regex(@"^[a-zA-Z][a-zA-Z-_\.]{1,15}$");
            string add_spechialnost = textBox_add_spechialnost.Text.Trim();
            string add_vrach_name = textBox_add_Name.Text.Trim();
            string add_Name_hospital = textBox_add_Name_hospital.Text.Trim();
            string add_vrach_Fio = textBox_add_Fio.Text.Trim();
            int add_number_kabineta =int.Parse(textBox_add_number_kabineta.Text.Trim());
            string add_vrach_Otchestvo = textBox_add_Otchestvo.Text.Trim();
            string add_vrach_time = TimePicker_add_time.Text.Trim();
            string add_vrach_Data = TextBox_add_Data.Text.Trim();
            bool pravda = true;
            if (!regyl_Data.IsMatch(add_vrach_Data))
            {
                TextBox_add_Data.ToolTip = "Не корректное значение:День.Месяц.Год";
                TextBox_add_Data.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                TextBox_add_Data.ToolTip = "";
                TextBox_add_Data.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(add_vrach_Otchestvo))
            {
                textBox_add_Otchestvo.ToolTip = "Не корректное значение";
                textBox_add_Otchestvo.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_add_Otchestvo.ToolTip = "";
                textBox_add_Otchestvo.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(add_vrach_Fio))
            {
                textBox_add_Fio.ToolTip = "Не корректное значение";
                textBox_add_Fio.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_add_Fio.ToolTip = "";
                textBox_add_Fio.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(add_vrach_name))
            {
                textBox_add_Name.ToolTip = "Не корректное значение";
                textBox_add_Name.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_add_Name.ToolTip = "";
                textBox_add_Name.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(add_spechialnost))
            {
                textBox_add_spechialnost.ToolTip = "Не корректное значение";
                textBox_add_spechialnost.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_add_spechialnost.ToolTip = "";
                textBox_add_spechialnost.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(add_Name_hospital))
            {
                textBox_add_Name_hospital.ToolTip = "Не корректное значение";
                textBox_add_Name_hospital.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_add_Name_hospital.ToolTip = "";
                textBox_add_Name_hospital.Foreground = Brushes.Black;
            }



            //if ((string)Button_Zareg.Content == "Изменить")
            //{
            //    Window2 j = new Window2();
            //    MessageBox.Show("Good");
            //    Data data = new Data(Reg_login, Reg_password, Reg_Email, Reg_Name, Reg_Fio, Reg_Otchestvo, Reg_Data);
            //    //Hide();
            //    j.nyshno(data);
            //}

            if (pravda)
            {
                using (var db = new BloggingContext())
                {
                    // Note: This sample requires the database to be created before running.
                    //MessageBox.Show($"Database path: Users.db.");
                    // Create
                    List<Vrach> vraches = db.Vrachs.ToList();
                    int f = vraches.Count + 1;
                    SaveFileDialog save = new SaveFileDialog();
                    //{
                    //    Filter = "JPG Files (" + f + ".jpg)|" + f + ".jpg"
                    //};

                    JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                    jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(Image_Create_Menu_vrach.Source as BitmapSource));
                    save.FileName = "C:\\Users\\User\\Desktop\\PRG\\NewMir\\NewMir\\User_Photo\\" + f + ".jpg";
                    using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        jpegBitmapEncoder.Save(fileStream);
                    
                    
                    
                    
                    
                    db.Vrachs.Add(new Vrach {fio = add_vrach_Fio, name = add_vrach_name, otchestvo = add_vrach_Otchestvo, img = save.FileName,spechialnost= add_spechialnost,name_hospital= add_Name_hospital,number_kabinet= add_number_kabineta,Grahic_vrach= add_vrach_Data,time= add_vrach_time });

                    db.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно");

                    //foreach (var vrach in vraches)
                    //{
                    //    if (vrach.login == Reg_login)
                    //    {
                    //        Indentificate indentificate = new Indentificate(vrach.name_hospital, vrach.spechialnost, vrach.number_kabinet, vrach.name, vrach.fio, vrach.otchestvo, vrach.Grahic_vrach,vrach.time);
                    //        Window4 l = new Window4();

                    //        Buffer.login = vrach.login;
                    //        l.Name_User.Text = "Добро пожаловать " + Reg_login;
                    //        l.Show();
                    //        //Hide();
                    //    }
                    //}


                }
            }

        }
        private void Click_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                 Image_Create_Menu_vrach.Source = new BitmapImage(new Uri(openDialog.FileName));

            }
        }

        private void Button_Admin_Click(object sender, RoutedEventArgs e)
        {
            Calendar_add_Data.Visibility=Visibility.Visible;
        }

        private void Calendar_add_Data_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            List<DateTime> gaf = Calendar_add_Data.SelectedDates.ToList();
            TextBox_add_Data.Text = gaf[0].ToString() +"-"+ gaf[gaf.Count - 1].ToString();
            Calendar_add_Data.Visibility = Visibility.Hidden;
        }
    }

}
