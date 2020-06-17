using System;
using System.Collections.Generic;
using System.Text;

namespace secondtryatmaths
{
     public partial class User
    {

        public override string ToString()
        {
            return $"{Name} : {Score.Score}";
        }

    }
}