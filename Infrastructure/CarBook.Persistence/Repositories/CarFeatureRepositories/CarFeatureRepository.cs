﻿using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarFeatureRepositories
{
	public class CarFeatureRepository : ICarFeatureRepository
	{
		private readonly CarBookContext _context;

		public CarFeatureRepository(CarBookContext context)
		{
			_context = context;
		}

        public void ChangeCarFeatureAvailableToFalse(int id)
        {
			var values = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
			values.Available = false;
			_context.SaveChanges();
        }

        public void ChangeCarFeatureAvailableToTrue(int id)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
            values.Available = true;
            _context.SaveChanges();
        }

        public void CreateCarFeatureByCarId(CarFeature carFeature)
        {
            _context.CarFeatures.Add(carFeature);
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeaturesByCarId(int carID)
		{
			var values = _context.CarFeatures.Include(x => x.Feature).Where(x => x.CarID == carID).ToList();
            return values;	
		}
	}
}
