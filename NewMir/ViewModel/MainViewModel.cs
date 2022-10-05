using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NewMir.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page DashBoard_menu = new Page1();
        private Page Grahic_admin = new Page2();
        private Page Messages = new Page3();
        private Page List_Users = new Window2();
        private Page List_Savki = new Saavki();
        private Page Add_Hospital = new Add_hospital();
        private Page Add_User = new Window1();
        private Page Hospital_Menu = new Hospitals_menu();
        private Page Doctors_menu = new Doctors_menu();
        private Page Vrach_menu = new add_vrach();

        private Page _CurPage = new Page1();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }
        public ICommand OpenDashBoard_menu
        {
            get
            {
                return new RelayCommand(() => CurPage = DashBoard_menu);
            }
        }
        public ICommand OpenGrahic_admin
        {
            get
            {
                return new RelayCommand(() => CurPage = Grahic_admin);
            }
        }
        public ICommand OpenMessages
        {
            get
            {
                return new RelayCommand(() => CurPage = Messages);
            }
        }
        public ICommand OpenList_Users
        {
            get
            {
                return new RelayCommand(() => CurPage = List_Users);
            }
        }
        public ICommand OpenList_Savki
        {
            get
            {
                return new RelayCommand(() => CurPage = List_Savki);
            }
        }
        public ICommand OpenAdd_Hospital
        {
            get
            {
                return new RelayCommand(() => CurPage = Add_Hospital);
            }
        }
        public ICommand OpenAdd_User
        {
            get
            {
                return new RelayCommand(() => CurPage = Add_User);
            }
        }
        public ICommand OpenHospital_Menu
        {
            get
            {
                return new RelayCommand(() => CurPage = Hospital_Menu);
            }
        }
        public ICommand OpenDoctors_menu
        {
            get
            {
                return new RelayCommand(() => CurPage = Doctors_menu);
            }
        }
        public ICommand OpenVrach_menu
        {
            get
            {
                return new RelayCommand(() => CurPage = Vrach_menu);
            }
        }
    }
}
