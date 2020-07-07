using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using usb_hid.model;

namespace usb_hid.viewmodel
{
    public class PwmViewModel:BaseViewModel
    {
        private ObservableCollection<PwmModel> _itemPwm;
        public ObservableCollection<PwmModel> ItemPwm { get => _itemPwm; set { _itemPwm = value; OnPropertyChanged(); } }


        public ICommand Write1Command { get; set; }
        public ICommand Write2Command { get; set; }


        public PwmViewModel()
        {
            ItemPwm = new ObservableCollection<PwmModel>() { VisaNsModel.dataPwm0, VisaNsModel.dataPwm1 };

            Write1Command = new RelayCommand<object>
                ((p) =>
                {  
                    if(VisaNsModel.mySession != null) { if (VisaNsModel.mySession.IsDisposed == false) return true; }
                    return false;
                },
                (p) =>
                {
                    VisaNsModel.dataPwm0.NormalFrequency = Convert.ToUInt16(NormalFrequency1);
                    VisaNsModel.dataPwm0.Duty = Convert.ToUInt16(Duty1);

                });
            Write2Command = new RelayCommand<object>
                ((p) =>
                {
                    if (VisaNsModel.mySession != null) { if (VisaNsModel.mySession.IsDisposed == false) return true; }
                    return false;
                },
                (p) =>
                {
                    VisaNsModel.dataPwm1.NormalFrequency = Convert.ToUInt16(NormalFrequency2);
                    VisaNsModel.dataPwm1.Duty = Convert.ToUInt16(Duty2);
                });
        }

        /// <summary>
        /// property channel1
        /// </summary>
        private int _channel1;
        public int Channel1
        {
            get => _channel1;
            set
            {
                _channel1 = value;
            }
        }


        private double _normalfrequency1;
        public double NormalFrequency1
        {
            get => _normalfrequency1;
            set
            {
                _normalfrequency1 = value;
            }
        }


        private double _duty1;
        public double Duty1
        {
            get => _duty1;
            set
            {
                _duty1 = value;
            }
        }


        private bool _pwmorpto;
        public bool PwmOrPto
        {
            get => _pwmorpto;
            set
            {
                _pwmorpto = value;
            }
        }
        // channel 2
        private int _channel2;
        public int Channel2
        {
            get => _channel2;
            set
            {
                _channel2 = value;
            }
        }


        private double _normalfrequency2;
        public double NormalFrequency2
        {
            get => _normalfrequency2;
            set
            {
                _normalfrequency2 = value;
            }
        }


        private double _duty2;
        public double Duty2
        {
            get => _duty2;
            set
            {
                _duty2 = value;
            }
        }





    }
}
