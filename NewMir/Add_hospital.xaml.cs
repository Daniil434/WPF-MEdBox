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
    /// Логика взаимодействия для Add_hospital.xaml
    /// </summary>
    public partial class Add_hospital : Page
    {
        public Add_hospital()
        {
            InitializeComponent();
        }
        private void Click_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                Image_Create_Menu_Hospital.Source = new BitmapImage(new Uri(openDialog.FileName));

            }
        }

        private void Button_Add_hospital(object sender, RoutedEventArgs e)
        {
            string Add_hospital_name = textBox_Add_Name.Text.Trim();
            string Add_hospital_adres = textBox_Add_Adres.Text.Trim();
            string Add_hospital_all_vrach = textBox_Add_all_vrach.Text.Trim();
            Regex regyl_login = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            Regex regyl_FIO = new Regex(@"^[a-zA-Z][a-zA-Z-_\.]{1,15}$");
            bool pravda = true;
            if (!regyl_login.IsMatch(Add_hospital_name))
            {
                textBox_Add_Name.ToolTip = "Не корректное значение";
                textBox_Add_Name.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Add_Name.ToolTip = "";
                textBox_Add_Name.Foreground = Brushes.Black;
            }
            if (!regyl_FIO.IsMatch(Add_hospital_all_vrach))
            {
                textBox_Add_all_vrach.ToolTip = "Не корректное значение";
                textBox_Add_all_vrach.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Add_all_vrach.ToolTip = "";
                textBox_Add_all_vrach.Foreground = Brushes.Black;
            }
            if (Add_hospital_adres == "")
            {
                textBox_Add_Adres.ToolTip = "Не корректное значение";
                textBox_Add_Adres.Foreground = Brushes.Red;
                pravda = false;
            }
            else
            {
                textBox_Add_Adres.ToolTip = "";
                textBox_Add_Adres.Foreground = Brushes.Black;
            }
            if (pravda)
            {
                using (var db = new BloggingContext())
                {
                    // Note: This sample requires the database to be created before running.
                    //MessageBox.Show($"Database path: Users.db.");
                    // Create
                    List<Hospital> hospitals = db.Hospitals.ToList();
                    int f = hospitals.Count + 1;
                    SaveFileDialog save = new SaveFileDialog();
                    //{
                    //    Filter = "JPG Files (" + f + ".jpg)|" + f + ".jpg"
                    //};

                    JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                    jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(Image_Create_Menu_Hospital.Source as BitmapSource));
                    save.FileName = "C:\\Users\\User\\Desktop\\PRG\\NewMir\\NewMir\\User_Photo\\" + f + "hosp.jpg";
                    using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        jpegBitmapEncoder.Save(fileStream);

                    db.Hospitals.Add(new Hospital { name = Add_hospital_name, adres = Add_hospital_adres, all_vrach = Add_hospital_all_vrach, img = save.FileName });

                    db.SaveChanges();
                    MessageBox.Show("Добавление прошло успешно");
                }
            }
        }

        
    }
}