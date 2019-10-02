using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Models
{
    public class Card
    {
        [JsonIgnore]
        public long id { get; set; }
        public long cardNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public int verificationCode { get; set; }
        public string cardOwnerName { get; set; }

        public Card(long id, long cardNumber, DateTime expirationDate, int verificationCode, string cardOwnerName)
        {
            this.id = id;
            this.cardNumber = cardNumber;
            this.expirationDate = expirationDate;
            this.verificationCode = verificationCode;
            this.cardOwnerName = cardOwnerName;
        }
    }
}
