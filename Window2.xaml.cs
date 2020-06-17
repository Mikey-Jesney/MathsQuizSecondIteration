using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace secondtryatmaths
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(string UserName, int Score)
        {
            var window1 = this.DataContext;
            InitializeComponent();
            score.Text = Score.ToString();
            name.Text = UserName;
        }

    }
}
