using API_RyM.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_RyM.Controlador
{
    public class CtrlPersonajes
    {
        private HttpClient client;
        public CtrlPersonajes()
        {
            client = new HttpClient();
        } 
        public async Task<Personajes> GetAllPersonajes()
        {
            try
            {
                Personajes personajes = new Personajes();
                HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api/character");
                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                personajes = JsonConvert.DeserializeObject<Personajes>(responseJson);
                return personajes;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
