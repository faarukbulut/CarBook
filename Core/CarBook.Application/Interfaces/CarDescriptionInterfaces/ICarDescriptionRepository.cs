using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarDescriptionInterfaces
{
	public interface ICarDescriptionRepository
	{
		CarDescription GetCarDescription(int carID);
	}
}
