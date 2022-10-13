using System;
using System.Collections.Generic;
namespace MonosAnillos
{
    public class Elf : ICharacters
    {
        public string Name  {get; set;}
        public int HP{get; set;}
        public int Attack {get; set;}
        public int Defense {get; set;}
        public List <IItem> Items {get; set;}

        public Elf (string nombre )
        {   
            this.Name= nombre;
            this.HP= 100;
            this.Attack= 50;
            this.Defense= 25;
        }

        public void Attacking(ICharacters target){
            if(target.Defense<this.Attack){
                target.HP=target.HP+target.Defense-this.Attack;
            }
        }
        public void Healing(ICharacters target, int valor){
            target.HP=target.HP+valor;
        }
        public void Add_Item(IItem item){
            this.Items.Add(item);
            if((item is IAttackItem)){
                this.Attack=(item as IAttackItem).Dmg+this.Attack;
            }
            if((item is IDefenceItem)){
                this.Defense=(item as IDefenceItem).Def+this.Defense;
            }
        }
        public void Remove_Item(IItem item){
            if(this.Items.Contains(item)){
            this.Items.Remove(item);
            }
            if((item is IAttackItem)){
                this.Attack=(item as IAttackItem).Dmg-this.Attack;
            }
            if((item is IDefenceItem)){
                this.Defense=(item as IDefenceItem).Def-this.Defense;
            }
        

    }
}
}