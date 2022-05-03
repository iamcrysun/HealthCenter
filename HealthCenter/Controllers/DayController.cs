using BLL.DTO;
using BLL.Operations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayController : ControllerBase
    {
        DBOperations db = new DBOperations();
        [HttpGet]
        public List<DayDTO> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return new List<DayDTO>();
            }
            return db.GetDays();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var day = db.GetDay(id)
    ;
            if (day == null)
            {
                return NotFound();
            }
            return Ok(day);
        }
    }
}
