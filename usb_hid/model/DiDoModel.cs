using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace usb_hid.model
{

    public  class DiDoModel
    {
        public DiDoModel(Brush di0, Brush di1, Brush di2, Brush di3, Brush di4, Brush di5, Brush di6, Brush di7,
                        bool do0, bool do1, bool do2, bool do3, bool do4, bool do5, bool do6, bool do7)
        {
            Di0 = di0;
            Di1 = di1;
            Di2 = di2;
            Di3 = di3;
            Di4 = di4;
            Di5 = di5;
            Di6 = di6;
            Di7 = di7;

            _Do0 = do0;
            _Do1 = do1;
            _Do2 = do2;
            _Do3 = do3;
            _Do4 = do4;
            _Do5 = do5;
            _Do6 = do6;
            _Do7 = do7;
        }
        private   Brush _Di0;
        public  Brush Di0
        {
            get =>_Di0;
            set 
            {
                _Di0 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            } 
        }
        private  Brush _Di1;
        public  Brush Di1
        {
            get => _Di1;
            set
            {
                _Di1 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private  Brush _Di2;
        public  Brush Di2
        {
            get => _Di2;
            set
            {
                _Di2 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private  Brush _Di3;
        public  Brush Di3
        {
            get => _Di3;
            set
            {
                _Di3 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private Brush _Di4;
        public  Brush Di4
        {
            get => _Di4;
            set
            {
                _Di4 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private  Brush _Di5;
        public  Brush Di5
        {
            get => _Di5;
            set
            {
                _Di5 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private  Brush _Di6;
        public  Brush Di6
        {
            get => _Di6;
            set
            {
                _Di6 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }

        private  Brush _Di7;
        public  Brush Di7
        {
            get => _Di7;
            set
            {
                _Di7 = value;
                if (_ValueChanged != null)
                {
                    _ValueChanged(null, new EventArgs());
                }

            }
        }


        public  bool _Do0;

        public  bool _Do1;

        public  bool _Do2;

        public  bool _Do3;

        public  bool _Do4;

        public  bool _Do5;

        public  bool _Do6;

        public  bool _Do7;

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
