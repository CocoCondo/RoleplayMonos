namespace MonosAnillos;
using System;
using System.Collections.Generic;

class Robe
{
    private string Name {get; set;}
    private int Dmg {get; set;}
    private int Def {get; set;}

    public Robe(string name, int dmg, int def)
    {
        this.Name = name;
        this.Dmg = dmg;
        this.Def = def;
    }
}