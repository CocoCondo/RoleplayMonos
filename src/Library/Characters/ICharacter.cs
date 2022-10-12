
using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    public interface ICharacters
    {
        public string Name  {get; set;}
        public int HP{get; set;}
        public int Attack {get; set;}
        public int Defense {get; set;}
        public List <IItem> Items {get; set;}
        public void Attacking(ICharacters target);
        public void Healing(ICharacters target, int value);
        public void Add_Item(IItem item);
        public void Remove_Item(IItem item);
    }
}