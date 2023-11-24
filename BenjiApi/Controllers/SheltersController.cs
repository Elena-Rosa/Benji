using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BenjiApi.Models;

namespace BenjiApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ShelterController : ControllerBase
    {
        private readonly BenjiApiContext _db;

        public ShelterController(BenjiApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetShelters()
        {
            var shelters = _db.Shelters.ToList();
            return Ok(shelters);
        }

        [HttpGet("{id}")]
        public IActionResult GetShelter(int id)
        {
            var shelter = _db.Shelters.FirstOrDefault(s => s.ShelterId == id);

            if (shelter == null)
            {
                return NotFound();
            }

            return Ok(shelter);
        }

        [HttpPost]
        public IActionResult CreateShelter(Shelter shelter)
        {
            _db.Shelters.Add(shelter);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetShelter), new { id = shelter.ShelterId }, shelter);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShelter(int id, Shelter shelter)
        {
            if (id != shelter.ShelterId)
            {
                return BadRequest();
            }

            _db.Entry(shelter).State = EntityState.Modified;
            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShelter(int id)
        {
            var shelter = _db.Shelters.Find(id);

            if (shelter == null)
            {
                return NotFound();
            }

            _db.Shelters.Remove(shelter);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
