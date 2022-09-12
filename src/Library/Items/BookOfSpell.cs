namespace MonosAnillos;
using System;
using System.Collections.Generic;

class BookOfSpell
{
    private string Name {get; set;}
    private int Dmg {get; set;}
    private int Def {get; set;}
    private List<Spell> Spells {get; set;}

    public BookOfSpell(string name, int dmg, int def)
    {
        this.Name = name;
        this.Dmg = dmg;
        this.Def = def;
    }
}
