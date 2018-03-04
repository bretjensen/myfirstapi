using System.Collections.Generic;
using System.Linq;
using MyFirstApi.Data;
using MyFirstApi.Models;

namespace MyFirstApi.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private MyFirstApiDbContext _context;

        public SqlRestaurantData(MyFirstApiDbContext context)
        {
            _context = context;
        }
        
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }
    }
}