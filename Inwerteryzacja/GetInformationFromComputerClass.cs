using System;
using System.Management;
using System.Windows.Media;
using Microsoft.Win32;

namespace Inwerteryzacja
{
    class GetInformationFromComputerClass
    {
        InvView invView = new InvView();
        //KONSTRUKTOR
        public GetInformationFromComputerClass(string textNameComputer, string userName, string userPass)
        {
            //GetSystemVersion(textNameComputer, userName, userPass);
            //GetBiosSerialNumber(textNameComputer, userName, userPass);
        }
        //POŁĄCZENIE Z KOMPUTEREM
        private ManagementScope ConnectToComputer(string textNameComputer, string userName, string userPass)
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Authority = "ntlmdomain:PROGRES.LOCAL";
            ManagementScope scope = new ManagementScope("\\\\" + textNameComputer + ".PROGRES.LOCAL" + "\\root\\cimv2", options);
            scope.Options.EnablePrivileges = true;
            scope.Options.Username = userName;
            scope.Options.Password = userPass;
            scope.Options.Authentication = AuthenticationLevel.PacketPrivacy;
            scope.Options.Impersonation = ImpersonationLevel.Impersonate;
            scope.Connect();
            if (textNameComputer == null || textNameComputer == "")
            {
                invView.MessageLabel.Content = "Podaj nazwę komputera lub adres IP";
            }
            return scope;
        }
        //WERSJA SYSTEMU
        public string WindowsBitVersion()
        {
            if (IntPtr.Size == 8)
            {
                return "x64";
            }
            else if (IntPtr.Size == 4)
            {
                return "x86";
            }
            return "";
        }
        //BIOS
        public string GetBiosSerialNumber(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_BIOS");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["SerialNumber"].ToString(); //+ "  Wersja: " + service["BIOSVersion"];
                }
            }
            catch (Exception ex)
            {
                //InvView inv = new InvView();
                //inv.messageLabel.Foreground = new SolidColorBrush(Colors.Green);
                //inv.messageLabel.Content = ex.Message.ToString();
                return ex.Message;
            }
            return "";
        }
        //SYSTEM
        public string GetSystemVersion(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["Caption"].ToString() + " " + service["OSArchitecture"].ToString() + ", Wersja: " + service["Version"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //NAZWA KOMPUTERA
        public string GetComputerName(string textNameComputer, string userName, string userPass)
        {

            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["csname"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //NAZWA UŻYTKOWNIKA
        public string GetUserName(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_ComputerSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["username"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //DYSK
        public string GetDiskSize(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_DiskDrive");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return (Math.Round(((Convert.ToDouble(service["Size"]) / 1024) / 1024) / 1024, 2)).ToString() + " GB" + " ID: " + service["DeviceID"];
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //MODEL LAPTOPA
        public string GetModelComputer(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_ComputerSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["Manufacturer"].ToString() + " " + service["Model"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //NAZWA PROCESORA
        public string GetProcessorName(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_Processor");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return service["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        //PAMIĘĆ RAM
        public string GetRAMSize(string textNameComputer, string userName, string userPass)
        {
            try
            {
                ObjectQuery query = new ObjectQuery("select * from Win32_ComputerSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ConnectToComputer(textNameComputer, userName, userPass), query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject service in queryCollection)
                {
                    return Math.Round((((Convert.ToDouble(service["TotalPhysicalMemory"]))/1024)/1024)/1024, 2).ToString() + " GB";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        public string GetWindowsKey(string textNameComputer, string userName, string userPass)
        {
            string keyWindows="";
            try
            {
                /*const uint CLASSES_ROOT = 0x80000000;
                const uint CURRENT_USER = 0x80000001;
                const uint LOCAL_MACHINE = 0x80000002;
                const uint USERS = 0x80000003;
                const uint CURRENT_CONFIG = 0x80000005;*/

                ManagementClass registry = new ManagementClass(ConnectToComputer(textNameComputer, userName, userPass), new ManagementPath("StdRegProv"), null);
                ManagementBaseObject baseObject = registry.GetMethodParameters("GetStringValue");
                baseObject["hDefKey"] = 0x80000002;
                baseObject["sSubKeyName"] = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
                RegistryKey rkey = Registry.LocalMachine;
                RegistryKey rkRun;
                rkRun = rkey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                string[] s_arr = rkRun.GetValueNames();
                foreach (string value in s_arr)
                {
                    keyWindows = "Value: " + value + " Value Data: " + rkey.GetValue("DigitalProductID"); //wyświetlenie nazw właściwości i ich wartości
                }
                /*ManagementBaseObject outParams = registry.InvokeMethod("GetStringValue", baseObject, null);
                if (outParams.Properties["sValue"].Value != null)
                {
                   return keyWindows = outParams.Properties["sValue"].Value.ToString();
                }*/
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           //string key = DecodeKey(keyWindows);
            return keyWindows;
        }
        public string DecodeKey()//byte[] key)
        {
            //const string keyPath = @"Software\Microsoft\Windows NT\CurrentVersion";
            char[] ZnakiDozwoloneWKluczuWindows = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P', 'Q', 'R', 'T', 'V', 'W', 'X', 'Y', '2', '3', '4', '6', '7', '8', '9'  };
            char[] KluczWidnowsa = new char[25];
            //byte[] key = {0xFE, 0x04, 0x00, 0xE8, 0x44, 0x28, 0x31, 0xEE, 0xC4, 0x5F, 0xF4, 0xF7, 0x92, 0x69, 0x09 };
            byte[] key = {0xD9, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x50, 0x2F, 0x01, 0x6B, 0x7D, 0x17, 0x69, 0x72, 0x09};
            //byte[] key = { 0xEC, 0x0C, 0x00, 0x00, 0x00, 0x00, 0xA8, 0xD2, 0x7B, 0x6E, 0x89, 0x81, 0x4F, 0x6D, 0x09 };
            int i, j, k;
            for (i = KluczWidnowsa.Length-1; i >= 0; i--)
            {
                k = 0;
                for (j = key.Length-1; j >= 0; j--)
                {
                    k = (k << 8) + key[j];
                    key[j] = (byte)(k / 24);
                    k = k % 24;
                }
                KluczWidnowsa[i] = ZnakiDozwoloneWKluczuWindows[k];
            }
            return KluczWidnowsa.ToString();
        }

    }
}
