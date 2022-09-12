using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    class Elf
    {
        public string Nombre  {get; set;}
        public int HP{get; set;}

        public int Attack {get; set;}

        public int Defense {get; set;}

        List <string> items= new List<string>();
        public Elf (string nombre )
        {   
            this.Nombre= nombre;
            this.HP= 100;
            this.Attack= 50;
            this.Defense= 25;
        }

        public int GetDamage
        {
            get
            {
                return this.Attack;
            }
        }
        public int GetDefense
        {
            get
            {
                return this.Defense;
            }
        }

        public int GetHP
        {
            get
            {
                return this.HP;
            }
        }

        public void AddItem (item)
        {
            items.Add(item);
        }

        public void RemoveItem(item)
        {
            items.Remove(item);
        }

    }
}