using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/Visit")]
[ApiController]

public class VisitController : ControllerBase
{

    [HttpGet]
    public ActionResult<List<Visit>> GetVisits()
    {
        return Data.GetVisits();
    }    
    
    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        Data.GetVisits().Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
   
    
    
}