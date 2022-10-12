using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    class AttackItem : IItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}

        public AttackItem(string name, int dmg, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.IsItemMagical = isitemmagical;
        }
    }
}


