using Microsoft.EntityFrameworkCore;
using Restaurante.Context;
using Restaurante.Models;
using Restaurante.Repositories.Interfaces;

namespace Restaurante.Repositories {

    public class HamburgerRepository : IHamburgerRepository {

        private readonly AppDbContext _context;

        public HamburgerRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Hamburger> Hamburgers => _context.Hamburgers.Include(c => c.Category);

        public IEnumerable<Hamburger> FavoriteBurgers => _context.Hamburgers.Where(h => h.IsFavorite).Include(h => h.Category);

        public Hamburger GetBurgerByID(int burgerId) => _context.Hamburgers.FirstOrDefault(h => h.HamburgerID == burgerId);

    }

}
