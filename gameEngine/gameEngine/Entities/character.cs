using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class character:gameBaseObject
    {
        public int characterClass { get; set; }
        public double healtPoints { get; set; }
        public double armor { get; set; }
        public double strength { get; set; }
        public double agility { get; set; }
        public double intelect { get; set; }
        public double stamina { get; set; }
        public double spirit { get; set; }

        public override string ToString()
        {

            return $"{name},{uniqueId}";
        }

    }
}
