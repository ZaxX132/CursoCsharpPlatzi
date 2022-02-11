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
        methodsHabilities methodsHabilities=new methodsHabilities();
        methodsCharacters methodsCharacters=new methodsCharacters();
        initializeGame iniGame=new initializeGame();
        List<character> lCharacters=new List<character>();
        List<meleeCharacter> lMeleeCharacters=new List<meleeCharacter>();
        List<rangedCharacter> lRangedCharacters=new List<rangedCharacter>();
        List<mageCharacter> lMageCharacters=new List<mageCharacter>();
        game obGame=new game();
        public void initialize()
        {

            lMeleeCharacters = methodsCharacters.generateMeleeCharacter(3);
            lRangedCharacters = methodsCharacters.generateRangedCharacter(3);
            lMageCharacters = methodsCharacters.generateMageCharacter(3);
            lCharacters=methodsCharacters.characterList(lMeleeCharacters, lRangedCharacters,lMageCharacters);
            obGame=iniGame.iniGame(lCharacters,"jueguito",2022,dificulty.Nightmare);
            iniGame.listIniGame(obGame);
        }
    }
}
        
