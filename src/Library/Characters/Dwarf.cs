
using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    public class Dwarf : ICharacters{
        public string Name  {get; set;}
        public int HP{get; set;}
        public int Attack {get; set;}
        public int Defense {get; set;}
        public List <IItem> Items {get; set;}


        public Dwarf( string nombre,int salud){
            this.Name=nombre;
            this.HP=salud;

        }
        
        public void Attacking(ICharacters target){
            target.HP=target.HP-this.Attack;
        }
        public void Healing(ICharacters target, int valor){
            target.HP=target.HP+valor;
        }
        public void Add_Item(IItem item){
            this.Items.Add(item);
        }
        public void Remove_Item(IItem item){
            if(this.Items.Contains(item)){
            this.Items.Remove(item);
            }
        
        }
    }
}