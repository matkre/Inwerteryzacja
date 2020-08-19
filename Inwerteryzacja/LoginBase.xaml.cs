using System;
using System.Collections.Generic;
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

namespace Inwerteryzacja
{
    /// <summary>
    /// Logika interakcji dla klasy LoginBase.xaml
    /// </summary>
    public partial class LoginBase : UserControl
    {
        public LoginBase()
        {
            InitializeComponent();
        }
        public void OnClickLoginButton(object sender, RoutedEventArgs e)
        {
            messageLabel.Content = "";
            BaseConnect connect = new BaseConnect();
            //string pass = passText.Text;
            //BaseConnect.pass = passText.Password;
            if (connect.connectionToDataBase() == true)
            {
                BaseView wyswietl_baze = new BaseView();
                Content = wyswietl_baze;
                messageLabel.Content = "Połączono";
            }
            else
            {
                messageLabel.Foreground = new SolidColorBrush(Colors.Red);
                messageLabel.Content = "Brak połączenia z bazą lub podane hasło jest nieprawidłowe";
            }
        }
    }
}
