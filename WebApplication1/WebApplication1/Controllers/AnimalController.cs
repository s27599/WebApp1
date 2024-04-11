using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/animal")]
[ApiController]
public class AnimalController : ControllerBase
{
    
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(Data.GetAnimals());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimals(int id)
    {
        var animal = Data.GetAnimals().FirstOrDefault(an => an.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        Data.GetAnimals().Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = Data.GetAnimals().FirstOrDefault(an => an.Id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        Data.GetAnimals().Remove(animalToEdit);
        Data.GetAnimals().Add(animal);
        return NoContent();
    }


    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        
        var animalToEdit = Data.GetAnimals().FirstOrDefault(an => an.Id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        Data.GetAnimals().Remove(animalToEdit);
        return NoContent();
    }
    
    
    
}