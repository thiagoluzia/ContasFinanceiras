namespace ContasFinanceiras.Domain.Entities
{
    public class  Carteira : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Saldo { get; set; }
        public List<ContaFinanceira> ContasFinanceiras { get; set; } = new();
    }
}
