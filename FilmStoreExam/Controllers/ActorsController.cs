using FilmStoreExam.Interfaces;
using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace FilmStoreExam.Controllers
{
    public class ActorsController:Controller
    {
        private readonly IActor _actors;
        private readonly IProduct _products;
        public ActorsController(IActor actors, IProduct products)
        {
            _actors = actors;
            _products = products;
        }

        public IActionResult Index(QueryOptions options)
        {
            ViewBag.Products = _products.GetAllProducts().ToList();
            var actors = _actors.GetActors(options);
            return View(actors);
        }
        [HttpPost]
        public IActionResult AddActor(Actor actor)
        {
            _actors.AddActor(actor);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult EditActor(Actor actor)
        {
            ViewBag.EditId = actor.Id;
            return View(nameof(Index), _actors.GetAllActors());
        }
        [HttpPost]
        public IActionResult DeleteActor(Actor actor)
        {
            _actors.RemoveActor(actor);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UpdateActor(int id)
        {
            ViewBag.Products = _products.GetAllProducts();
            ViewBag.Actors = _actors.GetAllActors();
            return View(id == 0 ? new Actor() : _actors.GetActor(id));
        }
        [HttpPost]
        public IActionResult UpdateActor(Actor actor)
        {
            _actors.UpdateActor(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
