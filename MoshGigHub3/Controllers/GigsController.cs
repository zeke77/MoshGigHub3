using MoshGigHub3.Models;
using MoshGigHub3.ViewModels;
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
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.OrderBy(g => g.Name).ToList()
            };

            return View(viewModel);
        }
    }
}