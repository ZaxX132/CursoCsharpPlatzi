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
        public void initialize()
        {
            methodsCharacters.meleeCharacterList(2);
            methodsCharacters.rangedCharacterList(2);
            methodsCharacters.MageCharacterList(2);
        }
    }
}
        
