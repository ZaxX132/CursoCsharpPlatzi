using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class meleeCharacter:character
    {
        public string armorType = "heavy";
        public double energyPoints { get; set; }
        public List <habilityEnergy> hEnergy { get; set; }
    }
}
