using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ReviewHandlers
{
	public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
	{
		private readonly IRepository<Review> _repository;

		public UpdateReviewCommandHandler(IRepository<Review> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.ReviewID);

			values.CustomerName = request.CustomerName;
			values.ReviewDate = request.ReviewDate;
			values.CarID = request.CarID;
			values.Comment = request.Comment;
			values.RatingValue = request.RatingValue;

			await _repository.UpdateAsync(values);
		}
	}
}
