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
    /// Logika interakcji dla klasy SelectionMenu.xaml
    /// </summary>
    public partial class SelectionMenu : UserControl
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void OnClickInv(object sender, RoutedEventArgs e)
        {
            InvView inwerteryzacja_okno = new InvView();
            Content = inwerteryzacja_okno;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginBase logowanie = new LoginBase();
            Content = logowanie;
        }
    }
}
