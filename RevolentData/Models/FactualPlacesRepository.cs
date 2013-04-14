using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactualDriver;
using FactualDriver.Filters;

namespace RevolentData.Models
{
    public class FactualPlacesRepository
    {
        public Factual _factual;
        public FactualPlacesRepository()
        {
              _factual = new Factual(HttpContext.Current.Application["factkey"] as string,(HttpContext.Current.Application["factsec"] as string));
        }
        public string GetRestaurantsJsonData(LocationQueryFilter filter)
        {
            var query = new Query();
            if (filter.Latitude != 0 && filter.Longitude != 0)
            {
                query.WithIn(new Circle(filter.Latitude, filter.Longitude, filter.Distance==0?1000:filter.Distance));
            }

            if (!string.IsNullOrWhiteSpace(filter.Location))
            {
                query.Field("locality").Search(filter.Location);
            }

            if (!string.IsNullOrWhiteSpace(filter.SearchValue))
            {
                query.Field("name").Search(filter.SearchValue);
            }
            //Only return small subset of data that we need
            query.Only("name", "cuisine", "rating", "address", "website");
            return _factual.Fetch("restaurants", query);
        }
    }
}