using BankStatements.Data.Entities;
using System.Runtime.CompilerServices;

namespace BankStatements.Models
{
    public class AllStatementsQueryModel
    {
        public const int StatementsPerPage = 10;

        public string ExchangeType { get; init; }

        public string TransactionType { get; init; }

        public string SearchTerm { get; init; }

        public StatementSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalStatementsCount { get; set; }

        public IEnumerable<string> ExchangeTypes { get; set; }

        public IEnumerable<string> TransactionTypes { get; set; }

        public IEnumerable<Statement> Statements { get; set; }
            = new List<Statement>();
    }
}

