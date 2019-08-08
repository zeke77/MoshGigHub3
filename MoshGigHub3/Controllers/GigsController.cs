using Microsoft.AspNet.Identity;
using MoshGigHub3.Models;
using MoshGigHub3.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MoshGigHub3.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.OrderBy(g => g.Name).ToList()
            };

            return View(viewModel);

        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {

            
            //var artist = _context.Users.Single(u => u.Id == artistID);
            //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("index", "Home");

        }
    }
}