namespace BankAdministration.Core.Entities
{
    public class SavingAccount: BankAccount
    {
        public decimal SavingIncomePercentage { get; private set; } //porcentagem de rendimento

        public SavingAccount(Client client) : base(client)
        {
            SavingIncomePercentage = 0.04m;
        }
    }
}
