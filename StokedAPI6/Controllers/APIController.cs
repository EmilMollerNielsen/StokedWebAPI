using StokedAPI6.Models;
using StokedAPI6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace StokedAPI6.Controllers
{
    public class APIController : ApiController
    {
        private LocationRepository locationRepository;


        public APIController()
        {
            locationRepository = new LocationRepository();
        }

        public string Get()
        {
            // retrive the data from table  
            var locationlist = locationRepository.GetAll() as List<LocationModel>;
            // Pass the "personlist" object for conversion object to JSON string  
            string jsondata = new JavaScriptSerializer().Serialize(locationlist);

            return jsondata;
        }
    }
}
