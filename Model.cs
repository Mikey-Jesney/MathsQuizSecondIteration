using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace secondtryatmaths
{
    public class UserDetailsContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<UserScore> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MathsUserDetails;");

    }


    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual UserScore Score { get; set; }



    }

    public class UserScore
    {
        [ForeignKey("User")]
        [Key]
        public int ScoreID { get; set; }
        public int Score { get; set; }
        public virtual User User { get; set; }
    }


}
