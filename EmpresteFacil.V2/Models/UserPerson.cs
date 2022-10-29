using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.V2.Models
{
    [Table("PessoasFisicas")]
    public class UserPerson : User
    {
        [Key]
        public string Cpf { get; set; }

        [Display(Name = "Documento de identidade - RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu nome")]
        [Display(Name = "Nome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Seu nome deve possuir entre 3 e 255 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu nome")]
        [Display(Name = "Sobrenome")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Seu sobrenome deve possuir entre 3 e 255 caracteres")]
        public string LastName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Tipo de usuario (comum/admin)")]
        public bool UserType { get; set; }

        public UserPerson(string cpf, string rg, string name, string lastName, DateTime dateOfBirth, bool userType, int userId, string email, string celPhone, string homePhone) 
            : base (userId, email, celPhone, homePhone)
        {
            Cpf = cpf;
            Rg = rg;
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            UserType = userType;
        }
    }
}
