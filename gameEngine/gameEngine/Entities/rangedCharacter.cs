using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class rangedCharacter:character
    {
        public string armorType = "leather";
        public double energyPoints { get; set; }
        public List<habilityEnergy> hEnergy { get; set; }
    }
}
