using System.Collections.Generic;
using MyFirstApi.Models;

namespace MyFirstApi.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}