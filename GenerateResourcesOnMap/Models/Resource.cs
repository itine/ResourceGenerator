using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateResourcesOnMap.Models
{
    public class Resource
    {
        private string ResourceName { get; set; }
        private string ResourceType { get; set; }
        private double XCoordinate { get; set; }
        private double YCoordinate { get; set; }
        private bool IsGenerated { get; set; }
    }
}
