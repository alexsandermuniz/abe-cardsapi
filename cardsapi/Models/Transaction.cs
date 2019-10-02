using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Models
{
    public class Transaction
    {
        [JsonIgnore]
        public long id { get; set; }
        public long cardId { get; set; }
        public double value { get; set; }
        public DateTime dateTime { get; set; }
    }
}
