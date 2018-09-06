using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values
        [HttpGet("{valueFirst}/{valueSecond}")]
        public double Plus(double valueFirst, double valueSecond)
        {
            var result = valueFirst+valueSecond;
            return result;
        }

    }
}