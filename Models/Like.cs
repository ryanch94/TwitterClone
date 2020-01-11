using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Like
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int TweetId { get; set; }
        public virtual Tweet Tweet { get; set; }
    }
}
