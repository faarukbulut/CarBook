using CarBook.Application.ViewModels;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarPricingInteraces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
        List<CarPricing> GetCarPricingWithTimePeriod();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
    }
}
