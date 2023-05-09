using app_calories.Models;
using app_calories.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace app_calories.Controllers
{
    public class HomeController : Controller
    {
        API services = new API();
        public IActionResult Index(string query)
        {
            if(query != null && query != "")
            {
                List<CaloriesDTO> test = new List<CaloriesDTO>();
                var x = services.GET(query);
                test = JsonConvert.DeserializeObject<List<CaloriesDTO>>(x);
                ViewBag.Query = query;
                if(test.Count == 0)
                {
                    ViewBag.Result = "No Data Available for your query, Please try again !";
                }
                return View(test);
            }
            else
            {
                return View();
            }
        }

        //[HttpGet]
        //public JsonResult getCalories(string input)
        //{
        //    List<CaloriesDTO> test = new List<CaloriesDTO>();
        //    var x = services.GET(input);
        //    test = JsonConvert.DeserializeObject<List<CaloriesDTO>>(x);
        //    return Json(JsonConvert.SerializeObject(test));
        //}
    }
}
