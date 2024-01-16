using CarBook.Application.Features.Mediator.Commands.AppUserCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SignupController : ControllerBase
	{
		private readonly IMediator _mediator;

		public SignupController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Register(CreateAppUserCommand command)
		{
			await _mediator.Send(command);
			return Ok("Kullanıcı başarıyla oluşturuldu");
		}
	}
}
