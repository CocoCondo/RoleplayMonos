using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    public class AttackItem : IAttackItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}

        public AttackItem(string name, string description, int dmg, bool isitemmagical)
        {
            this.Name = name;
            this.Description = description;
            this.Dmg = dmg;
            this.IsItemMagical = isitemmagical;
        }
    }
}


