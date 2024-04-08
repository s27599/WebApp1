using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/animal")]
[ApiController]
public class AnimalController : ControllerBase  
{
    [HttpGet]
    public Animal getAnimals()
    {
        return new Animal(1, "jake", Categories.Dog, 123.3, "red");
    }
    
    
}