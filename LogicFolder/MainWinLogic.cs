﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace secondtryatmaths
{
    public class MainWinLogic
    {

        public static bool CheckAndCreate(string UserName)
        {

            using (var db = new UserDetailsContext())
            {
                var MatchCount = db.Users.Count(u => u.Name == UserName);
                if (MatchCount > 0)
                {
                    return true;
                    
                }
                else {
                    return false;
           
                }

            }



        }



        public static void SubClick(string username, string password)
        {
            

                Window1 win1 = new Window1(username, password);
                win1.Show();

       
                
            }



        }






    }

