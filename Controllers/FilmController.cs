using FilmDB.Models;
using FilmDB.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmManager _manager;
        public FilmController(FilmManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var film = new FilmModel()
            {
                Title = "One day",
                Year = 2011
            };

            await _manager.AddFilmAsync(film);

            return View();
        }
    }
}