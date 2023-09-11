using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace custommiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string>
        {
            "Value1",
            "Value2",
            "Value3"
        };

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound();
            }

            string value = values[id];
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest("Value cannot be empty or whitespace.");
            }

            values.Add(value);
            return CreatedAtAction(nameof(Get), new { id = values.Count - 1 }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
            {
                return NotFound();
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest("Value cannot be empty or whitespace.");
            }

            values[id] = value;
            return NoContent();
        }
    }
}
