﻿using Ode_To_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ode_To_Food.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Adam's Pizza Place"},
                new Restaurant { Id = 2, Name = "Gyros"},
                new Restaurant { Id = 3, Name = "Five Guys Burgers and Fries"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Id);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            //TODO Update Restaurant
            return restaurant;
        }

        private List<Restaurant> _restaurants;
    }
}
