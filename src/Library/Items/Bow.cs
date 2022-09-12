
using System;
using System.Collections.Generic;

namespace MonosAnillos
{
class Bow
{
    private int Attack {get; set;}
    private string Name  {get; set;}
    private int Defense {get; set;}

    public Bow (string name, int attack, int defense)
    {
        this.Name= name;
        this.Attack= attack;
        this.Defense= defense;
    }

    public string GetName()
    {
        return this.Name;
    }
    public int GetAttack()
    {
        return this.Attack;
    }
    public int GetDefense()
    {
        return this.Defense;
    }

}

}
