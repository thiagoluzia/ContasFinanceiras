namespace ContasFinanceiras.Domain.Entities
{
    public class  ContaFinanceira : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; } = false;
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;
        public Guid CarteiraId { get; set; }
        public Carteira Carteira { get; set; } = null!;
        public List<Anexo> Anexos { get; set; } = new();
    }
}
