using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public class hability:gameBaseObject
    {
        public string effect { get; set; }
        public override string ToString()
        {

            return $"{name},{uniqueId}";
        }
    }
}
