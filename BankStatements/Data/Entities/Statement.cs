using System.ComponentModel.DataAnnotations;

namespace BankStatements.Data.Entities
{
    public class Statement
    {
        public int Id { get; init; }

        [Required]
        public string Account { get; set; }

        [Required]
        public DateTime ValueDate { get; set; }

        [Required]
        [MaxLength(80)]
        public string Description { get; set; }

        [Required]
        public decimal SumInBGN { get; set; }

        [Required]
        public decimal SumInCurrency { get; set; }

        [Required]
        public decimal ExchangeRate { get; set; }

        [Required]
        public ExchangeType ExchangeType { get; set; } //income, expense

        public TransactionType TransactionType { get; set; } //type of transaction 

        [Required]
        public int Number { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public bool isActive { get; set; } = true;
    }
}