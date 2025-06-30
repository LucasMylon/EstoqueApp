namespace EstoqueApp.Entities
{
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }

        public List<Produto>? Produtos { get; set; }
    }
}
