using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace secondtryatmaths
{
    public class MainWinLogic
    {



        public static bool SubClick(string username, string password)
        {


            using (var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Name == username);
                if (MatchCount > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        }



        //for unit tests
        public static bool CheckAndCreate(string UserName, string Password)
        {

            using (var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Name == UserName);
                if (MatchCount > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        }

        //for unit tests
        public static bool CheckPassword(string UserName, string Password)
        {

            using (var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Password == Password);
                if (MatchCount > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        }


        //for unit tests
        public static bool CheckScore(string UserName, int score)
        {

            using (var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Score.Score == score);
                if (MatchCount > 0)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }

        }






    }

}

