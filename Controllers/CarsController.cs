using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Car.Models;
using System;

namespace Car.Controllers

{
    public class CarsController : Controller
    {

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     Item newItem = new Item(Request.Query["new-item"]);
        //     return View(newItem);
        // }
        //
        // [HttpGet("/items/new")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     return View();
        // }

        // [HttpGet("/Cars")]
        [HttpGet("/Cars")]
        public ActionResult Index()
        {
            List<Cars> allCars = Cars.GetAll();
            return View("Index", allCars);
        }


        [HttpGet("/Cars/new")]
        public ActionResult CreateForm()
        {
           return View();
        }

        [HttpPost("/Results")]
        public ActionResult Create()
        {
          // Cars newCars = new Cars (Request.Form["new-car"], "sedan", 9999, 9999);
          Cars newCar = new Cars (Request.Form["make"], Request.Form["model"], Convert.ToInt32(Request.Form["price"]), Convert.ToInt32(Request.Form["miles"]));


          newCar.Save();

          List<Cars> allCars = Cars.GetAll();
          return View("Cars", allCars);
          // return View("Index");
          // return View("Items", newItem);
        }
        //
        // [HttpPost("/items/delete")]
        [HttpPost("/Cars/delete")]
        public ActionResult ClearAll()
        {
            Cars.ClearAll();
            return View("DeleteForm");
        }

    }
}
