using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class character
    {
        public string uniqueId { get; private set; }
        public string name { get; set; }
        public int characterClass { get; set; }
        public double healtPoints { get; set; }
        public double armor { get; set; }
        public double strength { get; set; }
        public double agility { get; set; }
        public double intelect { get; set; }
        public double stamina { get; set; }
        public double spirit { get; set; }
        public List<hability> Habilities { get; set; }= new List<hability>();

    }
}
