using Restaurante.Models;

namespace Restaurante.Repositories.Interfaces {

    public interface IHamburgerRepository {

        IEnumerable<Hamburger> Hamburgers { get; }
        IEnumerable<Hamburger> FavoriteBurgers { get; }
        Hamburger GetBurgerByID(int burgerId);

    }

}
