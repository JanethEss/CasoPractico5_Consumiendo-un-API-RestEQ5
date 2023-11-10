using API_GobMX.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_GobMX.Controlador
{
    public class CtrlDatos
    {
        private HttpClient client;
        public CtrlDatos()
        {
            client = new HttpClient();
        }
        public async Task<Datos> GetAllDatos()
        {
            try
            {
                Datos datos = new Datos();
                HttpResponseMessage response = await client.GetAsync("https://api.datos.gob.mx/v1/gobmx.facts");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                datos = JsonConvert.DeserializeObject<Datos>(responseJson);
                return datos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
