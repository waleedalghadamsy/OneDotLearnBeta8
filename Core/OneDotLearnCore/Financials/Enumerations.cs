using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Financials
{
    public enum AccountType : byte
    {
        Assets = 1, Liabilities, Expenses, Revenues, Equity
    }

    public enum AccountSide
    {
        Credit = 1, Debit
    }

    public enum OwnerType : byte
    {
        Company = 1, Course, Instructor, Trainee
    }

    public enum TransactionType : byte
    {
        ReceivablePayment = 1, PayablePayment, Discount
    }

    public enum FinancialStatementType
    {
        IncomeStatement = 1, RetainedEarningsStatement, BalanceSheet, CashFlowEarningsStatement
    }

    public enum PaymentMethod : byte
    {
        BankTransfer = 1, WesternUnion, Cash
    }
}
