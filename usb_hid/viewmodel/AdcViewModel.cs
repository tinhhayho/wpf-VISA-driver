using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usb_hid.model;

namespace usb_hid.viewmodel
{
    public class AdcViewModel:BaseViewModel
    {
        private ObservableCollection<AdcModel> _itemAdc;
        public ObservableCollection<AdcModel> ItemAdc
        {
            get=>_itemAdc;
            set {_itemAdc = value;OnPropertyChanged(); } 
        }

        // dữ liệu từ item được chọn rồi copy qua các thuộc tính khác để binding lên
        private AdcModel _selectedItem;
        public AdcModel SelectedItem 
        { 
            get => _selectedItem;
            set 
            {
                _selectedItem = value;
                if (_selectedItem != null)
                {
                    AdcSelChannel = _selectedItem.AdcChannel.ToString();
                    AdcSelValue = _selectedItem.AdcValue.ToString();
                    AdcSelConvert = _selectedItem.AdcConvert.ToString();
                }
            }
        }

        // du lieu de binding len textbox
        private string _adcSelChannel;
        public string AdcSelChannel
        {
            get => _adcSelChannel;
            set {_adcSelChannel = value;OnPropertyChanged(); }
        }

        private string _adcSelValue;
        public string AdcSelValue
        {
            get => _adcSelValue;
            set { _adcSelValue = value;OnPropertyChanged(); }
        }

        private string _adcSelConvert;
        public string AdcSelConvert
        {
            get=>_adcSelConvert;
            set { _adcSelConvert = value;OnPropertyChanged(); }
        }

        public AdcViewModel()
        {

            ItemAdc = new ObservableCollection<AdcModel> {VisaNsModel.dataAdc0, VisaNsModel.dataAdc1,
                                                          VisaNsModel.dataAdc2, VisaNsModel.dataAdc3};
            VisaNsModel.dataAdc0.ValueChanged += ADC_changed0;
            VisaNsModel.dataAdc1.ValueChanged += ADC_changed0;
            VisaNsModel.dataAdc2.ValueChanged += ADC_changed0;
            VisaNsModel.dataAdc3.ValueChanged += ADC_changed0;

        }
        void ADC_changed0(object sender, EventArgs e)
        {
            switch (AdcSelChannel)
            {
                case ("0"):
                    {
                        AdcSelValue = ItemAdc[0].AdcValue.ToString();
                        AdcSelConvert = ItemAdc[0].AdcConvert.ToString();
                    }
                    break;

                case ("1"):
                    {
                        AdcSelValue = ItemAdc[0].AdcValue.ToString();
                        AdcSelConvert = ItemAdc[0].AdcConvert.ToString();
                    }
                    break;

                case ("2"):
                    {
                        AdcSelValue = ItemAdc[0].AdcValue.ToString();
                        AdcSelConvert = ItemAdc[0].AdcConvert.ToString();
                    }
                    break;

                case ("3"):
                    {
                        AdcSelValue = ItemAdc[0].AdcValue.ToString();
                        AdcSelConvert = ItemAdc[0].AdcConvert.ToString();
                    }
                    break;
                default:
                    break;
            }


        }

    }
}
