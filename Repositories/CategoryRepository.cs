using Restaurante.Context;
using Restaurante.Models;
using Restaurante.Repositories.Interfaces;

namespace Restaurante.Repositories {

    public class CategoryRepository : ICategoryRepository {

        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;

    }

}
