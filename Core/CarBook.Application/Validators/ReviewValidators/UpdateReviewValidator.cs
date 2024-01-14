using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;

namespace CarBook.Application.Validators.ReviewValidators
{
	public class UpdateReviewValidator : AbstractValidator<UpdateReviewCommand>
	{
		public UpdateReviewValidator()
		{
			RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz.");
			RuleFor(x => x.CustomerName).MinimumLength(4).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
			RuleFor(x => x.RatingValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçmeyiniz");
		}
	}
}
