using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.ViewModels;

namespace mvc.Controllers
{
    [Route("[controller]")]
    public class MathController : Controller
    {
        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {   
            _logger = logger;
        }

        [HttpGet("sqrt")]
        public IActionResult SquareRoot()
        {
            return View();
        }

        [HttpPost("sqrt")]
        public IActionResult SquareRoot([FromForm]SquareRootViewModel model)
        {
            var disc = System.Math.Pow(model.B, 2) - 4 * model.A * model.C;

            model.HasRoots = disc >= 0;

            if(disc == 0)
            {
                model.X1 = model.X2 = $"{(-1) * model.B / (model.A * 2)}";
            }
            else if(disc > 0)
            {
                model.X1 = $"{(-1) * model.B + System.Math.Sqrt(disc) / (model.A * 2)}";
                model.X2 = $"{(-1) * model.B - System.Math.Sqrt(disc) / (model.A * 2)}";
            }

            return View(model);
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }
    }
}