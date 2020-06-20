
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

    public partial class Window4 : Window
    {

        public Window4()
        {
            InitializeComponent();

        }



        private void sub_click2(object sender, RoutedEventArgs e)
        {

            if (Win4Logic.CheckAndCreate(UserBox.Text, PasswordBox.Password) == true) {

                Win4Logic.SubClick(UserBox.Text, PasswordBox.Password);
                this.Close();
            }
            else
            {
                UserBox.Text = "Incorrect Details";
            }

            

        }

        private void UserBox_TextChanged2(object sender, TextChangedEventArgs e)
        {

        }


        private void backCreate(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }



        



    }
}








