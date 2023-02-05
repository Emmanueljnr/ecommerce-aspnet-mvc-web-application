using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Actors.ToList(); //context.actors because we wanna return the actors that are within this context file    
            return View(data); //we'll pass the data in the view as a parameter so we can see it.
        }
    }
}

//In order to be able to use my db context, i have to inject it into the constructor
