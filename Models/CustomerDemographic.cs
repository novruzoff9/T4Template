using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Template.Models
{
    public class CustomerDemographic
    {
        public string CustomerTypeID { get; set; } = null!;
        public string? CustomerDesc { get; set; }
    }
}