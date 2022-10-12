
using System;
using System.Collections.Generic;

namespace MonosAnillos
{
class Bow : IItem
    {
        public string Name {get;}
        public int Dmg {get;}
        public int Def {get;}

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
