using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
namespace gameEngine.Util
{
    public class dictionary
    {
        public Dictionary<string,IEnumerable<character>> characterDictionary(List<mageCharacter> mago, List<meleeCharacter> melee, List<rangedCharacter> ranged)
        {
            var dic= new Dictionary<string, IEnumerable<character>>();
            dic.Add(dictionaryKey.mageC, mago);
            dic.Add(dictionaryKey.meleeC, melee);
            dic.Add(dictionaryKey.rangedC, ranged);
            return dic;
        }

        public Dictionary<string, IEnumerable<hability>> habilityDictionary()
        {
            var dic = new Dictionary<string, IEnumerable<hability>>();
            dic.Add(dictionaryKey.habilityE, new List<habilityEnergy>());
            dic.Add(dictionaryKey.habilityM, new List<habilityMana>());
            return dic;
        }
        public int numerito()
        {
            return  0;
        }
        public dictionary()
        {

        }
    }
}
