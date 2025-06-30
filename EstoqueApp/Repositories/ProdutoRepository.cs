using EstoqueApp.Contexts;
using EstoqueApp.Entities;

namespace EstoqueApp.Repositories
{
    public class ProdutoRepository
    {
        public void Inserir(Produto produto)
        {
            using (var datacontext = new DataContext())
            {
                datacontext.Add(produto);
                datacontext.SaveChanges();
            }
        }
        public void Atualizar(Produto produto)
        {
            using (var datacontext = new DataContext())
            {
                datacontext.Update(produto);
                datacontext.SaveChanges();
            }
        }
        public void Excluir(Produto produto)
        {
            using (var datacontext = new DataContext())
            {
                datacontext.Remove(produto);
                datacontext.SaveChanges();
            }
        }
        public Produto ObterPorId(Guid id)
        {
            using (var datacontext = new DataContext())
            {
                return datacontext.Set<Produto>().Where(p => p.Id == id)
                    .FirstOrDefault(p => p.Id == id);
            }
        }

    }
}
