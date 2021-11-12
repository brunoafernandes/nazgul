using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Discover.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class PlaceController : Controller
    {
        [HttpGet("health")]
        public IActionResult health()
        {
            return Ok("working");
        }
    }
}
