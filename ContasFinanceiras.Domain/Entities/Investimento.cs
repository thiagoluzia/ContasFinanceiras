namespace ContasFinanceiras.Domain.Entities
{
    public class Investimento : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public bool IncluirNoSaldo { get; set; } = true;
    }
}
