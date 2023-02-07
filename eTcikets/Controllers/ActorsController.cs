using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get Actors/Create
        public async Task<IActionResult> Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor) 
        {
            //if model state isnt valid
            if (!ModelState.IsValid) 
            {
                return View(); //this will return the exact same view, but itll have the model state errors, cos we already defined them in our Actors Model for validation
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}

//In order to be able to use my db context, i have to inject it into the constructor
