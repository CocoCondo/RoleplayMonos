
using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    class Shield : IItem
    {
        public string Name {get;}
        public int Dmg {get;}
        public int Def {get;}

        public Shield(string name, int def)
        {
            this.Name = name;
            this.Def = def;
        }
    }
}

