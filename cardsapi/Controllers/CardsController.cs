using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cardsapi.Business;
using cardsapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace cardsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        CardsBusiness _CardsBusiness = new CardsBusiness();
        // POST api/cards
        [HttpPost]
        public void Post([FromBody] Card card)
        {
            _CardsBusiness.CreateCard(card);
        }

        // GET api/cards/5
        [HttpGet("{id}")]
        public Card Get(long id)
        {
            return _CardsBusiness.GetCard(id);
        }
    }
}
