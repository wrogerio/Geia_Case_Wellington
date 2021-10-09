using System;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Application.DTO
{
    public class ProdutoDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [MaxLength(70, ErrorMessage = "Número de caracteres inválidos!")]
        [MinLength(2, ErrorMessage = "Número de caracteres inválidos!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome da empresa é obrigatório")]
        [MaxLength(70, ErrorMessage = "Número de caracteres inválidos!")]
        [MinLength(2, ErrorMessage = "Número de caracteres inválidos!")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "O número de registro é obrigatório")]
        [MaxLength(20, ErrorMessage = "Número de caracteres inválidos!")]
        [MinLength(2, ErrorMessage = "Número de caracteres inválidos!")]
        [Display(Name = "Registro")]
        public string NumeroRegristro { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Validade")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Range(0.1, double.MaxValue, ErrorMessage = "O preço informado não é válido!")]
        public double Preco { get; set; }

        public double PrecoAnterior { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int Deleted { get; set; }
    }
}