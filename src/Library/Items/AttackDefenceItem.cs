using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    public class AttackDefenceItem : IAttackItem, IDefenceItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}
        public int Def {get;}

        public AttackDefenceItem(string name, string description, int dmg, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Description = description;
            this.Dmg = dmg;
            this.Def = def;
            this.IsItemMagical = isitemmagical;
        }
    }
}


