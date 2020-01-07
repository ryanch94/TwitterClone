using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        public TweetsController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<Tweet>>> List()
        {
            return new List<Tweet>
            {
                new Tweet {Id = 1, Body = "Tweet 1"},
                new Tweet {Id = 2, Body = "Tweet 2"},
                new Tweet {Id = 3, Body = "Tweet 3"}
            };
        }
    }
}