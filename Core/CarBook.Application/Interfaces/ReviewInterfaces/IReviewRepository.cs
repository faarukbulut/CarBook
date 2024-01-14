using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.ReviewInterfaces
{
	public interface IReviewRepository
	{
		List<Review> GetReviewsByCarId(int carId);
	}
}
