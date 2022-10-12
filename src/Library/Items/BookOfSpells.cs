using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    class BookOfSpells : IItem
    {
        public string Name {get;}
        public int Dmg {get;}
        public int Def {get;}
        public List<Spell> Spells {get; set;}

        public BookOfSpells(string name, int dmg, int def)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Def = def;
        }

        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }
    }

}
