using app_calories.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_calories.Utils
{
    public class APIController
    {
        API service = new API();
        public List<CaloriesDTO> getCalories(string value)
        {
            var x = service.GET(value);
            return JsonConvert.DeserializeObject<List<CaloriesDTO>>(x);
        }
    }
}
