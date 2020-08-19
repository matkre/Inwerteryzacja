using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Inwerteryzacja
{
    /// <summary>
    /// Logika interakcji dla klasy EditAddView.xaml
    /// </summary>
    public partial class EditAddView : UserControl
    {
        BaseConnect connectToBase = new BaseConnect();
        public EditAddView()
        {
            InitializeComponent();
            typeList.ItemsSource = getTypeDevice();
            systemList.ItemsSource = getWindowsV();
            officeList.ItemsSource = getOfficeV();
            testData(serialText.Text);
        }
        private bool testData(string s)
        {
            bool existInBase = false;
            if (connectToBase.connectionToDataBase())
            {
                OleDbCommand showRecord = new OleDbCommand("SELECT * FROM Komputery", connectToBase.con);
                OleDbDataReader data = showRecord.ExecuteReader();
                while (data.Read())
                {
                    if (data["Numer seryjny"].ToString() == s)
                    {
                        LogField.Foreground = new SolidColorBrush(Colors.YellowGreen);
                        LogField.Content += "Laptop jest już w bazie! \n";
                        existInBase = true;
                    }
                    else existInBase = false;
                }
                data.Close();
            }
            connectToBase.con.Close();
            return existInBase;
        }
        private IEnumerable<string> getWindowsV()
        {
            yield return "Windows 10 Pro";
            yield return "Windows 10 Home";
            yield return "Windows 8 Pro";
            yield return "Windows 8 Home";
            yield return "Windows 7 Pro";
            yield return "Windows 7 Home";
        }
        private IEnumerable<string> getOfficeV()
        {
            yield return "Office 2019 Pro";
            yield return "Office 2019 H&B";
            yield return "Office 2016 Pro";
            yield return "Office 2016 H&B";
            yield return "Office 2013 Pro";
            yield return "Office 2013 H&B";
        }
        private IEnumerable<string> getTypeDevice()
        {
            yield return "Laptop";
            yield return "Desktop";
        }
        private void AddToBase(List<BaseTemplate> li)
        {
            if (connectToBase.connectionToDataBase())
            {
                try
                {
                    OleDbCommand insertDataToBaseCommand = new OleDbCommand
                        ("INSERT INTO Komputery ([Numer seryjny], [Nazwa], [Model], [Rodzaj], [System operacyjny], [Klucz Windows], [Procesor], [RAM], [Dysk], [Hasło Bitlocker], [Klucz odzyskiwania Bitlocker], [Data zakupu], [Login], [Uwagi], [Numer FV], [Wersja Office], [Login Office], [Hasło Office], [Klucz Office])"
                        + "VALUES (@serial, @name, @model, @type, @system, @win, @proc, @ram, @disk, @b_pass, @b_key, @buy_date, @login, @coment, @nr_fv, @office, @l_office, @p_office, @k_office)"
                        , connectToBase.con);
                    insertDataToBaseCommand.Parameters.AddWithValue("@serial", li[0].Serial);
                    insertDataToBaseCommand.Parameters.AddWithValue("@name", li[0].Nazwa);
                    insertDataToBaseCommand.Parameters.AddWithValue("@model", li[0].Model);
                    insertDataToBaseCommand.Parameters.AddWithValue("@type", typeList.SelectedIndex/*li[0].Rodzaj*/);
                    insertDataToBaseCommand.Parameters.AddWithValue("@system", systemList.SelectedIndex/*li[0].System*/);
                    insertDataToBaseCommand.Parameters.AddWithValue("@win", li[0].Klucz_Win);
                    insertDataToBaseCommand.Parameters.AddWithValue("@proc", li[0].Procesor);
                    insertDataToBaseCommand.Parameters.AddWithValue("@ram", li[0].RAM);
                    insertDataToBaseCommand.Parameters.AddWithValue("@disk", li[0].Dysk);
                    insertDataToBaseCommand.Parameters.AddWithValue("@b_pass", li[0].Btl_Pass);
                    insertDataToBaseCommand.Parameters.AddWithValue("@b_key", li[0].Btl_Klucz_Odz);
                    insertDataToBaseCommand.Parameters.AddWithValue("@buy_date", li[0].Data_zak);
                    insertDataToBaseCommand.Parameters.AddWithValue("@login", li[0].Login);
                    insertDataToBaseCommand.Parameters.AddWithValue("@coment", li[0].Uwagi);
                    insertDataToBaseCommand.Parameters.AddWithValue("@nr_fv", li[0].Nr_FV);
                    insertDataToBaseCommand.Parameters.AddWithValue("@office", officeList.SelectedIndex/*li[0].Office*/);
                    insertDataToBaseCommand.Parameters.AddWithValue("@l_office", li[0].Login_Office);
                    insertDataToBaseCommand.Parameters.AddWithValue("@p_office", li[0].Haslo_Office);
                    insertDataToBaseCommand.Parameters.AddWithValue("@k_office", li[0].Klucz_Office);
                    insertDataToBaseCommand.ExecuteNonQuery();
                    LogField.Foreground = new SolidColorBrush(Colors.Green);
                    LogField.Content += "Dane zostały dodane do bazy \n";
                }
                catch (Exception ex)
                {
                    LogField.Foreground = new SolidColorBrush(Colors.Red);
                    LogField.Content += "Nie udało się dodać! \n";
                    LogField.Content += ex.Message + "\n";
                }
            }
            connectToBase.con.Close();
        }
        private void UpdateDataInBase(string s, string n)
        {
            if (connectToBase.connectionToDataBase())
            {
                try
                {
                    OleDbCommand insertDataToBaseCommand = new OleDbCommand("UPDATE Komputery SET [Numer seryjny] = @serial, [Nazwa] = @name WHERE [Numer seryjny] = @serial", connectToBase.con);
                    insertDataToBaseCommand.Parameters.AddWithValue("@serial", s);
                    insertDataToBaseCommand.Parameters.AddWithValue("@name", n);
                    insertDataToBaseCommand.ExecuteNonQuery();
                    LogField.Foreground = new SolidColorBrush(Colors.Green);
                    LogField.Content += "Dane zostały zaktualizowane w bazie \n";
                }
                catch (Exception ex)
                {
                    LogField.Foreground = new SolidColorBrush(Colors.Red);
                    LogField.Content += "Błąd przy aktualizacji! \n";
                }
            }
            connectToBase.con.Close();
        }
        private void AddModifyButton_Click(object sender, RoutedEventArgs e)
        {
            List<BaseTemplate> list = new List<BaseTemplate>();
            list.Clear();
            list.Add(new BaseTemplate()
            {
                Serial = serialText.Text.ToString(),
                Nazwa = nameText.Text.ToString(),
                Model = modelText.Text.ToString(),
                Rodzaj = typeList.SelectedItem.ToString(),
                System = systemList.SelectedItem.ToString(),
                Klucz_Win = windowsKeyText.Text.ToString(),
                Procesor = processorText.Text.ToString(),
                RAM = ramText.Text.ToString(),
                Dysk = diskText.Text.ToString(),
                Btl_Pass = bitlockerText.Text.ToString(),
                Btl_Klucz_Odz= recoveryBitLockerKeyText.Text.ToString(),
                Data_zak = buyDateText.Text.ToString(),
                Login = loginText.Text.ToString(),
                Uwagi = commentsText.Text.ToString(),
                Nr_FV = fvText.Text.ToString(),
                Office = officeList.SelectedItem.ToString(),
                Login_Office = loginOfficeText.Text.ToString(),
                Haslo_Office = passOfficeText.Text.ToString(),
                Klucz_Office = keyOfficeText.Text.ToString()
            });
            if (testData(serialText.Text) == true)
            {
                MessageBoxButton messageButton = MessageBoxButton.YesNo;
                MessageBoxResult message = MessageBox.Show("Laptop jest w bazie. Kontynuować ?", "Notatnik", messageButton);
                switch (message)
                {
                    case MessageBoxResult.Yes:
                        UpdateDataInBase(serialText.Text.ToString(), nameText.Text.ToString());
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }
            else AddToBase(list);

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            LogField.Content = "";
        }

        private void OnClickBackButton(object sender, RoutedEventArgs e)
        {
            InvView invMenu = new InvView();
            Content = invMenu;
        }
    }
}
