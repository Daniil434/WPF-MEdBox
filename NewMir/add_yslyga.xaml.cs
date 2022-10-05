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
    /// Логика взаимодействия для add_yslyga.xaml
    /// </summary>
    public partial class add_yslyga : Page
    {
        public add_yslyga()
        {
            InitializeComponent();
        }

        private void Button_Zareg_Click(object sender, RoutedEventArgs e)
        {
            
            //Regex regyl_password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$");
            Regex regyl_login = new Regex(@"^[a-zA-Z][a-zA-Z0-9-_\.]{1,15}$");
            
            string add_name_yslyga = textBox_Add_Name.Text.Trim();
            
            int add_cost = int.Parse(textBox_Add_Cost.Text.Trim());
            
            bool pravda = true;
            
            if (!regyl_login.IsMatch(add_name_yslyga))
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
                    List<Yslyga> yslygas = db.Yslygs.ToList();
                    int f = yslygas.Count + 1;
                    





                    db.Yslygs.Add(new Yslyga {name = add_name_yslyga, stoimost= add_cost });

                    db.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно");

                    


                }
            }
        }
        
    }
}
