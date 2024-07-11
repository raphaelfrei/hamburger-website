using Restaurante.Models;

namespace Restaurante.ViewModels {

    public class HamburgerListViewModel {

        public IEnumerable<Hamburger> Hamburgers { get; set; }
        public string CurrentCategory { get; set; }

    }
}
