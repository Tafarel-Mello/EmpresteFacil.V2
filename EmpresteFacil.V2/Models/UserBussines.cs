using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.V2.Models
{
    [Table("Usuarios Pessoa Judirica")]
    public class UserBussines : User
    {
        [Key]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua Razao Social")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "A razao social deve ter entre 3 e 250 caracteres")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Data de constituicao ou inicio das atividades")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de data invalido")]
        public DateTime DataConstituicao { get; set; }

        public UserBussines(string cNPJ, string razaoSocial, DateTime dataConstituicao, int userId, string email, string celPhone, string homePhone) 
            : base(userId, email, celPhone, homePhone)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            DataConstituicao = dataConstituicao;
        }
    }
}
