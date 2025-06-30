using EstoqueApp.Contexts;
using EstoqueApp.Entities;

namespace EstoqueApp.Repositories
{
    public class CategoriaRepository
    {
        public List<Categoria>Consultar()
        {
            using (var datacontext = new DataContext())
            {
                return datacontext.Set<Categoria>().OrderBy(p => p.Nome).ToList();
            }
        }
    }
}
