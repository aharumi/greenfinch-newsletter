using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GreemfinchTest.Services.Interfaces;
using GreenfinchTest.Data;
using GreenfinchTest.Model;
using Microsoft.AspNetCore.Mvc;

namespace GreenfinchTest.Controllers
{
    [Route("api/[controller]")]
    public class NewsletterController : Controller
    {
        private readonly INewsletterService _service;
        public NewsletterController(INewsletterService service)
        {
            _service = service;
        }
        // POST api/newsletter
        [HttpPost]
        public IActionResult Post([FromBody]Newsletter newsletter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newReg = _service.RegisterNewsletter(newsletter);
            if(newReg == null)
            {
                return StatusCode((int)HttpStatusCode.Conflict);
            }

            return Ok(newsletter);
        }
    }
}
