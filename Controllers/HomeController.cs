using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HomeController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }
    [HttpGet]
    [Route("projects")]
    public IActionResult Projects()
    {
        return View("Projects");
    }
    [HttpGet]
    [Route("contact")]
    public IActionResult Contact()
    {
        return View("Contact");
    }
}