﻿using System;
using System.Collections.Generic;
using System.Text;

namespace secondtryatmaths
{
    public class Win2Logic
    {



        public static void saveClick(string User, string pass, int score)
        {

           


            using (var db = new UserDetailsContext())
            {


                var user = new User()
                {
                    Name = User,
                    Password = pass
                };

                var uScore = new UserScore()
                {
                    Score = score,
                    User = user

                };

                db.Users.Add(user);

                db.Scores.Add(uScore);



                db.SaveChanges();
            }


            Window3 win3 = new Window3();
            win3.Show();
            


        }








        public static void alteredSaveClick(string User, string pass, int score)
        {




            using (var db = new UserDetailsContext())
            {


                var user = new User()
                {
                    Name = User,
                    Password = pass
                };

                var uScore = new UserScore()
                {
                    Score = score,
                    User = user

                };

                db.Users.Add(user);

                db.Scores.Add(uScore);



                db.SaveChanges();
            }


            Window3 win3 = new Window3();
            win3.Show();



        }




















        public static void testSaveClick(string User, string pass, int score)
        {

            using (var db = new UserDetailsContext())
            {


                var user = new User()
                {
                    Name = User,
                    Password = pass
                };

                var uScore = new UserScore()
                {
                    Score = score,
                    User = user

                };

                db.Users.Add(user);

                db.Scores.Add(uScore);



                db.SaveChanges();
            }



        }





    }
}
