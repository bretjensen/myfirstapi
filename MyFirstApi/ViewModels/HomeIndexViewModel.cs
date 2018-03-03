using System.Collections.Generic;
using MyFirstApi.Models;

namespace MyFirstApi.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
        
    }
}