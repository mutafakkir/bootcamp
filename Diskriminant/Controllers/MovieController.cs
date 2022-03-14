using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.ViewModels;

namespace mvc.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet("movie")]
        public IActionResult Movie()
        {
            return View();
        }

        [HttpPost("movie")]
        public IActionResult Movie([FromForm]MovieViewModel model)
        {
            return View(model);
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }

    }
}