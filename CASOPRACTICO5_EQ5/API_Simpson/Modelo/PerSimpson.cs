using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Simpson.Modelo
{
    public class PerSimpson
    {
        public string _id { get; set; }
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public string Imagen { get; set; }
        public string Genero { get; set; }
        public string Estado { get; set; }
        public string Ocupacion { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }
    }
}
