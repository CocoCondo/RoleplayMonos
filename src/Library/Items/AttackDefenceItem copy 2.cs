using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    class AttackDefenceItem : IItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}
        public int Def {get;}

        public AttackDefenceItem(string name, int dmg, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Def = def;
            this.IsItemMagical = isitemmagical;
        }
    }
}


