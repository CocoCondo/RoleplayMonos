
using System;
using System.Collections.Generic;
namespace MonosAnillos;

    class Dwarf{
        string Name {get; set;}
        int Hp {get; set;}
        List <Item> Items {get; set;}

        public Dwarf( string nombre,int salud){
            this.Name=nombre;
            this.Hp=salud;

        }
        
        public void Add_Item(Item item){
            this.Items.Add(item);
        }
        public static void Add_Item(Dwarf dwa, Item item){
            if(dwa.Items.Contains(item)){
            dwa.Items.Remove(item);
            }
        
        }
    }
