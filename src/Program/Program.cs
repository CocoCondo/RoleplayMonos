using System;

namespace MonosAnillos
{
    class Program
    {
        static void Main()
        {
            Elf elfo1=new Elf("Legolos");
            Dwarf enano1=new Dwarf("Gimpo");
            Wizard mago1=new Wizard("Look at my horse my horse is amazing");
            AttackItem espada1=new AttackItem("espada platino de fuego","duh",25,true);
            AttackDefenceItem baculo1=new AttackDefenceItem("palo","una rama del arbol sagrado de Usfequiztan",10,5,true);
            DefenceItem escudo1=new DefenceItem("escudo de cortesa","una corteza de un arbol cualquiera de Usfequiztan",18,false);
            AttackItem espada2=new AttackItem("espada platino","la espada platino de fuego luego de ser apagada",24,false);

            mago1.Add_Item(baculo1);
            enano1.Add_Item(escudo1);
            elfo1.Add_Item(espada1);
            elfo1.Attacking(enano1);
            elfo1.Add_Item(espada2);
            elfo1.Attacking(enano1);
            enano1.Remove_Item(escudo1);
            elfo1.Attacking(enano1);


        
        }
    }
}
