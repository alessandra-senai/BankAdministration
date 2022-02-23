using BankAdministration.Core.Enums;
using System;

namespace BankAdministration.Core.Entities
{
    public abstract class BankAccount
    {
        public int AccountNumber { get; private set; }
        public int VerifyingDigit { get; private set; }
        public decimal Balance { get; private set; }

        public DateTime? AccountCreated { get; private set; }
        public DateTime? AccountFinished { get; private set; }

        public AccountSituationEnum AccountSituation { get; set; }
        public string Password { get; set; }

        public Client Client { get; set; }



        public BankAccount(Client client)
        {
            Random random = new Random();
            AccountNumber = random.Next(50000, 1000000);
            VerifyingDigit = random.Next(1, 9);
            AccountSituation = AccountSituationEnum.Created;
            Client = client;
        }

        //método referente à sacar valor na conta
        public void WithdrawAccount(decimal value, string password)
        {
            if (password != Password)
            {
                throw new Exception("password is incorrect.");
            }

            if (Balance < value)
            {
                throw new Exception("Balance unavailable.");
            }

            Balance -= value;
        }
    }
}
