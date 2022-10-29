using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.V2.Models
{
    [Table("Enderecos")]
    public class Adress
    {
        [Key]
        [Display(Name = "Endereco")]
        [Required(ErrorMessage = "Por favor, informe seu endereco")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Complemento")]
        public string EnderecoComplemento { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string? Pais { get; set; }
    }
}
