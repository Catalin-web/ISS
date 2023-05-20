using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using System.Net.Mime;

namespace Server.WebApi
{
    [ApiController]
    [Route("card")]
    [Produces(MediaTypeNames.Application.Json)]
    public class CardController
    {
        private readonly ICardFacade _cardFacade;
        public CardController(ICardFacade cardFacade)
        {
            _cardFacade = cardFacade;
        }

        /// <summary>
        /// Create card request.
        /// </summary>
        /// <response code="200">Create card request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateCard(CreateCardRequest request)
        {

            await _cardFacade.CreateCard(request);
        }

        /// <summary>
        /// Get all cards.
        /// </summary>
        /// <response code="200">Get all cards request.</response>
        [HttpPost]
        [Route("get/{userId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Card>> GetAllCards(string userId)
        {

            return await _cardFacade.GetAllCards(userId);
        }

        /// <summary>
        /// Get a card.
        /// </summary>
        /// <response code="200">Get a cards request.</response>
        [HttpPost]
        [Route("get/{cardId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Card> GetCardById(string cardId)
        {

            return await _cardFacade.GetCardById(cardId);
        }
    }
}
