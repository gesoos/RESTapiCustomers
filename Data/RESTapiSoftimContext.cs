using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTapiSoftim.Models;

namespace RESTapiSoftim.Data
{
    public class RESTapiSoftimContext : DbContext
    {
        public RESTapiSoftimContext (DbContextOptions<RESTapiSoftimContext> options)
            : base(options)
        {
        }

        public DbSet<RESTapiSoftim.Models.Customers> Customers { get; set; }
    }
}
