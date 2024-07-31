using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Template.Models
{
    public class Territory
    {
        public string TerritoryID { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public int RegionID { get; set; }
    }
}