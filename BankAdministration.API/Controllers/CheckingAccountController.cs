using BankAdministration.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAdministration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckingAccountController : ControllerBase
    {
        // GET: api/<CheckingAccountController>
        [HttpGet]
        public CheckingAccount Get()
        {
            Client clientA = new Client(name:"Alessandra", cpf: "54325432", rg: "RG 543534", address:"Rua Azul");

            CheckingAccount checkingAccount = new CheckingAccount(client: clientA, limit: 200.14M);

            checkingAccount.OpenAccount("123", 5690.54M);
            
            checkingAccount.WithdrawCheckingAccount(10M, "123");


            return checkingAccount;
        }




        // GET api/<CheckingAccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CheckingAccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CheckingAccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CheckingAccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
