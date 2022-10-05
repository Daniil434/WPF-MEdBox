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
    /// Логика взаимодействия для User_Menu.xaml
    /// </summary>

    public static class FrameworkElementExt
    {
        public static void BringToFront(this FrameworkElement element)
        {
            if (element == null) return;

            Panel parent = element.Parent as Panel;
            if (parent == null) return;

            var maxZ = parent.Children.OfType<UIElement>()
              .Where(x => x != element)
              .Select(x => Panel.GetZIndex(x))
              .Max();
            Panel.SetZIndex(element, maxZ + 1);
        }
    }

    public partial class User_Menu : Window
    {
        private Button currentBtn;
        private StackPanel leftBorderBtn;
        private Window currentChildForm;

        public User_Menu()
        {
            InitializeComponent();
            leftBorderBtn = new StackPanel();
            leftBorderBtn.RenderSize = new Size(7, 60);
            panelMenu.Children.Add(leftBorderBtn);
        }
        public class RGBColors
        {
            
            public static Color color1 = Color.FromRgb(172, 126, 241);
            public static SolidColorBrush brush1 = new SolidColorBrush(color1);
            public static Color color2 = Color.FromRgb(249, 118, 176);
            public static SolidColorBrush brush2 = new SolidColorBrush(color2);
            public static Color color3 = Color.FromRgb(253, 138, 114);
            public static SolidColorBrush brush3 = new SolidColorBrush(color3);
            public static Color color4 = Color.FromRgb(95, 77, 221);
            public static SolidColorBrush brush4 = new SolidColorBrush(color4);
            public static Color color5 = Color.FromRgb(249, 88, 155);
            public static SolidColorBrush brush5 = new SolidColorBrush(color5);
            public static Color color6 = Color.FromRgb(24, 161, 251);
            public static SolidColorBrush brush6 = new SolidColorBrush(color6);
        }

        

        private void ActivateButton(object senderBtn, SolidColorBrush color,FontAwesome.Sharp.IconImage iconImage,TextBlock currentBtn1)
        {
            if (senderBtn != null)
            {
                DisableButton(iconImage, currentBtn1);
                //Button
                currentBtn = (Button)senderBtn;
                Color color_tete = Color.FromRgb(37, 36, 81);
                SolidColorBrush brush_tete = new SolidColorBrush(color_tete);
                currentBtn.Background = new SolidColorBrush(Color.FromArgb(37, 36, 81,10));
                currentBtn.Foreground = new SolidColorBrush(Color.FromArgb(172, 126, 241,12));
                //currentBtn1.TextAlignment = TextAlignment.Center;
                //iconImage.Foreground = brush_tete;
                //iconImage.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconImage.HorizontalAlignment = HorizontalAlignment.Right;
                //Left border button
                //leftBorderBtn.Background = brush_tete;
                //leftBorderBtn.Margin = new Thickness(0, currentBtn.ActualWidth,0,0);
                //leftBorderBtn.Visibility = Visibility.Visible;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton(FontAwesome.Sharp.IconImage iconImage,TextBlock currentBtn1)
        {
            if (currentBtn != null)
            {
                Color color_tete = Color.FromRgb(31, 30, 68);
                SolidColorBrush brush_tete = new SolidColorBrush(color_tete);
                currentBtn.Background = brush_tete;
                currentBtn.Foreground = Dashboard.Foreground;
                currentBtn1.TextAlignment = TextAlignment.Left;
                iconImage.Foreground = Dashboard.Foreground;
                //iconImage.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconImage.HorizontalAlignment = HorizontalAlignment.Left;
            }
        }
        private void OpenChildForm(Window childForm)
        {
            //open only form
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            //currentChildForm = childForm;
            ////End
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            //lblTitleChildForm.Text = childForm.Content;
        }
        private void Reset()
        {
            //DisableButton();
            //leftBorderBtn.Visibility = Visibility.Collapsed;
            //iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            //lblTitleChildForm.Text = "Home";
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush1,Icon_Image1, Text_Block_User1);
            OpenChildForm(new Window5());
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush2, Icon_Image2, Text_Block_User2);
            OpenChildForm(new Window4());
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush3, Icon_Image3, Text_Block_User3);
            OpenChildForm(new Window3());
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush4, Icon_Image4, Text_Block_User4);
            //OpenChildForm(new Window2());
        }
        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush5, Icon_Image5, Text_Block_User5);
            //OpenChildForm(new Window1());
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.brush6, Icon_Image6, Text_Block_User6);
            OpenChildForm(new MainWindow());
        }
        //Drag Form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
        ////Close-Maximize-Minimize
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //        WindowState = FormWindowState.Maximized;
        //    else
        //        WindowState = FormWindowState.Normal;
        //}
        //private void btnMinimize_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}
        ////Remove transparent border in maximized state
        //private void FormMainMenu_Resize(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Maximized)
        //        FormBorderStyle = FormBorderStyle.None;
        //    else
        //        FormBorderStyle = FormBorderStyle.Sizable;
        //}

    }
}
