using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using NationalInstruments.Visa;
using Ivi.Visa;
using System.Windows;
using NationalInstruments.Visa.Internal;

namespace usb_hid.model
{
    public static class VisaNsModel
    {

        // chua biet khai bao gi o day ne @@ huhu
        // khai bao cai manager

        // adc
        public static AdcModel dataAdc0 = new AdcModel(0, 0, 0, "disable");
        public static AdcModel dataAdc1 = new AdcModel(1, 0, 0, "disable");
        public static AdcModel dataAdc2 = new AdcModel(2, 0, 0, "disable");
        public static AdcModel dataAdc3 = new AdcModel(3, 0, 0, "disable");
        // dac
        public static DacModel dataDac0 = new DacModel(0, 0.0f, "disable");
        public static DacModel dataDac1 = new DacModel(1, 0.0f, "disable");
        public static DacModel dataDac2 = new DacModel(2, 0.0f, "disable");
        public static DacModel dataDac3 = new DacModel(3, 0.0f, "disable");
        // dido
        public static DiDoModel dataDiDo = new DiDoModel(Brushes.Red, Brushes.White, Brushes.Red, Brushes.White,
                                                            Brushes.Red, Brushes.White, Brushes.Red, Brushes.White,
                                                            false, false, false, false, false, false, false, false);
        //pwm
        public static PwmModel dataPwm0 = new PwmModel(0, 1000, 50, true);
        public static PwmModel dataPwm1 = new PwmModel(1, 1000, 50, true);
        // main window
        private static readonly int numberstartdata = 20;
        private static readonly int numberstartadc1 = 28;
        private static readonly int numberstartadc2 = 32;
        private static readonly int numberstartadc3 = 36;
        private static readonly int numberstartadc4 = 40;
        private static readonly int numbercheckstartbyte = 16;
        private static byte[] checkstartbyte = System.Text.Encoding.UTF8.GetBytes("TRIENLONGTINH000");

        public static UsbRaw mySession;
        private static string _deviceNameDataBase ="non-device connect";
        public static string deviceNameDataBase 
        { 
            get => _deviceNameDataBase; 
            set
            {
                _deviceNameDataBase = value;
                if (_deviceNameDataBase != string.Empty)
                {
                    _DeviceNameChanged(null, new EventArgs());
                }
            }
        }


        // cập nhật giá trị của vi điều khiển truyền lên ở file này

        public static void WriteUsb()
        {
            byte[] do_send = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if (dataDiDo._Do0) { do_send[0] = 1; }
            if (dataDiDo._Do1) { do_send[1] = 1; }
            if (dataDiDo._Do2) { do_send[2] = 1; }
            if (dataDiDo._Do3) { do_send[3] = 1; }
            if (dataDiDo._Do4) { do_send[4] = 1; }
            if (dataDiDo._Do5) { do_send[5] = 1; }
            if (dataDiDo._Do6) { do_send[6] = 1; }
            if (dataDiDo._Do7) { do_send[7] = 1; }

            byte[] dac1_send = BitConverter.GetBytes(dataDac0.DacConvert);
            byte[] dac2_send = BitConverter.GetBytes(dataDac1.DacConvert);
           // byte[] dac3_send = BitConverter.GetBytes(dataDac2.DacConvert);
           // byte[] dac4_send = BitConverter.GetBytes(dataDac3.DacConvert);

            byte[] pwm_fre_send1 = BitConverter.GetBytes(dataPwm0.NormalFrequency);
            byte[] pwm_fre_send2 = BitConverter.GetBytes(dataPwm1.NormalFrequency);

            byte[] pwm_duty1 = BitConverter.GetBytes(dataPwm0.Duty);
            byte[] pwm_duty2 = BitConverter.GetBytes(dataPwm1.Duty);

            byte[] send_message = new byte[] {checkstartbyte[0], checkstartbyte[1], checkstartbyte[2], checkstartbyte[3], checkstartbyte[4], checkstartbyte[5],
            checkstartbyte[6],checkstartbyte[7],checkstartbyte[8],checkstartbyte[9],checkstartbyte[10],checkstartbyte[11],checkstartbyte[12],checkstartbyte[13],
            checkstartbyte[14],checkstartbyte[15],0x00, 0x14, 0x00, 0x18 , do_send[0], do_send[1], do_send[2], do_send[3], do_send[4], do_send[5], do_send[6], do_send[7],
            dac1_send[0], dac1_send[1],dac1_send[2],dac1_send[3],
            dac2_send[0], dac2_send[1],dac2_send[2],dac2_send[3],
            pwm_fre_send1[0] , pwm_fre_send1[1] ,
            pwm_fre_send2[0] , pwm_fre_send2[1] ,
            pwm_duty1[0] , pwm_duty1[1],
            pwm_duty2[0] , pwm_duty2[1]} ;
           // dac3_send[0], dac3_send[1],dac3_send[2],dac3_send[3],
           // dac4_send[0], dac4_send[1],dac4_send[2],dac4_send[3], 
           /*
            UInt16 crc = 0;
            for (int i = 16; i < 42; i++)
            {
                crc += send_message[i];
            }

            byte[] check_crc = BitConverter.GetBytes(crc);


            send_message[44] = check_crc[0];
            send_message[45] = check_crc[1];
            */
            if (mySession!=null)
            {
                mySession.RawIO.Write(send_message);
            }
        }

