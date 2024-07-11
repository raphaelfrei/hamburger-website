using Microsoft.AspNetCore.Mvc;
using Restaurante.Repositories.Interfaces;
using Restaurante.ViewModels;

namespace Restaurante.Controllers {

    public class HamburgerController : Controller {

        private readonly IHamburgerRepository _hamburgerRepository;

        public HamburgerController(IHamburgerRepository hamburgerRepository) {
            _hamburgerRepository = hamburgerRepository;
        }

        public IActionResult List() {

            /*ViewData["PageTitle"] = "All Burgers";

            var burgers = _hamburgerRepository.Hamburgers;
            var totalBurgers = burgers.Count();

            ViewBag.TotalTitle = "Burger count: ";
            ViewBag.TotalBurgers = totalBurgers;

            return View(burgers);*/

            ViewData["PageTitle"] = "All Burgers";

            var hamburgerListViewModel = new HamburgerListViewModel();
            hamburgerListViewModel.Hamburgers = _hamburgerRepository.Hamburgers;
            var totalBurgers = hamburgerListViewModel.Hamburgers.Count();
            hamburgerListViewModel.CurrentCategory = "Current Category"; // Missing Category Implementation

            ViewBag.TotalTitle = "Burger count: ";
            ViewBag.TotalBurgers = totalBurgers;

            return View(hamburgerListViewModel);

        }

    }

}
