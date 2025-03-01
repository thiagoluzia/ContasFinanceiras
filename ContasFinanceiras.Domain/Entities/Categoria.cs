namespace ContasFinanceiras.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public bool Entrada { get; set; }
        public List<ContaFinanceira> ContasFinanceiras { get; set; } = new();
    }
}
