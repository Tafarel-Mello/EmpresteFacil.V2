using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpresteFacil.V2.Models
{
    [Table("Emprestimos")]
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required(ErrorMessage = "Informe o valor desejado")]
        [Column(TypeName = "decimal(10, 2)")]
        public double LoanValue { get; set; }

        [Required(ErrorMessage = "Por favor, digite o numero de parcelas desejado")]
        [Display(Name = "Parcelas")]
        public int LoanInstallments { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data do inicio do Emprestimo")]
        public DateTime DateStartLoan { get; set; }

        public enum LoanType 
        {
            Pessoal,
            Automotivo,
            Consignado,
            Rotativo,
            Imobiliario
        }

        List<Installments> Installments { get; set; }

    }
}
