using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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








        public static void alteredSaveClick(string UserString, string pass, int score)
        {

           // if the username already exists, only update their score, don't make a new account

            using (var db = new UserDetailsContext())
            {

                var MatchCount = db.Users.Count(u => u.Name == UserString);
                if (MatchCount > 0)
                {

                    UserScore scoreQuery =
                    (from userq in db.Users
                     join scoreq in db.Scores
                     on userq.UserId equals scoreq.User.UserId
                     where userq.Name == UserString
                     select scoreq).SingleOrDefault();


                    scoreQuery.Score = score;

                    db.SaveChanges();
                }

               
        
                    

                
                else
                {
                    var user = new User()
                    {
                        Name = UserString,
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
