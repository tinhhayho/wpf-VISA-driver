using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Ivi.Visa;
using NationalInstruments.Visa;
using NationalInstruments.Visa.Internal;
using usb_hid.model;

namespace usb_hid.viewmodel
{

    class ConfigViewModel : BaseViewModel 
    {


        // onpropertychaned dung de thong bao gia tri da thay doi
        // de command hoat dong


        private readonly string filter = "USB?*";

        private List<string> _ResourceName;
        public List<string> ResourceName { get => _ResourceName; set { _ResourceName = value; OnPropertyChanged(); } }

        public ICommand findCommand { get; set; }
        public ICommand connectCommand { get; set; }
        public ICommand disconnectCommand { get; set; }
        public ConfigViewModel()        
        {



            findCommand = new RelayCommand<object>((p) => { return true; },
                (p) =>
                {
                    if (ResourceName != null)
                    {
                        ResourceName.Clear();
                    }
                    FindResources();

                });

            connectCommand = new RelayCommand<TextBox>
                ((p) => 
                {
                    if (p == null) return false;
                    TextBox pp = p as TextBox;
                    if (pp.Text != string.Empty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                },
                (p) =>
                {
                    try
                    {
                        // truoc het phai disconnect cai cu 
                        VisaNsModel.mySession.DisposeIfNotNull();                        
                        // tao mo connect moi
                        ResourceManager manager = new ResourceManager();
                        TextBox pp = p as TextBox;                        
                        VisaNsModel.mySession = manager.Open(pp.Text) as UsbRaw;
                        VisaNsModel.mySession.Interrupt += VisaNsModel.EN_USBInterrupt;
                        VisaNsModel.deviceNameDataBase = VisaNsModel.mySession.ModelName;                       
                        Window cofwindow = Window.GetWindow(p);
                        cofwindow.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });

            disconnectCommand = new RelayCommand<object>
                ((p) =>
                {
                    if (VisaNsModel.mySession != null )
                    {
                        if (VisaNsModel.mySession.IsDisposed == false) return true;
                    }
                    return false;

                },
                (p) =>
                {
                    VisaNsModel.mySession.Interrupt -= VisaNsModel.EN_USBInterrupt;
                    VisaNsModel.mySession.DisposeIfNotNull();
                    VisaNsModel.deviceNameDataBase = "non-device connect";
                });
        }



        private void FindResources()
        {
            // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
            // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
            // requires additional VISA .NET implementations.
            using (var rm = new ResourceManager())
            {
                try
                {
                    List<string> ResourceNameTemp = new List<string>() { "1" };
                    IEnumerable<string> resources = rm.Find(filter);
                    foreach (string s in resources){
                        
                        ParseResult parseResult = rm.Parse(s);
                        AddReSource(s, parseResult.InterfaceType,ref ResourceNameTemp );
                    }
                    ResourceNameTemp.RemoveAt(0);
                    ResourceName = ResourceNameTemp;
                }
                catch 
                {
                    MessageBox.Show("Không tìm thấy Resource");
                }
            }
        }
        private void AddReSource(string resourceName, HardwareInterfaceType intType, ref List<string> nametemp)
        {
            if (intType == HardwareInterfaceType.Usb)
            {
                nametemp.Add(resourceName);                
            }
        }


    }
}
