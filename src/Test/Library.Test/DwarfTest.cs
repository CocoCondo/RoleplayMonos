using MonosAnillos;


namespace Test.Library
{
    [TestFixture]
    public class DwarfTest
    {
        [Test]
        public void IsDwarfGivenItemMagical()
        {
            AttackItem espada = new AttackItem("espadita","corta",10,true);
            ICharacter enano = new Dwarf("enanito");
            bool Contains = enano.Items.Contains(espada);
            bool expected = false;
            enano.Add_Item(espada);
            Assert.AreEqual(expected, Contains);
        }
    }
}
