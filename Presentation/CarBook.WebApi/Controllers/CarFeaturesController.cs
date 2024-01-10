using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarFeaturesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CarFeaturesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> CarFeatureListByCarID(int id)
		{
			var values = await _mediator.Send(new GetCarFeatureByCarIDQuery(id));
			return Ok(values);
		}

		[HttpGet("CarFeatureAvailableChangeToFalse/{id}")]
		public async Task<IActionResult> CarFeatureAvailableChangeToFalse(int id)
		{
			_mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
			return Ok("Güncelleme yapıldı");
		}

        [HttpGet("CarFeatureAvailableChangeToTrue/{id}")]
        public async Task<IActionResult> CarFeatureAvailableChangeToTrue(int id)
        {
            _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
            return Ok("Güncelleme yapıldı");
        }

		[HttpPost]
		public async Task<IActionResult> CreateCarFeatureByCarID(CreateCarFeatureByCarIDCommand command)
		{
			_mediator.Send(command);
			return Ok("Ekleme yapıldı");
		}
    }
}
