using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacAspNetCore.Services
{
    public class MercedesService : ICarService
    {
        public string PrintSpecification()
        {
            return "Mercedes Specification";
        }
    }
}
