using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarPricingInteraces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
    }
}
