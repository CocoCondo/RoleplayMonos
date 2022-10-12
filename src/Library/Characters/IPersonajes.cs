
using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    interface ICharacters
    {
        public string Nombre  {get; set;}
        public int HP{get; set;}

        public int Attack {get; set;}

        public int Defense {get; set;}
        List <Item> Items {get; set;}
    void SampleMethod();
    }
}