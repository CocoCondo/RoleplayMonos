using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    public class DefenceItem : IDefenceItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Def {get;}

        public DefenceItem(string name, string description, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Description = description;
            this.Def = def;
            this.IsItemMagical = isitemmagical;
        }
    }
}


