using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using usb_hid.model;

namespace usb_hid.viewmodel
{
    public class MainViewModel : BaseViewModel
    {

        private string _DeviceName;
        public string  DeviceName { get => _DeviceName; set { _DeviceName = value; OnPropertyChanged(); } }

        //bool isLoadConfigWindows = false;
        public ICommand LoadedWindowsCommand { get; set; }
        public ICommand UnitCommand { get; set; } // adc

        public ICommand DACWindowCommand { get; set; }// dac

        public ICommand DiDoWindowCommand { get; set; } // dido

        public ICommand PwmWindowCommand { get; set; }// pwm

        public ICommand ConfigWindow { get; set; }


        public ICommand IntroTrungTinhCommand { get; set; }

        public ICommand IntroPhatTrienCommand { get; set; }

        public ICommand IntroLongDoCommand { get; set; }

        // moi thu xu ly o day
        // them mot method test
        public MainViewModel()
        {

            DeviceName = VisaNsModel.deviceNameDataBase;
            VisaNsModel.DeviceNameChanged += Devide_name_changed;


            // xu ly cac command
            LoadedWindowsCommand = new RelayCommand<Window>((p) => { return  true; },
                (p) =>
                {
                    //isLoadConfigWindows = true;
                    p.Hide();
                    ConfigWindow configWindow = new ConfigWindow();
                    configWindow.ShowDialog();
                    p.Show();

                });

            UnitCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    UnitWindow unitw = new UnitWindow();
                    unitw.ShowDialog();
                });
            DACWindowCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    DacWindow dacWindow = new DacWindow();
                    dacWindow.ShowDialog();

                });
            DiDoWindowCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    DiDoWindow diDoWindow = new DiDoWindow();
                    diDoWindow.ShowDialog();

                });
            PwmWindowCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    PwmWindow pwmWindow = new PwmWindow();
                    pwmWindow.ShowDialog();

                });
            ConfigWindow = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    ConfigWindow configuWindow = new ConfigWindow();
                    configuWindow.ShowDialog();

                });


            // goi github

            IntroTrungTinhCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    Process.Start("https://github.com/tinhhayho");
                });
            IntroPhatTrienCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    Process.Start("https://github.com/tinhhayho");
                });
            IntroLongDoCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    Process.Start("https://github.com/tinhhayho");
                });



            // event
            void Devide_name_changed(object sender, EventArgs e)
            {
                DeviceName = VisaNsModel.deviceNameDataBase;
            }

        }
    }
}
