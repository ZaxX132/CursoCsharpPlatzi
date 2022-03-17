using System;
using System.Collections.Generic;
using System.Text;

namespace gameEngine.Entities
{
    public abstract class gameBaseObject
    {
        public string uniqueId { get; private set; }
        public string name { get; set; }
        public gameBaseObject()
        {
            uniqueId = Guid.NewGuid().ToString();
        }
    }
}
