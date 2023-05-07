using BankStatements.Data.Entities;
using CsvHelper.Configuration;
using System;

namespace BankStatements.Models
{
    public class StatementMap : ClassMap<Statement>
    {
        public StatementMap()
        {
            Map(s => s.Account).Index(0);
            Map(s => s.ValueDate).Index(1);
            Map(s => s.Description).Index(2);
            Map(s => s.SumInBGN).Index(3);
            Map(s => s.SumInCurrency).Index(4);
            Map(s => s.ExchangeRate).Index(5);
            Map(s => s.ExchangeType).Index(6);
            Map(s => s.TransactionType).Index(7);
            Map(s => s.Number).Index(8);
            Map(s => s.TransactionDate).Index(9);
        }
    }
}
