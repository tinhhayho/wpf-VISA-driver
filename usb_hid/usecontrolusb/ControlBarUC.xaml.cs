using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using usb_hid.viewmodel;

namespace usb_hid.usecontrolusb
{
    /// <summary>
    /// Interaction logic for ControlBarUC.xaml
    /// </summary>
    public partial class ControlBarUC : UserControl
    {
        public ControlBarViewModel Viewmodel { get; set; }

        public ControlBarUC()
        {
            InitializeComponent();
            // ban chat duyet tu phai sang trai
            this.DataContext = Viewmodel = new ControlBarViewModel();
        }
    }
}
