using System;

namespace BankAdministration.Core.Entities
{

    // referente à conta-corrente
    public class CheckingAccount : BankAccount
    {
        public decimal CheckingAccountMaintenance { get; private set; } //taxa manutenção
        public decimal Limit { get; private set; }

        public CheckingAccount(Client client, decimal limit) : base(client)
        {
            CheckingAccountMaintenance = 0.08M;
            Limit = limit;
        }

        //método referente à saque de valores da conta-corrente
        public void WithdrawCheckingAccount(decimal value, string password)
        {
            if (password != Password)
            {
                throw new Exception("password is incorrect.");
            }

            if (Balance + Limit < value)
            {
                throw new Exception("Balance unavailable.");
            }

            Limit -= value;
        }

        public void Deposit(decimal balance)
        {
            
            SetBalance(Balance + balance);
            
        }
    }
}
