using Restaurante.Models;

namespace Restaurante.Repositories.Interfaces {

    public interface ICategoryRepository {

        IEnumerable<Category> Categories { get; }

    }
}
