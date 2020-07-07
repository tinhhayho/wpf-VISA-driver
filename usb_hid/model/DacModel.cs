using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usb_hid.viewmodel;

namespace usb_hid.model
{
    public class DacModel : BaseViewModel
    {
        public DacModel()
        { }
        public DacModel(int channel, float convert, string des)
        {
            DacChannel = channel;
            DacConvert = convert;
            Des = des;

        }
        private int _dacChannel;
        public int DacChannel 
        { 
            get => _dacChannel; 
            set 
            {
                _dacChannel = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            } 
        }
        private float _dacConvert;
        public float DacConvert 
        { 
            get => _dacConvert; 
            set 
            {
                _dacConvert = value;
                OnPropertyChanged();
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());                    
                }
            } 
        }
        private string _des ;
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


        private event EventHandler _ValueChanged;
        public event EventHandler ValueChanged
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
