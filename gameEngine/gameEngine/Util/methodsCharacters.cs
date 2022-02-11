using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
using gameEngine.Util;
using System.Linq;

namespace gameEngine.Util
{
    public class methodsCharacters
    {
        methodsHabilities methodsHabilities = new methodsHabilities();
        public List<meleeCharacter> generateMeleeCharacter(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "franco", "pedro" };
            string[] name2 = { "alva", "picapiedra" };

            var listMeleeCharacter = from n1 in name1
                                     from n2 in name2
                                     select new meleeCharacter
                                     {
                                         name = $"{n1} {n2}",
                                         characterClass = 1,
                                         hEnergy = methodsHabilities.randomHabilitiesEnergy(5,1),
                                         healtPoints = rnd.Next(200, 400),
                                         armor = rnd.Next(200, 300),
                                         strength = rnd.Next(30, 100),
                                         stamina = rnd.Next(30, 100)
                                     };

            return listMeleeCharacter.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public void meleeCharacterList(int cantidad)
        {
            foreach (var melee in generateMeleeCharacter(cantidad))
            {
                Console.WriteLine("Name: " + melee.name + "\n");
                int i = 0;
                foreach (var hability in melee.hEnergy)
                {
                    i++;
                    Console.WriteLine("hability " + i + ": " + hability.name);
                }
                Console.WriteLine("\nhealtPoints: " + melee.healtPoints + "");
                Console.WriteLine("armor: " + melee.armor + "");
                Console.WriteLine("strength: " + melee.strength + "");
                Console.WriteLine("stamina: " + melee.stamina + "");
                Console.WriteLine("Your class is: melee "+melee.characterClass);
                Console.WriteLine("================================\n");

            }
        }
        public List<rangedCharacter> generateRangedCharacter(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Sylvanas", "Ashe" };
            string[] name2 = { "Windrunner", "Hawk" };

            var listRangedCharacter = from n1 in name1
                                     from n2 in name2
                                     select new rangedCharacter
                                     {
                                         name = $"{n1} {n2}",
                                         characterClass=0,
                                         hEnergy= methodsHabilities.randomHabilitiesEnergy(5,0),
                                         healtPoints = rnd.Next(200, 400),
                                         armor = rnd.Next(200, 300),
                                         agility = rnd.Next(30, 100),
                                         stamina = rnd.Next(30, 100)
                                     };

            return listRangedCharacter.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public void rangedCharacterList(int cantidad)
        {
            foreach (var ranged in generateRangedCharacter(cantidad))
            {
                Console.WriteLine("Name: " + ranged.name + "\n");
                int i = 0;
                foreach (var hability in ranged.hEnergy)
                {
                    i++;
                    Console.WriteLine("hability " + i + ": " + hability.name);
                }
                Console.WriteLine("\nhealtPoints: " + ranged.healtPoints + "");
                Console.WriteLine("armor: " + ranged.armor + "");
                Console.WriteLine("strength: " + ranged.agility + "");
                Console.WriteLine("stamina: " + ranged.stamina + "");
                Console.WriteLine("Your class is: ranged " +ranged.characterClass);
                Console.WriteLine("================================\n");

            }
        }
        public List<mageCharacter> generateMageCharacter(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Dumbledore", "Merlin" };
            string[] name2 = { "Albus", "Proudmure" };

            var listMageCharacter = from n1 in name1
                                     from n2 in name2
                                     select new mageCharacter
                                     {
                                         name = $"{n1} {n2}",
                                         characterClass = 2,
                                         hMana = methodsHabilities.randomHabilitiesMana(5, 2),
                                         healtPoints = rnd.Next(200, 400),
                                         armor = rnd.Next(200, 300),
                                         intelect = rnd.Next(30, 100),
                                         stamina = rnd.Next(30, 100)
                                     };

            return listMageCharacter.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public void MageCharacterList(int cantidad)
        {
            foreach (var mage in generateMageCharacter(cantidad))
            {
                Console.WriteLine("Name: " + mage.name + "\n");
                int i = 0;
                foreach (var hability in mage.hMana)
                {
                    i++;
                    Console.WriteLine("hability " + i + ": " + hability.name);
                }
                Console.WriteLine("\nhealtPoints: " + mage.healtPoints + "");
                Console.WriteLine("armor: " + mage.armor + "");
                Console.WriteLine("intelect: " + mage.intelect + "");
                Console.WriteLine("stamina: " + mage.stamina + "");
                Console.WriteLine("Your class is: mage " + mage.characterClass);
                Console.WriteLine("================================\n");

            }
        }
        public List<character> characterList(List<meleeCharacter> meleeList,List<rangedCharacter> rangedList,List<mageCharacter> mageList)
        {
            List<character> characterlist = new List<character>();
            character chara=new character();
            foreach (meleeCharacter character in meleeList)
            {
                chara = character;
                characterlist.Add(chara);
            }
            foreach (rangedCharacter character in rangedList)
            {
                chara = character;
                characterlist.Add(chara);
            }
            foreach (mageCharacter character in mageList)
            {
                chara = character;
                characterlist.Add(chara);
            }
            return characterlist;
        }
    }
}
