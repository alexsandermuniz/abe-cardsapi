using cardsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Business
{
    public class CardsBusiness
    {
        List<Card> mockCards = new List<Card>();
        public void CreateCard(Card card)
        {
            mockCards.Add(card);
        }
        public Card GetCard(long id)
        {
            return mockCards.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
