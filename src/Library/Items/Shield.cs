namespace MonosAnillos;
using System;
using System.Collections.Generic;

class Shield
{
    private string Name {get; set;}
    private int Def {get; set;}

    public Shield(string name, int def)
    {
        this.Name = name;
        this.Def = def;
    }
}
