using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_calories.Models
{
    public class CaloriesDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string calories_per_hour { get; set; }
        public string duration_minutes { get; set; }
        public string total_calories { get; set; }
    }
    public class CalorieReturnDTO
    {
        public int id { get; set; }
    }
}
