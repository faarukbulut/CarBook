using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.CarDescriptionRepositories
{
	public class CarDescriptionRepository : ICarDescriptionRepository
	{
		private readonly CarBookContext _context;

		public CarDescriptionRepository(CarBookContext context)
		{
			_context = context;
		}

		public CarDescription GetCarDescription(int carID)
		{
			var values = _context.CarDescriptions.Where(x => x.CarID == carID).FirstOrDefault();
			return values;
		}
	}
}
