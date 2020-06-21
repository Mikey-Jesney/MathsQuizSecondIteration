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
    public class Win1Logic
    {





        public static string populate()
        {
            string numbers = rng();

            return getnumbers(numbers);

        }




        public static string rng()
        {
            Random rnd = new Random();
            int first = rnd.Next(2, 13);
            int second = rnd.Next(2, 13);
            StringBuilder sb = new StringBuilder();
            sb.Append(first);
            sb.Append('-');
            sb.Append(second);
            return sb.ToString();


        }

        public static string getnumbers(string nums)
        {

            char stopAt = '-';
            int charLocation = nums.IndexOf(stopAt, StringComparison.Ordinal);


            int numone = int.Parse(nums.Substring(0, charLocation));
            int numtwo = int.Parse(nums.Substring(charLocation + 1));

            return $"{numone.ToString()}-{numtwo.ToString()}";



        }


        public static bool UpdateScoreLogic(string answer, string b1, string b2)
        {


            try
            {
                if (int.Parse(answer) == int.Parse(b1) * int.Parse(b2))
                {
                    return true;
                    
                }
                return false;
            }
             catch (Exception)
            {
                return false;
                
            }

        }



    }
}
