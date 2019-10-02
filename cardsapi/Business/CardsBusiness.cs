using cardsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardsapi.Business
{
    public class CardsBusiness
    {
        private static long contMockId = 100;
        private static List<Card> mockCards = new List<Card>();
        public long CreateCard(Card card)
        {
            card.id = contMockId;
            mockCards.Add(card);
            return contMockId++;
        }
        public Card GetCard(long id)
        {
            return mockCards.Where(x => x.id == id).FirstOrDefault();
        }
    }
}
