using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
using System.Linq;
namespace gameEngine.Util
{
    public class methodsHabilities
    {
        //GENERANDO LAS HABILIDADES DE ENERGIA
        public List<habilityEnergy> generateHabilitiesEnergyMelee(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Storm", "Piercing", "Earth", "Poison", "Deadly" };
            string[] name2 = { "Strike", "Slam", "Shot", "Punch", "shield" };

            var listHabilityEnergie = from n1 in name1
                                      from n2 in name2
                                      select new habilityEnergy { name = $"{n1} {n2}", habilityCost = rnd.Next(5, 61), habilityClass = 1, effect = "nothing uwu" };

            return listHabilityEnergie.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public List<habilityEnergy> generateHabilitiesEnergyRanged(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Aimed", "Piercing", "Steady", "Poison", "Deadly" };
            string[] name2 = { "Strike", "throw", "Shot", "knife", "arrow" };

            var listHabilityEnergie = from n1 in name1
                                      from n2 in name2
                                      select new habilityEnergy { name = $"{n1} {n2}", habilityCost = rnd.Next(5, 61), habilityClass = 0, effect = "nothing uwu" };

            return listHabilityEnergie.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public List<habilityEnergy> randomHabilitiesEnergy(int cantidad,int characterClass,List<habilityEnergy>habilityEnergy)
        {
            List<habilityEnergy> habilityEnergies = new List<habilityEnergy>();
            List<habilityEnergy> habilityEnergiesM = new List<habilityEnergy>();
            List<habilityEnergy> habilityEnergiesCharacter = new List<habilityEnergy>();
            Random rnd = new Random();
            foreach (var hability in habilityEnergy)
            {
                if (hability.habilityClass == characterClass)
                {
                    habilityEnergiesM.Add(hability);
                }
            }
            for (int i = 0; i < cantidad; i++)
            {

                habilityEnergiesCharacter.Add(habilityEnergiesM.ElementAt(rnd.Next(0, habilityEnergiesM.Count)));

            }
            return habilityEnergiesCharacter;

        }
        public void energyHabilitiesList(List<habilityEnergy> habilityEnergies)
        {
            Random rnd = new Random();

            foreach (var hability in habilityEnergies)
            {
                Console.WriteLine("Name: " + hability.name);
                Console.WriteLine("Cost: " + hability.habilityCost);
                Console.WriteLine("Class: " + hability.habilityClass);
                Console.WriteLine("Efect: " + hability.effect + "\n");
            }
        }
        //GENERANDO LAS HABILIDADES DE MANA
        public List<habilityMana> generateHabilitiesMana(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Fire", "Ice", "Arcane", "Shadow", "Water" };
            string[] name2 = { "Bolt", "Beam", "Barrier", "Rain", "Explotion" };

            var listHabilityMana = from n1 in name1
                                      from n2 in name2
                                      select new habilityMana { name = $"{n1} {n2}", habilityCost = rnd.Next(5, 200), habilityClass = 2, effect = "nothing uwu" };

            return listHabilityMana.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        public void manaHabilitiesList(List<habilityMana> habilityMana)
        {
            foreach (var hability in habilityMana)
            {
                Console.WriteLine("Name: " + hability.name);
                Console.WriteLine("Cost: " + hability.habilityCost);
                Console.WriteLine("Class: " + hability.habilityClass);
                Console.WriteLine("Efect: " + hability.effect + "\n");
            }
        }
        public List<habilityMana> randomHabilitiesMana(int cantidad,int characterClass,List<habilityMana>habilityMana)
        {
            List<habilityMana> habilityMana2 = new List<habilityMana>();
            List<habilityMana> habilityManaCharacter = new List<habilityMana>();
            Random rnd = new Random();

            foreach (var hability in habilityMana)
            {
                if (hability.habilityClass == characterClass)
                {
                    habilityMana2.Add(hability);
                }
            }
            for (int i = 0; i < cantidad; i++)
            {

                habilityManaCharacter.Add(habilityMana2.ElementAt(rnd.Next(0, habilityMana2.Count)));

            }
            return habilityManaCharacter;

        }
        //LISTA DE HABILIDADES
        public List<hability> habilityList(List<habilityEnergy> energyList, List<habilityMana> manaList)
        {
            List<hability> habilityList = new List<hability>();
            hability hab = new hability();
            foreach (habilityEnergy hability in energyList)
            {
                hab = hability;
                habilityList.Add(hab);
            }
            foreach (habilityMana hability in manaList)
            {
                hab = hability;
                habilityList.Add(hab);
            }
            
            return habilityList;
        }
        public methodsHabilities()
        {

        }
    }
}
