using API_Simpson.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Simpson.Controlador
{
    class CtrlPersSimpson
    {
        private HttpClient client;
        public CtrlPersSimpson()
        {
            client = new HttpClient();
        }
        public async Task<PersSimpson> GetAllPersSimpson()
        {
            try
            {
                PersSimpson persSimpson = new PersSimpson();
                HttpResponseMessage response = await client.GetAsync("https://apisimpsons.fly.dev/api/personajes/find/simpson");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                persSimpson = JsonConvert.DeserializeObject<PersSimpson>(responseJson);
                return persSimpson;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
