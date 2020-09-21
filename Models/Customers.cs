using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTapiSoftim.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int Age { get; set; }
        public bool WasSatisfied { get; set; }
        public char Sex { get; set; } //M for male or F for female
    }
}
