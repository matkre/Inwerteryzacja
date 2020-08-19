using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.OleDb;

namespace Inwerteryzacja
{
    /// <summary>
    /// Logika interakcji dla klasy BaseView.xaml
    /// </summary>
    public partial class BaseView : UserControl
    {
        List<BaseData> lista = new List<BaseData>();
        BaseConnect connect = new BaseConnect();
        public BaseView()
        {
            InitializeComponent();
            comboBoxList.ItemsSource = getItemsToListBox();
            getInformationFromBase();
        }
        private IEnumerable<string> getItemsToListBox()
        {
            yield return "Numer Seryjny";
            yield return "Nazwa Sieciowa";
            yield return "Model";
            yield return "RAM";


        }
        private void getInformationFromBase()
        {
            if (connect.connectionToDataBase())
            {
                OleDbCommand showRecord = new OleDbCommand("SELECT * FROM Komputery", connect.con);
                OleDbDataReader data = showRecord.ExecuteReader();
                while (data.Read())
                {
                    object office = data["Wersja Office"];
                    lista.Add(new BaseData()
                    {
                        Serial = data["Numer seryjny"].ToString(),
                        Name = data["Nazwa"].ToString(),
                        Model = data["Model"].ToString(),
                        Login = data["Login"].ToString(),
                        Windows = data["System operacyjny"].ToString(),
                        Office = changeOfficeVersion(office).ToString(),
                        RAM = data["RAM"].ToString()
                    });

                    DataBaseList.ItemsSource = lista;
                }
                data.Close();
            }
            connect.con.Close();
        }
        private string changeOfficeVersion(object version)
        {
            string office = "";
            switch (version)
            {
                case 1:
                    office = "Office 2016 Professional";
                    break;
                case 2:
                    office = "Office 2016 H&B";
                    break;
                case 3:
                    office = "Office 2016 Pro Plus";
                    break;
                case 4:
                    office = "Office 2013 Professional";
                    break;
                case 5:
                    office = "Office 2013 H&B";
                    break;
                case 6:
                    office = "Office 2010 Professional";
                    break;
                case 7:
                    office = "Office 2010 H&B";
                    break;
                case 8:
                    office = "Office 2010 Pro Plus";
                    break;
                case 9:
                    office = "Office 2007";
                    break;
            }
            return office;
        }
        private void OnClickSearch(object sender, RoutedEventArgs e)
        {
            if (connect.connectionToDataBase())
            {
                OleDbCommand showRecord = new OleDbCommand("SELECT * FROM Komputery", connect.con);
                OleDbDataReader data = showRecord.ExecuteReader();
                string wybor = comboBoxList.SelectedItem.ToString();
                string searchItem = searchField.Text;
                List<BaseData> searchList = new List<BaseData>();
                while (data.Read())
                {
                    if (data[wybor].ToString() == searchItem)
                    {
                        searchList.Add(new BaseData()
                        {
                            Serial = data["Numer seryjny"].ToString(),
                            Name = data["Nazwa"].ToString(),
                            Model = data["Model"].ToString(),
                            Login = data["Login"].ToString(),
                            Windows = data["System operacyjny"].ToString(),
                            Office =data["Wersja Office"].ToString(),
                            RAM = data["RAM"].ToString()
                        });
                    }
                    DataBaseList.ItemsSource = searchList;
                }
                data.Close();
            }
            connect.con.Close();

            messageLabel.Content = comboBoxList.SelectedItem;
            
        }
    }
}
