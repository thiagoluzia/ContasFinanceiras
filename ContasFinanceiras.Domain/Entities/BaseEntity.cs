namespace ContasFinanceiras.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataAtualizacao { get; set; }


        public void AtualizarData()
        {
            DataAtualizacao = DateTime.UtcNow;
        }

    }
}
