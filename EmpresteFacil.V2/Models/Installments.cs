using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace EmpresteFacil.V2.Models
{
    [Table("Parcelas")]
    internal class Installments
    {
        [Key]
        public int InstallmentsId { get; set; }

        [Display(Name = "Valor da parcela")]
        [Column(TypeName = "decimal(10 ,2)")]
        public double InstallmentsValue { get; set; }

        [Display(Name = "Data de vencimento da parcela")]
        [DataType(DataType.DateTime)]
        public DateTime InstallmentDueDate { get; set; }

        [Display(Name = "Taxa de juros")]
        [Column(TypeName = "decimal(10, 2)")]
        public double Fees { get; set; }

        [Display(Name = "Valor da amortizacao")]
        [Column(TypeName = "decimal(10, 2)")]
        public double Amortization { get; set; }

        [Display(Name = "Data de pagamento")]
        [DataType(DataType.DateTime)]
        public DateTime PayDay { get; set; }

        [Display(Name = "Valor de multa")]
        [Column(TypeName = "decimal(10 ,2)")]
        public double FineAmount { get; set; }

        public enum InstallmentsStatus 
        {
            Pago,
            Atraso
        }

        public int LoanId { get; set; }
        public virtual Loan Loan { get; set; }
    }
}