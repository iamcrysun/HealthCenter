using BLL.DTO;
using BLL.Operations;
using DAL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/Doctor")]
[ApiController]

public class DoctorController : Controller
{
    DBOperations db = new DBOperations();
    [HttpGet]
    public List<DoctorDTO> GetAll()
    {
        if (!ModelState.IsValid)
        {
            return new List<DoctorDTO>();
        }
        return db.GetDoctors();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var doctor = db.GetDoctor(id)
;
        if (doctor == null)
        {
            return NotFound();
        }
        return Ok(doctor);
    }
}
