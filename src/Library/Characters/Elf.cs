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

        private List<Object> ItemsElves {get; set;}
        List<Object> itemsElves = new List<Object>();
        public Elf (string nombre )
        {   
            this.Nombre= nombre;
            this.HP= 100;
            this.Attack= 50;
            this.Defense= 25;
            this.ItemsElves = itemsElves;
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

       //public void Add_Item(Item item)

    }
}