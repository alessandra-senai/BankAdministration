using BankAdministration.Core.Entities;
using System;

namespace BankAdministrationConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("Alessandra", "34.543.55", "5432.5432.55", "Rua Azul, 43");

            BankAccount bankAccount = new BankAccount(client);
             
            Console.WriteLine("---------- Dados do Cliente -------------");
            Console.WriteLine($"Client: {client.Name} CPF: {client.CPF}");
            Console.WriteLine("---------- Dados da conta -------------");
            Console.WriteLine($"Conta numero: {bankAccount.AccountNumber}- conta digito: {bankAccount.VerifyingDigit} ");


        }
    }
}
