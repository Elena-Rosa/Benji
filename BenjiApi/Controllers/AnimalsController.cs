using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BenjiApi.Models;
using System.Linq;

namespace BenjiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly BenjiApiContext _db;

        public AnimalController(BenjiApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string name, int minimumAge, string breed, string gender, string adoptionStatus)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (minimumAge != 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (adoptionStatus != null)
      {
        query = query.Where(entry => entry.AdoptionStatus == adoptionStatus);
      }

      return await query.ToListAsync();
    }

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            Animal animal = await _db.Animals.FindAsync(id); 

            if (animal == null)
            {
                return NotFound();
            }

            return (animal);
        }

        [HttpPost]
        public async Task<ActionResult<Animal>> Post(Animal animal)
        {
            _db.Animals.Add(animal);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _db.Animals.Update(animal);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
         private bool AnimalExists(int id)
        {
            return _db.Animals.Any(e => e.AnimalId == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            Animal animal = await _db.Animals.FindAsync(id);
            if (animal == null)
            {
            return NotFound();
            }

            _db.Animals.Remove(animal);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

