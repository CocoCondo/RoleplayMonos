using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    class Spell : IItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}
        public int Def {get;}

        public Spell(string name, int dmg, int def)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Def = def;
        }
    }
}

