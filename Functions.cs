using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace secondtryatmaths
{
    public class Functions
    {

        public void CheckAndCreate(string UserName, string Password)
        {

            using(var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Name == UserName);
                if(MatchCount > 0)
                {
                    //check password
                }
                else { }

            }



        }




    }
}
