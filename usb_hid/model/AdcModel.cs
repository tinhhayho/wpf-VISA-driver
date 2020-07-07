using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usb_hid.viewmodel;

namespace usb_hid.model
{
    public class AdcModel:BaseViewModel
    {

        public AdcModel(int channel,int value, double convert,string des)
        {
            AdcChannel = channel;
            AdcValue = value;
            AdcConvert = convert;
            Des = des;
        }
        private int _adcChannel ;
        public int AdcChannel 
        { 
            get=>_adcChannel; 
            set
            {
                _adcChannel=value; 
                if(_ValueChanged!=null)
                {
                    _ValueChanged(null,new EventArgs());
                }
            } 
        }
        private int _adcValue ;
        public int AdcValue 
        { 
            get=>_adcValue; 
            set 
            {
                _adcValue=value;
                OnPropertyChanged();
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            } 
        }
        private double _adcConvert ;
        public double AdcConvert 
        { 
            get=>_adcConvert; 
            set 
            {
                _adcConvert=value;
                OnPropertyChanged();
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            } 
        }
        private string _des  ;
        public string Des 
        { 
            get => _des; 
            set
            { 
                _des = value;
                OnPropertyChanged();
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            }
        }




        private  event EventHandler _ValueChanged;
        public  event EventHandler ValueChanged
        {
            add
            {
                _ValueChanged += value;
            }
            remove
            {
                _ValueChanged -= value;
            }

        }


    }
}
