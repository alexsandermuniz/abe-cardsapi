using cardsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Business
{
   
    public class TransactionBusiness
    {
        private static long contMockId = 100;
        private static List<Transaction> mockTransactions = new List<Transaction>();
        public long CreateTransaction(Transaction transaction)
        {
            transaction.id = contMockId;
            mockTransactions.Add(transaction);
            return contMockId++;
        }
        public Transaction GetTransaction(long id)
        {
            return mockTransactions.Where(x => x.id == id).FirstOrDefault();
        }

    }
}
