using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class game:gameBaseObject
    {

        public int CreationAge { get; set; }    
        public dificulty dificulty { get; set; }    
        public List<character> characters { get; set;}
        public List<hability> habilities { get; set;}
        public game (string namec,int age,dificulty dificultyc)=>(name,CreationAge,dificulty)=(namec,age,dificultyc);
        public game()
        {

        }
        public override string ToString()
        {

            return $"{name},{dificulty}";
        }
    }
}
