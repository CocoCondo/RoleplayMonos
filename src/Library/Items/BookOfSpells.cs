using System;
using System.Collections.Generic;

namespace MonosAnillos
{
    class BookOfSpells
    {
    private string Name {get; set;}
    private int Dmg {get; set;}
    private int Def {get; set;}
    private List<Spell> Spells {get; set;}

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
