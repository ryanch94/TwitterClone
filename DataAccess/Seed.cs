using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Tweets.Any())
            {
                var tweets = new List<Tweet>
                {
                    new Tweet
                    {
                        Id = 1,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 2,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 3,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 4,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 5,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 6,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 7,
                        Body = "This is a test tweet"
                    },
                    new Tweet
                    {
                        Id = 8,
                        Body = "This is a test tweet"
                    }
                };

                context.Tweets.AddRange(tweets);
                context.SaveChanges();
            }
        }
    }
}
