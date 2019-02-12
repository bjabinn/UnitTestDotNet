using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2NetFramework
{
    public class GenderAPIClient
    {
        public async Task<string> GetGreetingByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                GenderResponse genero = null;
                string url = $"https://gender-api.com/get?name={name}&key=RnmvAnCUhrmPXpYGHl";
                string response = await client.GetStringAsync(url);

                genero = JsonConvert.DeserializeObject<GenderResponse>(response);

                if (genero.Gender == "male")
                {
                    return $"Estimado Sr. {name}";
                }
                return $"Estimado Sra. {name}";
            }
                
        }

        
            
}
}
