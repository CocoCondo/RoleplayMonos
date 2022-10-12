
using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    class Robe : IItem
    {
        public string Name {get;}
        public int Dmg {get;}
        public int Def {get;}

        public Robe(string name, int dmg, int def)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Def = def;
        }
    }
}

