namespace ContasFinanceiras.Domain.Entities
{
    public class Anexo : BaseEntity
    {
        public string NomeArquivo { get; set; } = string.Empty;
        public string CaminhoArquivo { get; set; } = string.Empty;
        public Guid ContaFinanceiraId { get; set; }
        public ContaFinanceira ContaFinanceira { get; set; } = null!;
    }
}
