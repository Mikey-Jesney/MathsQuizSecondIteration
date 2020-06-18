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
using System.Threading;
using System.Windows.Threading;

namespace secondtryatmaths
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        int count = 0;
        string User;
        string Pass;
        public Window1(string UserName, string Password)
        {
            InitializeComponent();
            populate();
            User = UserName;
            Pass = Password;
            loggedUser.Text = UserName;
            answerbox.Focus();
            Countdown(60, TimeSpan.FromSeconds(1), cur => tb.Content = cur.ToString());


        }



        void Countdown(int count, TimeSpan interval, Action<int> ts)
        {
            var dt = new System.Windows.Threading.DispatcherTimer();
            dt.Interval = interval;
            dt.Tick += (_, a) =>
            {
                if (count-- == 0)
                {
                    dt.Stop();
                    endgame();

                }

                else
                    ts(count);
            };
            ts(count);
            dt.Start();
        }

        public void endgame()
        {

            Window2 win2 = new Window2(User, Pass, count);
            win2.Show();
            this.Close();

        }



        public void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {

                updatescore();

                string numbers = rng();

                getnumbers(numbers);

                answerbox.Text = "";

            }

        }







        //public void updatescore()
        //{


        //    if (int.Parse(answerbox.Text) == int.Parse(box1.Text) + int.Parse(box2.Text))
        //    {
        //        count++;
        //        score.Text = count.ToString();
        //    }

        //}

        public void updatescore()
        {


            try
            {
                if (int.Parse(answerbox.Text) == int.Parse(box1.Text) + int.Parse(box2.Text))
                {
                    count++;
                    score.Text = count.ToString();
                }
            }
            catch (Exception)
            {
                answerbox.Text = "";
            }

        }



        private void quitHandler(object sender, RoutedEventArgs e)

        {

            endgame();


        }



        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    updatescore();

        //    string numbers = rng();

        //    getnumbers(numbers);

        //    answerbox.Text = "";





        //}

        private void populate()
        {
            string numbers = rng();

            getnumbers(numbers);

        }

        public string rng()
        {
            Random rnd = new Random();
            int first = rnd.Next(1, 99);
            int second = rnd.Next(1, 99);
            StringBuilder sb = new StringBuilder();
            sb.Append(first);
            sb.Append('-');
            sb.Append(second);
            return sb.ToString();


        }

        public void getnumbers(string nums)
        {

            char stopAt = '-';
            int charLocation = nums.IndexOf(stopAt, StringComparison.Ordinal);


            int numone = int.Parse(nums.Substring(0, charLocation));
            int numtwo = int.Parse(nums.Substring(charLocation + 1));

            changetext(numone, numtwo);


        }

        public void changetext(int numberone, int numbertwo)
        {
            box1.Text = numberone.ToString();
            box2.Text = numbertwo.ToString();
        }


    }
}