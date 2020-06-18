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

namespace secondtryatmaths
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string _userName;
        private string _password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sub_click(object sender, RoutedEventArgs e)
        {

                _userName = UserBox.Text;
                _password = PasswordBox.Password;



            //CheckAndCreate();
            Window1 win1 = new Window1(_userName, _password);
            win1.Show();
            this.Close();

        }

        private void UserBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
