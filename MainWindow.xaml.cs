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

            using (var db = new UserDetailsContext())
            {
                string _user = UserBox.Text;
                string _pass = PasswordBox.Password;
                _userName = UserBox.Text;
                _password = PasswordBox.Password;


                var user = new User()
                {
                    Name = _user,
                    Password = _pass
                };

                db.Users.Add(user);

                db.SaveChanges();







            }


            //CheckAndCreate();
            Window1 win1 = new Window1(_userName, _password);
            win1.DataContext = this;
            win1.Show();
            this.Close();

        }
    }
}
