using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.AppUserCommands
{
	public class CreateAppUserCommand : IRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
