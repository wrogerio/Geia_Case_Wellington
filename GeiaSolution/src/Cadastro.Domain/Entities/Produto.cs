using System;

namespace Cadastro.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string NumeroRegristro { get; set; }
        public DateTime DataValidade { get; set; }
        public double Preco { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }
    }
}