using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.V2.Models
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Por favor, digite seu e-mail")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone celular")]
        public string CelPhone { get; set; }

        [Display(Name = "Telefone fixo")]
        public string HomePhone { get; set; }

        public User()
        {
        }

        public User(int userId, string email, string celPhone, string homePhone)
        {
            UserId = userId;
            Email = email;
            CelPhone = celPhone;
            HomePhone = homePhone;
        }
    }
}