        // event thay doi thiet bi

        private static event EventHandler _DeviceNameChanged;
        public static event EventHandler DeviceNameChanged
        {
            add
            {
                _DeviceNameChanged += value;
            }
            remove
            {
                _DeviceNameChanged -= value;
            }

        }

        public static void EN_USBInterrupt(object sender, UsbInterruptEventArgs e)
        {
            try
            {
                // tìm trên github của triển frame truyền
                byte[] data = e.Data;
                //// kiểm tra header có đúng không
                for (int i = 0; i < numbercheckstartbyte; i++)
                {
                    if (data[i] != checkstartbyte[i])
                    {
                        throw new ArithmeticException();
                    }
                }
                // kiem ra tong so byte nhan
                if (data[numbercheckstartbyte + 2] != 20){ throw new ArithmeticException();  }
                if (data[numbercheckstartbyte + 4] != 24){ throw new ArithmeticException();  }
                // kiểm tra thành công
                if (data[numberstartdata] == 1) {  dataDiDo.Di0 = Brushes.Red; }
                else { dataDiDo.Di0 = Brushes.White; }
                if (data[numberstartdata + 1] == 1) { dataDiDo.Di1 = Brushes.Red; }
                else { dataDiDo.Di1 = Brushes.White; }
                if (data[numberstartdata + 2] == 1) { dataDiDo.Di2 = Brushes.Red; }
                else { dataDiDo.Di2 = Brushes.White; }
                if (data[numberstartdata + 3] == 1) { dataDiDo.Di3 = Brushes.Red; }
                else { dataDiDo.Di3 = Brushes.White; }
                if (data[numberstartdata + 4] == 1) { dataDiDo.Di4 = Brushes.Red; }
                else { dataDiDo.Di4 = Brushes.White; }
                if (data[numberstartdata + 5] == 1) { dataDiDo.Di5 = Brushes.Red; }
                else { dataDiDo.Di5 = Brushes.White; }
                if (data[numberstartdata + 6] == 1) { dataDiDo.Di6 = Brushes.Red; }
                else { dataDiDo.Di6 = Brushes.White; }
                if (data[numberstartdata + 7] == 1) { dataDiDo.Di7 = Brushes.Red; }
                else { dataDiDo.Di7 = Brushes.White; }

                dataAdc0.AdcConvert = BitConverter.ToSingle(new byte[] 
                { data[numberstartadc1], data[numberstartadc1 +1], data[numberstartadc1 +2], data[numberstartadc1 + 3], }, 0);
                dataAdc0.AdcValue = (int)(dataAdc0.AdcConvert * 4095 / 3.3);

                dataAdc1.AdcConvert = BitConverter.ToSingle(new byte[]
                { data[numberstartadc2], data[numberstartadc2 +1], data[numberstartadc2 +2], data[numberstartadc2 + 3], }, 0);
                dataAdc1.AdcValue = (int)(dataAdc1.AdcConvert * 4095 / 3.3);

                dataAdc2.AdcConvert = BitConverter.ToSingle(new byte[]
                { data[numberstartadc3], data[numberstartadc3 +1], data[numberstartadc3 +2], data[numberstartadc3 + 3], }, 0);
                dataAdc2.AdcValue = (int)(dataAdc2.AdcConvert * 4095 / 3.3);

                dataAdc3.AdcConvert = BitConverter.ToSingle(new byte[]
                { data[numberstartadc4], data[numberstartadc4 +1], data[numberstartadc4 +2], data[numberstartadc4 + 3], }, 0);
                dataAdc3.AdcValue = (int)(dataAdc3.AdcConvert * 4095 / 3.3);

                //VisaNsModel.deviceNameDataBase = data[0].ToString();
            }
            catch (Exception exp)
            {
                VisaNsModel.mySession.DisposeIfNotNull();
                MessageBox.Show(exp.Message +" \n\n please check frame data or check connection------>> disconnect device ");
                
            }
        }


    }
}
