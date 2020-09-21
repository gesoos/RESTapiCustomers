using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RESTapiSoftim.Models
{
    public class Customers
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int Age { get; set; }
        public bool WasSatisfied { get; set; }
        public string Sex { get; set; } //M for male or F for female
    }
}
