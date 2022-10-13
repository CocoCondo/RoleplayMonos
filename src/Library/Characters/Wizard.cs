
using System;
using System.Collections.Generic;
namespace MonosAnillos
{

    public class Wizard: ICharacter{
        public string Name  {get; set;}
        public int HP{get; set;}
        public int Attack {get; set;}
        public int Defence {get; set;}
        public List<IItem> Items {get; set;}
        

        public Wizard( string nombre){
            this.Name=nombre;
            this.HP=70;
            this.Attack=60;
            this.Defence=10;
            this.Items = new List<IItem>();
        }
        public void Attacking(ICharacter target){
            if(target.Defence<this.Attack){
                target.HP=target.HP+target.Defence-this.Attack;
            }
        }
        public void Healing(ICharacter target, int valor){
            target.HP=target.HP+valor;
        }
        public void Add_Item(IItem item){
            this.Items.Add(item);
            if((item is IAttackItem)){
                this.Attack=(item as IAttackItem).Dmg+this.Attack;
            }
            if((item is IDefenceItem)){
                this.Defence=(item as IDefenceItem).Def+this.Defence;
            }
        }
        public void Remove_Item(IItem item){
            if(this.Items.Contains(item)){
            this.Items.Remove(item);
            }
            if((item is IAttackItem)){
                this.Attack=this.Attack-(item as IAttackItem).Dmg;
            }
            if((item is IDefenceItem)){
                this.Defence=this.Defence-(item as IDefenceItem).Def;
            }
        
        }
        public override string ToString()
        {
            return $"CHARACTER: {this.Name}, HP: {this.HP}, ATTK: {this.Attack}, DEF: {this.Defence}";
        }
}
}