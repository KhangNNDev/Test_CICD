using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("/account")]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }   
        [HttpGet]
        [Route("/test-ci-cd")]
        public IActionResult TestCICD()
        {
            return Ok("TestCICD");
        } 
    }
}