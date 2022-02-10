using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
using System.Linq;

namespace gameEngine.App
{
    public class gameEngine
    {
        public void initialize()
        {
            meleeCharacterList(5);
        }

        private List<habilityEnergy> generateHabilitiesEnergy(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Storm", "Piercing", "Earth", "Poison", "Deadly" };
            string[] name2 = { "Strike", "Slam", "Shot", "Punch","auch" };

            var listHabilityEnergie = from n1 in name1
                                      from n2 in name2
                                      select new habilityEnergy { name = $"{n1} {n2}", habilityCost = rnd.Next(5, 61), habilityClass = rnd.Next(0, 2), effect = "nothing uwu" };

            return listHabilityEnergie.OrderBy((al) => al.habiltyId).Take(cantidad).ToList();
        }
        private List<habilityEnergy> randomHabilitiesEnergy(int cantidad)
        {
            List<habilityEnergy> habilityEnergies = new List<habilityEnergy>();
            List<habilityEnergy> habilityEnergiesM = new List<habilityEnergy>();
            List<habilityEnergy> habilityEnergiesCharacter = new List<habilityEnergy>();
            Random rnd = new Random();
            habilityEnergies.AddRange(generateHabilitiesEnergy(25));

            foreach (var hability in habilityEnergies)
            {
                if (hability.habilityClass == 0)
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
        private void energyHabilitiesList(int cantidad)
        {
            foreach (var hability in generateHabilitiesEnergy(cantidad))
            {
                Console.WriteLine("Name: " + hability.name);
                Console.WriteLine("Cost: " + hability.habilityCost);
                Console.WriteLine("Class: " + hability.habilityClass);
                Console.WriteLine("Efect: " + hability.effect + "\n");
            }
        }
        private List<habilityEnergy> generateHabilitiesMana(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "Fire", "Ice", "Arcane", "Shadow", "Water" };
            string[] name2 = { "Bolt", "Beam", "Barrier", "Rain", "Explotion" };

            var listHabilityEnergie = from n1 in name1
                                      from n2 in name2
                                      select new habilityEnergy { name = $"{n1} {n2}", habilityCost = rnd.Next(5, 200), habilityClass = rnd.Next(0, 2), effect = "nothing uwu" };

            return listHabilityEnergie.OrderBy((al) => al.habiltyId).Take(cantidad).ToList();
        }
        private void manaHabilitiesList(int cantidad)
        {
            foreach (var hability in generateHabilitiesMana(cantidad))
            {
                Console.WriteLine("Name: " + hability.name);
                Console.WriteLine("Cost: " + hability.habilityCost);
                Console.WriteLine("Class: " + hability.habilityClass);
                Console.WriteLine("Efect: " + hability.effect + "\n");
            }
        }
        private List<meleeCharacter> generateMeleeCharacter(int cantidad)
        {
            Random rnd = new Random();
            string[] name1 = { "franco", "pedro" };
            string[] name2 = { "alva", "picapiedra" };

            var listMeleeCharacter = from n1 in name1
                                     from n2 in name2
                                     select new meleeCharacter
                                     {
                                         name = $"{n1} {n2}",
                                         hEnergy = randomHabilitiesEnergy(5),
                                         healtPoints = rnd.Next(200, 400),
                                         armor = rnd.Next(200, 300),
                                         strength = rnd.Next(30, 100),
                                         stamina = rnd.Next(30, 100)
                                     };

            return listMeleeCharacter.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        private void meleeCharacterList(int cantidad)
        {
            foreach (var melee in generateMeleeCharacter(cantidad))
            {
                Console.WriteLine("Name: " + melee.name+"\n");
                int i = 0;
                foreach (var hability in melee.hEnergy)
                {
                    i++;
                    Console.WriteLine("hability "+i+": " + hability.name);
                }
                Console.WriteLine("\nhealtPoints: " + melee.healtPoints+"");
                Console.WriteLine("armor: " + melee.armor + "");
                Console.WriteLine("strength: " + melee.strength + "");
                Console.WriteLine("stamina: " + melee.stamina + "");
                Console.WriteLine("================================\n");

            }
        }
    }
}
        
