using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    class Item
    {
        private string Name {get; set;}
        private int Dmg {get; set;}
        private int Def {get; set;}

        public Item(string name, int dmg, int def)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Def = def;
        }
    }
}


