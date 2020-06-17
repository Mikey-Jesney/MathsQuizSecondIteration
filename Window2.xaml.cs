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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        public string _user;
        public string _pass;
        public int _score;

        public Window2(string UserName, string Pass, int Score)
        {
            var window1 = this.DataContext;
            InitializeComponent();
            _user = UserName;
            _pass = Pass;
            _score = Score;
            score.Text = Score.ToString();
            name.Text = UserName;
        }


        private void save_click(object sender, RoutedEventArgs e)
        {


            using (var db = new UserDetailsContext())
            {


                var user = new User()
                {
                    Name = _user,
                    Password = _pass
                };

                var uScore = new UserScore()
                {
                    Score = _score,
                    User = user

                };

                db.Users.Add(user);

                db.Scores.Add(uScore);

              

                db.SaveChanges();
            }


            Window3 win3 = new Window3();
            win3.Show();
            this.Close();


        }

    }

}

