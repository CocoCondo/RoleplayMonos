
using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    public interface ICharacter
    {
        public string Name  {get; set;}
        public int HP{get; set;}
        public int Attack {get; set;}
        public int Defence {get; set;}
        public List <IItem> Items {get; set;}
        public void Attacking(ICharacter target);
        public void Healing(ICharacter target, int value);
        public void Add_Item(IItem item);
        public void Remove_Item(IItem item);
    }
}