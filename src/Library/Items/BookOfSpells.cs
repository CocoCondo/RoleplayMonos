using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    public class BookOfSpells : IAttackItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
        public int Dmg {get;}
        public int Def {get;}
        public List<Spell> Spells {get;}

        public BookOfSpells(string name, string description, int dmg, int def, bool isitemmagical)
        {
            this.Name = name;
            this.Description = description;
            this.Dmg = dmg;
            this.Def = def;
            this.IsItemMagical = isitemmagical;
        }
        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }
    }

}
