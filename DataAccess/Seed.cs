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
            context.Users.RemoveRange(context.Users);
            context.Likes.RemoveRange(context.Likes);
            context.SaveChanges();

            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Tweets', RESEED, 0)");
            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Users', RESEED, 0)");
            context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Likes', RESEED, 0)");
            
            var users = new List<User>
            {
                new User { FirstName = "Ryan", LastName = "Challis", Username = "RyanChallis" }
            };


            context.Users.AddRange(users);
            context.SaveChanges();

            var user = context.Users.First();

            var tweets = new List<Tweet>
            {
                new Tweet
                {
                    //Id = 1,
                    Body = "This is a test tweet",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 2,
                    Body = "This is a test tweet 2",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 3,
                    Body = "This is a test tweet 3",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 4,
                    Body = "This is a test tweet 4",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 5,
                    Body = "This is a test tweet 5",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 6,
                    Body = "This is a test tweet 6",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 7,
                    Body = "This is a test tweet 7",
                    User = user,
                    UserId = user.UserId
                },
                new Tweet
                {
                    //Id = 8,
                    Body = "This is a test tweet 8",
                    User = user,
                    UserId = user.UserId
                }
            };                       

            context.Tweets.AddRange(tweets);

            context.SaveChanges();

            Like like = new Like() { Tweet = context.Tweets.Find(3), User = context.Users.First() };
            context.Likes.Add(like);

            context.SaveChanges();
        }
    }
}
