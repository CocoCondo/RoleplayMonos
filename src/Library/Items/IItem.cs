using System;
using System.Collections.Generic;
namespace MonosAnillos
{   
    public interface IItem
    {
        public string Name {get;}
        public string Description {get;}
        public bool IsItemMagical {get;}
    }
}