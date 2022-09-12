namespace MonosAnillos;
using System;
using System.Collections.Generic;

class Bow
{
    public int Attack {get; set;}
    public string Name  {get; set;}
    public int Defense {get; set;}

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
