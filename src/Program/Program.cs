using System;

namespace MonosAnillos
{
    class Program
    {
        static void Main()
        {
            ICharacter elfo1=new Elf("Legolos");
            ICharacter enano1=new Dwarf("Gimpo");
            ICharacter mago1=new Wizard("Look at my horse my horse is amazing");
            IItem espada1=new AttackItem("espada platino de fuego","duh",25,true);
            IItem baculo1=new AttackDefenceItem("palo","una rama del arbol sagrado de Usfequiztan",10,5,true);
            IItem escudo1=new DefenceItem("escudo de cortesa","una corteza de un arbol cualquiera de Usfequiztan",18,false);
            IItem espada2=new AttackItem("espada platino","la espada platino de fuego luego de ser apagada",24,false);

            
            mago1.Add_Item(baculo1);
            enano1.Add_Item(escudo1);
            Console.WriteLine(enano1);
            elfo1.Add_Item(espada1);
            elfo1.Attacking(enano1);
            elfo1.Add_Item(espada2);
            elfo1.Attacking(enano1);
            enano1.Remove_Item(escudo1);
            elfo1.Attacking(enano1);

            Console.WriteLine(enano1);
        
        }
    }
}
