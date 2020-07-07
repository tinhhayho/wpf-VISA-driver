using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usb_hid.model
{
    public class PwmModel
    {

        public PwmModel(int channelinput, UInt16 Nfre, UInt16 dutyinput,bool pwmpto)
        {

            Channel = channelinput;
            NormalFrequency = Nfre;
            Duty = dutyinput;
            PwmOrPto = pwmpto;

        }

        private int _channel;
        public int Channel 
        { 
            get=>_channel;
            set 
            {
                _channel = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            } 
        }


        private UInt16 _normalfrequency;
        public UInt16 NormalFrequency
        {
            get => _normalfrequency;
            set 
            { 
                _normalfrequency = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            }
        }


        private UInt16 _duty;
        public UInt16 Duty
        {
            get => _duty;
            set 
            { 
                _duty = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            }
        }


        private bool _pwmorpto;
        public bool PwmOrPto
        {
            get => _pwmorpto;
            set 
            {
                _pwmorpto = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }
            }
        }



        private event EventHandler _ValueChanged;
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
