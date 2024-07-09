using Microsoft.AspNetCore.Mvc;
using Restaurante.Repositories.Interfaces;

namespace Restaurante.Controllers {

    public class HamburgerController : Controller {

        private readonly IHamburgerRepository _hamburgerRepository;

        public HamburgerController(IHamburgerRepository hamburgerRepository) {
            _hamburgerRepository = hamburgerRepository;
        }

        public IActionResult List() {

            var burgers = _hamburgerRepository.Hamburgers;

            return View(burgers);

        }

    }

}
