namespace EstoqueApp.Entities
{
    public class Produto
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
