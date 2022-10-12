using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    class DefenceItem : IItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Def {get;}

        public DefenceItem(string name, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Def = def;
            this.IsItemMagical = isitemmagical;
        }
    }
}


