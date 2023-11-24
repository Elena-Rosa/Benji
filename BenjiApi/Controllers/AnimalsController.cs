using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BenjiApi.Models;
using System.Collections.Generic;
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
        public IActionResult GetAnimals()
        {
            var animals = _db.Animals.ToList();
            return Ok(animals);
        }

        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            var animal = _db.Animals.FirstOrDefault(a => a.AnimalId == id);

            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost]
        public IActionResult CreateAnimal(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnimal(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animal = _db.Animals.Find(id);

            if (animal == null)
            {
                return NotFound();
            }

            _db.Animals.Remove(animal);
            _db.SaveChanges();

            return NoContent();
        }
    }
}

