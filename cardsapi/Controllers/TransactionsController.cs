using cardsapi.Business;
using cardsapi.Models;
using Microsoft.AspNetCore.Mvc;
namespace cardsapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        TransactionBusiness _TransactionBusiness = new TransactionBusiness();
        // POST api/transactions
        [HttpPost]
        public ActionResult<long> Post([FromBody] Transaction transaction)
        {
            return _TransactionBusiness.CreateTransaction(transaction);
        }

        // PUT api/transactions/5
        [HttpGet("{id}")]
        public Transaction Get(int id)
        {
            return _TransactionBusiness.GetTransaction(id);
        }

    }
}
