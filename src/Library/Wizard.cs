namespace Test.Library
{
    class Wizard{
        string Name {get; set;}
        int Hp {get; set;}
        List<Item> Items {get; set;}

        public Wizard( string nombre,int salud){
            this.Name=nombre;
            this.Hp=salud;

        }
        
        public void Add_Item(Item item){
            this.Items.add(item);
        }
        public static void Add_Item(Wizard wiz, Item item){
            if(item in wiz.Items){
            wiz.Items.remove(item);
            }
        
        }
    }
}