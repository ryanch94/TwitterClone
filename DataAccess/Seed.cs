using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            context.Tweets.RemoveRange(context.Tweets);            
            context.SaveChanges();

            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Tweets', RESEED, 0)");

            var tweets = new List<Tweet>
            {
                new Tweet
                {
                    //Id = 1,
                    Body = "This is a test tweet"
                },
                new Tweet
                {
                    //Id = 2,
                    Body = "This is a test tweet 2"
                },
                new Tweet
                {
                    //Id = 3,
                    Body = "This is a test tweet 3"
                },
                new Tweet
                {
                    //Id = 4,
                    Body = "This is a test tweet 4"
                },
                new Tweet
                {
                    //Id = 5,
                    Body = "This is a test tweet 5"
                },
                new Tweet
                {
                    //Id = 6,
                    Body = "This is a test tweet 6"
                },
                new Tweet
                {
                    //Id = 7,
                    Body = "This is a test tweet 7"
                },
                new Tweet
                {
                    //Id = 8,
                    Body = "This is a test tweet 8"
                }
            };

            context.Tweets.AddRange(tweets);
            context.SaveChanges();
        }
    }
}
