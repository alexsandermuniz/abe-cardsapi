using cardsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Business
{
   
    public class TransactionBusiness
    {
        List<Transaction> mockTransactions = new List<Transaction>();
        public void CreateTransaction(Transaction transaction)
        {
            mockTransactions.Add(transaction);
        }
        public Transaction GetTransaction(long id)
        {
            return mockTransactions.Where(x => x.id == id).FirstOrDefault();
        }

    }
}
