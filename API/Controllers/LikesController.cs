using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private DataContext _context;

        public LikesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> Get(int tweetId, int userId)
        {
            if (_context != null)
            {
                if (await _context.Likes.AnyAsync(a => a.TweetId == tweetId && a.UserId == userId))
                    return true;
            }

            return false;
        }
    }
}