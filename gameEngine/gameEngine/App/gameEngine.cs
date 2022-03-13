using System;
using System.Collections.Generic;
using System.Text;
using gameEngine.Entities;
using gameEngine.Util;
using System.Linq;

namespace gameEngine.App
{
    public class gameEngine
    {
        //Inicializando clases de metodos
        methodsHabilities methodsHabilities=new methodsHabilities();
        methodsCharacters methodsCharacters=new methodsCharacters();
        initializeGame iniGame=new initializeGame();
        //Lista de characters
        List<character> lCharacters=new List<character>();
        List<meleeCharacter> lMeleeCharacters=new List<meleeCharacter>();
        List<rangedCharacter> lRangedCharacters=new List<rangedCharacter>();
        List<mageCharacter> lMageCharacters=new List<mageCharacter>();
        //Lista de habilidades
        List<hability>lHabilities=new List<hability>();
        List<habilityEnergy>lhabilityEnergiesRanged=new List<habilityEnergy>();
        List<habilityEnergy> lhabilityEnergiesMelee = new List<habilityEnergy>();
        List<habilityMana>lhabilityMana=new List<habilityMana>();
        List<habilityEnergy> lhabilityEnergies = new List<habilityEnergy>();
        //
        dictionary dictionary=new dictionary();
        game obGame=new game();
        public void initialize()
        {
            //generando las habilidades
            lhabilityMana = methodsHabilities.generateHabilitiesMana(25);
            lhabilityEnergiesMelee = methodsHabilities.generateHabilitiesEnergyMelee(25);
            lhabilityEnergiesRanged = methodsHabilities.generateHabilitiesEnergyRanged(25);
            //colocando las habilidades en una lista global de habilidades
            lhabilityEnergies.AddRange(lhabilityEnergiesMelee);
            lhabilityEnergies.AddRange(lhabilityEnergiesRanged);
            lHabilities.AddRange(lhabilityMana);
            lHabilities.AddRange(lhabilityEnergies);
            //generando a los personajes colocando las habilidades previamente generadas
            lMeleeCharacters = methodsCharacters.generateMeleeCharacter(3,lhabilityEnergies);
            lRangedCharacters = methodsCharacters.generateRangedCharacter(3, lhabilityEnergies);
            lMageCharacters = methodsCharacters.generateMageCharacter(3,lhabilityMana);
            lCharacters=methodsCharacters.characterList(lMeleeCharacters, lRangedCharacters,lMageCharacters);
            //Inicializando el objeto Juego
            obGame=iniGame.iniGame(lCharacters,"jueguito",2022,dificulty.Nightmare, lHabilities);
            iniGame.listIniGame(obGame);
            dictionary.characterDictionary(lMageCharacters, lMeleeCharacters, lRangedCharacters);


        }
    }
}
        
