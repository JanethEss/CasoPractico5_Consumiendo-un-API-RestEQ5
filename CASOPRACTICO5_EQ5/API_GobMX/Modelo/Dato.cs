using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GobMX.Modelo
{

    public class Dato
    {
        public string _id { get; set; }
        public DateTime date_insert { get; set; }
        public string slug { get; set; }
        public string columns { get; set; }
        public string fact { get; set; }
        public string organization { get; set; }
        public string resource { get; set; }
        public string url { get; set; }
        public string operations { get; set; }
        public string dataset { get; set; }
        public int created_at { get; set; }
    }
}
