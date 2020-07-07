using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using usb_hid.model;

namespace usb_hid.viewmodel
{
    public class DiDoViewModel:BaseViewModel
    {



        private Brush _Di0;
        public Brush Di0 { get => _Di0; set { _Di0 = value; } }
        private Brush _Di1;
        public Brush Di1 { get => _Di1; set { _Di1 = value; } }
        private Brush _Di2;
        public Brush Di2 { get => _Di2; set { _Di2 = value; } }
        private Brush _Di3;
        public Brush Di3 { get => _Di3; set { _Di3 = value; } }
        private Brush _Di4;
        public Brush Di4 { get => _Di4; set { _Di4 = value; } }
        private Brush _Di5;
        public Brush Di5 { get => _Di5; set { _Di5 = value; } }
        private Brush _Di6;
        public Brush Di6 { get => _Di6; set { _Di6 = value; } }
        private Brush _Di7;
        public Brush Di7 { get => _Di7; set { _Di7 = value; } }




        public ICommand Do0Command { get; set; }
        public ICommand Do1Command { get; set; }
        public ICommand Do2Command { get; set; }
        public ICommand Do3Command { get; set; }
        public ICommand Do4Command { get; set; }
        public ICommand Do5Command { get; set; }
        public ICommand Do6Command { get; set; }
        public ICommand Do7Command { get; set; }


        public DiDoViewModel( )
        {
            // KHOI TAO cac gia tri do
            Di0 = VisaNsModel.dataDiDo.Di0;
            Di1 = VisaNsModel.dataDiDo.Di1;
            Di2 = VisaNsModel.dataDiDo.Di2;
            Di3 = VisaNsModel.dataDiDo.Di3;
            Di4 = VisaNsModel.dataDiDo.Di4;
            Di5 = VisaNsModel.dataDiDo.Di5;
            Di6 = VisaNsModel.dataDiDo.Di6;
            Di7 = VisaNsModel.dataDiDo.Di7;
            // delegate
            VisaNsModel.dataDiDo.ValueChanged += DIDO_changed;
            // xu ly cac command



            // mới viết cho 1 nút 
            Do0Command = new RelayCommand<ToggleButton>((p) => { return  true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked !=null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do0 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do0 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do1Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do1 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do1 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do2Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do2 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do2 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do3Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do3 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do3 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do4Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do4 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do4 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do5Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do5 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do5 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do6Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do6 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do6 = false;
                        }
                    }
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });

            Do7Command = new RelayCommand<ToggleButton>((p) => { return true; },
                (p) =>
                {
                    ToggleButton _toggle = p as ToggleButton;
                    if (_toggle.IsChecked != null)
                    {
                        if (_toggle.IsChecked == true)
                        {
                            VisaNsModel.dataDiDo._Do7 = true;
                        }
                        else
                        {
                            VisaNsModel.dataDiDo._Do7 = false;
                        }
                    }
                    VisaNsModel.WriteUsb();
                    try
                    {
                        VisaNsModel.WriteUsb();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                });


        }

        void DIDO_changed(object sender, EventArgs e)
        {

        }




    }
}
