using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class mageCharacter:character
    {
        public string armorType = "cloth";
        public double manaPoints { get; set; }
        public List<habilityMana> hMana { get; set; }
    }
}
