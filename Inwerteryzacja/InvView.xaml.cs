using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Inwerteryzacja
{
    public partial class InvView : UserControl
    {
        public InvView()
        {
            InitializeComponent();
        }
        List<ComputerData> lista = new List<ComputerData>();

        private void OnClickDownload(object sender, RoutedEventArgs e)
        {
            messageLabel.Content = "Łączenie z komputerem";
            lista = SaveDataIntoList();
            ComputerDataList.ItemsSource = lista;
            CompNameTextField.Text = "";
        }

        private List<ComputerData> SaveDataIntoList() 
        {
            List<ComputerData> dataComputer = new List<ComputerData>();
            string computerNameInfo = CompNameTextField.Text;
            string user = userNameText.Text;
            string pass = passText.Password.ToString();
            GetInformationFromComputerClass getInformation = new GetInformationFromComputerClass(computerNameInfo, user, pass);
            progressBar.Maximum = 100;
            progressBar.Value = 10;
            messageLabel.Foreground = new SolidColorBrush(Colors.Green);
            messageLabel.Content = "Połączono";
            dataComputer.Clear();
            Thread.Sleep(1000);
            //try
            //{
                dataComputer.Add(new ComputerData() { Name = "Numer Seryjny", Data = getInformation.GetBiosSerialNumber(computerNameInfo, user, pass) });
           // }catch(Exception ex)
            //{
             //   messageLabel.Content = ex.Message.ToString();
            //}
            progressBar.Value = 30;
            dataComputer.Add(new ComputerData() { Name = "Nazwa komputera", Data = getInformation.GetComputerName(computerNameInfo, user, pass) });
            dataComputer.Add(new ComputerData() { Name = "Model", Data = getInformation.GetModelComputer(computerNameInfo, user, pass) });
            progressBar.Value = 60;
            Thread.Sleep(1000);
            dataComputer.Add(new ComputerData() { Name = "Wersja Systemu", Data = getInformation.GetSystemVersion(computerNameInfo, user, pass) });
            dataComputer.Add(new ComputerData() { Name = "Procesor", Data = getInformation.GetProcessorName(computerNameInfo, user, pass) });
            progressBar.Value = 90;
            Thread.Sleep(1000);
            dataComputer.Add(new ComputerData() { Name = "RAM", Data = getInformation.GetRAMSize(computerNameInfo, user, pass) });
            dataComputer.Add(new ComputerData() { Name = "Dysk", Data = getInformation.GetDiskSize(computerNameInfo, user, pass) });
            dataComputer.Add(new ComputerData() { Name = "Użytkownik", Data = getInformation.GetUserName(computerNameInfo, user, pass) });
            progressBar.Value = 100;
            return dataComputer;
        }

        private void OnClickBackButton(object sender, RoutedEventArgs e)
        {
            SelectionMenu firstMenu = new SelectionMenu();
            Content = firstMenu;
        }

        private void OnClickReload(object sender, RoutedEventArgs e)
        {
            Content = new InvView();
        }

        private void EditAddButton_Click(object sender, RoutedEventArgs e)
        {

            EditAddView editAddWindow = new EditAddView();
            sentData(editAddWindow);
            Content = editAddWindow;
        }
        private void sentData(EditAddView window)
        {
            window.serialText.Text = lista[0].Data;
            window.nameText.Text = lista[1].Data;
            window.modelText.Text = lista[2].Data;
            window.systemList.Text = lista[3].Data;
            window.processorText.Text = lista[4].Data;
            window.ramText.Text = lista[5].Data;
            window.diskText.Text = lista[6].Data;
            window.loginText.Text = lista[7].Data;
            window.LogField.Background = new SolidColorBrush(Colors.Black);
            window.LogField.Foreground = new SolidColorBrush(Colors.Green);
            window.LogField.Content = "Dane zostały pobrane \n";
        }
    }
}
