using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private DataContext _context;

        public TweetsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tweet>>> List()
        {
            return await _context.Tweets.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(Tweet tweet)
        {
            _context.Tweets.Add(tweet);
            int res = await _context.SaveChangesAsync();
            if (res > 0)
                return tweet.Id;
            else
                return 0;
        }
    }
}