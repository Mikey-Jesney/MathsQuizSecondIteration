using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            BoxList.ItemsSource = Win3Logic.ScoreBox();
        }

        private void backToLogin(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();

        }



        //private void ScoreBox()
        //{
        //    using (var db = new UserDetailsContext())
        //    {
        //        var scoreQuery =

        //        from user in db.Users
        //        join score in db.Scores
        //        on user.UserId equals score.User.UserId
        //        select new User
        //        {
        //            Name = user.Name,
        //            Score = score 
        //        };

        //       var newView = scoreQuery.OrderByDescending(x => x.Score.Score);

        //        BoxList.ItemsSource = newView.ToList().Take(20);


        //    }
        //}
    }
}
