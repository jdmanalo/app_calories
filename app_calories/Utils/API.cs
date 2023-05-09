using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace app_calories.Utils
{
    public class API
    {
        string apikey = "gNsP0+X2q6QZKDH1BcI5pQ==kRvBZCewrktZ5oT2";
        string APIurl = "https://api.api-ninjas.com/v1/caloriesburned?activity=";
        public string GET(string items)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIurl + items);
            httpWebRequest.Headers.Add("X-Api-Key", apikey);
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.ToString());
                return ex.ToString();

            }
        }
    }
}
