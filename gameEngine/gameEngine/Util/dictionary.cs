using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using gameEngine.Entities;
namespace gameEngine.Util
{
    public class dictionary
    {
        public Dictionary<dictionaryKey, IEnumerable<gameBaseObject>> gameDictionary(game game)
        {
            var dic= new Dictionary<dictionaryKey, IEnumerable<gameBaseObject>>();
            dic.Add(dictionaryKey.game, new[]{ game });
            dic.Add(dictionaryKey.character, game.characters);
            dic.Add(dictionaryKey.hability,game.habilities);
            //Listas temporales
            var listTmpMage=new List<mageCharacter>();
            var listTmpmelee = new List<meleeCharacter>();
            var listTmpranged = new List<rangedCharacter>();
            //Agregando Listas separadas por tipo de personajes
            foreach (var chara in game.characters)
            {
                if (chara.GetType().Name == "mageCharacter")
                {
                    listTmpMage.Add((mageCharacter)chara);
                }
                else if (chara.GetType().Name == "meleeCharacter")
                {
                    listTmpmelee.Add((meleeCharacter)chara);
                }
                else if (chara.GetType().Name == "rangedCharacter")
                {
                    listTmpranged.Add((rangedCharacter)chara);
                }
            }
            dic.Add(dictionaryKey.mageCharacter, listTmpMage);
            dic.Add(dictionaryKey.meleeCharacter, listTmpmelee);
            dic.Add(dictionaryKey.rangedCharacter, listTmpranged);
            //Agregando Listas separadas por tipo de ataque
            var listTmpHaM=new List<habilityMana>();
            var listTmpHaE = new List<habilityEnergy>();
            foreach (var habi in game.habilities)
            {
                if (habi.GetType().Name == "habilityMana")
                {
                    listTmpHaM.Add((habilityMana)habi);
                }
                else if (habi.GetType().Name == "habilityEnergy")
                {
                    listTmpHaE.Add((habilityEnergy)habi);
                }
            }
            dic.Add(dictionaryKey.habilityMana,listTmpHaM);
            dic.Add(dictionaryKey.habilityEnergy, listTmpHaE);
            //Agregando Listas separadas por tipo de ataque
            return dic;
        }
        public void printDictionary(Dictionary<dictionaryKey,IEnumerable<gameBaseObject>> dic)
        {
            initializeGame ini=new initializeGame();    
            foreach(var obj in dic)
            {
                ini.writeTitle(obj.Key.ToString());
                foreach (var item in obj.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public Dictionary<dictionaryKey, IEnumerable<hability>> habilityDictionary()
        {
            var dic = new Dictionary<dictionaryKey, IEnumerable<hability>>();
            dic.Add(dictionaryKey.habilityEnergy, new List<habilityEnergy>());
            dic.Add(dictionaryKey.habilityMana, new List<habilityMana>());
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
