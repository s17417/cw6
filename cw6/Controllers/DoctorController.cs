using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cw6.Controllers
{
    [Route("Doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        HospitalContext context;

        public DoctorController(HospitalContext hospitalContext)
        {
            this.context = hospitalContext;
        }
    
        [HttpGet("{id}")]
        public IActionResult getDoctor(int id)
        {
           Doctor doctor= context.Find<Doctor>(id);
            if (doctor != null)
                return this.Ok(doctor);
            else return this.NotFound("Not Found");
        }

        [HttpPost]
        public IActionResult postDoctor(Doctor doctor)
        {
            try
            {
                context.Add<Doctor>(doctor);
                context.SaveChanges();
                return CreatedAtAction("getDoctor", new { id = doctor.IdDoctor }, doctor);
            }
            catch (DbUpdateException)
            {
                return this.BadRequest("nie dodano");
            }
        }

        [HttpPut("{id}")]
        public IActionResult putDoctor(int id, Doctor doctor)
        {
            if (context.Doctors.Any(entity => entity.IdDoctor == id))
            {
                doctor.IdDoctor = id;
                context.Update<Doctor>(doctor);
                context.SaveChanges();
                return CreatedAtAction("getDoctor", new { id = doctor.IdDoctor }, doctor);
            }
            else return NotFound("nie znaleziono takiego doktorka");
        }

        [HttpDelete("{id}")]
        public IActionResult deleteDoctor(int id)
        {
            Doctor doctor = context.Doctors.Find(id); 
            if (doctor!=null)
            {
                context.Remove<Doctor>(doctor);
                context.SaveChanges();
                return Ok($"doktorek o {id} usuniety");
            }
            return NotFound("nie ma takiego doktorka");

        }

    }
}