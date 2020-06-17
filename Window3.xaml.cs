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
            ScoreBox();
        }

        private void ScoreBox()
        {
            using (var db = new UserDetailsContext())
            {
                var scoreQuery =

                from user in db.Users
                join score in db.Scores
                on user.UserId equals score.User.UserId
                select new
                {
                    User = user.Name,
                    UserScore = score.Score
                };

                BoxList.ItemsSource = scoreQuery.ToList().Take(20);

            }
        }

    }
}
