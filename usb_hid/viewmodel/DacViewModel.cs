using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using usb_hid.model;

namespace usb_hid.viewmodel
{
    public class DacViewModel : BaseViewModel
    { 


        private ObservableCollection<DacModel> _itemDac;
        public ObservableCollection<DacModel> ItemDac 
        { 
            get=>_itemDac;
            set { _itemDac = value;OnPropertyChanged(); }
        }
        private DacModel _selectedItem;
        public DacModel SelectedItemsDac
        { 
            get=>_selectedItem;
            set {
                _selectedItem = value;
                if (_selectedItem!=null)
                {
                    DacSelChannel = _selectedItem.DacChannel.ToString();
                    DacSelConvert = _selectedItem.DacConvert.ToString();
                }
                }
        }
        private string _dacSelChannel;
        public string DacSelChannel
        { 
            get=>_dacSelChannel;
            set {_dacSelChannel=value;OnPropertyChanged(); } 
        }
        private string _dacSelConvert;
        public string DacSelConvert 
        { 
            get=>_dacSelConvert;
            set {_dacSelConvert= value;OnPropertyChanged(); } 
        }
        public ICommand DacUpdateCommand { get; set; }
        public ICommand DacSend { get; set; }

        int _channelUpdate;
        double _valueUpdate;

        public DacViewModel()
        {
            // khoi tao 

            ItemDac = new ObservableCollection<DacModel> { VisaNsModel.dataDac0, VisaNsModel.dataDac1,
                                                           VisaNsModel.dataDac2, VisaNsModel.dataDac3 };
            // delegate
            VisaNsModel.dataDac0.ValueChanged += DAC_changed0;
            VisaNsModel.dataDac1.ValueChanged += DAC_changed1;
            VisaNsModel.dataDac2.ValueChanged += DAC_changed2;
            VisaNsModel.dataDac3.ValueChanged += DAC_changed3;

            // xu ly cac command
            DacUpdateCommand = new RelayCommand<object>
                ((p) => 
                {
                    if (!(Int32.TryParse(DacSelChannel,out _channelUpdate)))
                    {
                        return false;

                    }
                    if ((_channelUpdate > 3) || (_channelUpdate < 0))
                    {
                        return false;
                    }
                    if (!(Double.TryParse(DacSelConvert,out _valueUpdate)))
                    {
                        return false;
                    }
                    if (_valueUpdate > 3.3 || _valueUpdate < 0)
                    {
                        return false;
                    }
                    return true; 
                },
                    (p) =>
                    {
                        ItemDac[_channelUpdate].Des = "enable";
                        ItemDac[_channelUpdate].DacConvert = Convert.ToSingle(_valueUpdate);
                    });

            DacSend = new RelayCommand<object>((p) => { return true; },
                (p) =>  {                    
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
        // chua la gi o day
        void DAC_changed0(object sender, EventArgs e)
        {
            
        }
        void DAC_changed1(object sender, EventArgs e)
        {
            
        }
        void DAC_changed2(object sender, EventArgs e)
        {
            

        }
        void DAC_changed3(object sender, EventArgs e)
        {
            
        }

    }
}
