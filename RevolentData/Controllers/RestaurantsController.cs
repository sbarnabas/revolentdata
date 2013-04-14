using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using FactualDriver.Exceptions;
using RevolentData.Models;

namespace RevolentData.Controllers
{
    public class RestaurantsController : ApiController
    {
        private readonly FactualPlacesRepository _repository = new FactualPlacesRepository();
        // GET api/restaurants
        public HttpResponseMessage GetRestaurants([FromUri]LocationQueryFilter filter)
        {
            string factualJsonData;
            try
            {
                factualJsonData = _repository.GetRestaurantsJsonData(filter);
            }
            catch (FactualApiException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage { Content = new StringContent(ex.Message) });
            }

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(factualJsonData, Encoding.UTF8, "application/json")
            };
            return response;
        }
    }
}
