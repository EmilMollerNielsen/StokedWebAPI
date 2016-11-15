using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StokedAPI6.Models;
using StokedAPI6.Repository;
using Microsoft.AspNet.Identity;
using System.Web.Script.Serialization;

namespace StokedAPI6.Controllers
{
    [Authorize]
    public class LocationModelsController : Controller
    {
        private iLocationRepository locationRepository;

        public LocationModelsController(iLocationRepository locationRepo)
        {
            locationRepository = locationRepo;
        }

        //private StokedAPI6Context db = new StokedAPI6Context();

        // GET: LocationModels
        [HttpGet]
        public ActionResult Index()
        {
            List<LocationModel> locations = locationRepository.GetAll() as List<LocationModel>;
            return View(locations);
        }
        [HttpPost]
        public ActionResult Index(LocationModel obj)
        {
            // retrive the data from table  
            var locationlist = locationRepository.GetAll() as List<LocationModel>;
            // Pass the "personlist" object for conversion object to JSON string  
            string jsondata = new JavaScriptSerializer().Serialize(locationlist);
            string path = Server.MapPath("~/App_Data/");
            // Write that JSON to txt file,  
            System.IO.File.WriteAllText(path + "output.json", jsondata);
            TempData["msg"] = jsondata;
            return RedirectToAction("Index");
        }





        // GET: LocationModels/Details/5
        public ActionResult Details(int id)
        {
            var location = locationRepository.Find(id);
            return View(location);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        

        // GET: LocationModels/Create
        [HttpPost]
        public ActionResult Create(LocationModel location)
        {
            if (ModelState.IsValid)
            {
                string currentUserId = User.Identity.GetUserId();

                locationRepository.InsertOrUpdate(currentUserId, location);
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: LocationModels/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
           
            
            return View(locationRepository.Find(id));
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LocationModel location)
        {
            if (ModelState.IsValid)
            {
                string currentUserId = User.Identity.GetUserId();

                locationRepository.InsertOrUpdate(currentUserId, location);
                return RedirectToAction("Index");
            }

            return View();
        }

      
        
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (locationRepository.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(locationRepository.Find(id));
        }

        // POST: UserModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            locationRepository.DeleteLocation(id);
            return RedirectToAction("Index");
        }



    }
}
