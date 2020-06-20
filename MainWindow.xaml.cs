﻿using System;
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

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }



        private void sub_click(object sender, RoutedEventArgs e)
        {

            if (MainWinLogic.SubClick(UserBox.Text, PasswordBox.Password) == true) {

                UserBox.Text = "Username Already Exists";

            }
            else
            {

                Window1 win1 = new Window1(UserBox.Text, PasswordBox.Password);
                win1.Show();

                this.Close();

            }



        }

        private void UserBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void alreadyUser(object sender, RoutedEventArgs e)
        {

            Window4 win4 = new Window4();
            win4.Show();
            this.Close();

        }

        
    }
}
