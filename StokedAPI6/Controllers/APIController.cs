using StokedAPI6.Models;
using StokedAPI6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StokedAPI6.Controllers
{
    public class APIController : ApiController
    {
        private LocationRepository locationRepository;


        public APIController()
        {
            locationRepository = new LocationRepository();
        }

        public LocationModel[] Get()
        {
            LocationModel[] ReturnedLocations = locationRepository.GetAll().ToArray();

            return ReturnedLocations;
        }
    }
}
