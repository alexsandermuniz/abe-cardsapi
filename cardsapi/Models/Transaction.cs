using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Models
{
    public class Transaction
    {
        public long id { get; set; }
        public Card card { get; set; }
        public double value { get; set; }
        public DateTime dateTime { get; set; }
    }
}
