
using System;
using System.Collections.Generic;
namespace MonosAnillos;

    class Wizard{
        string Name {get; set;}
        int Hp {get; set;}
        List <Item> Items {get; set;}

        public Wizard( string nombre,int salud){
            this.Name=nombre;
            this.Hp=salud;

        }
        
        public void Add_Item(Item item){
            this.Items.Add(item);
        }
        public static void Add_Item(Wizard wiz, Item item){
            if(wiz.Items.Contains(item)){
            wiz.Items.Remove(item);
            }
        
        }
    }