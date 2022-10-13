using MonosAnillos;


namespace Test.Library
{
    [TestFixture]
    public class WizardTest
    {
        [Test]
        public void IsWizardAttacked()
        {
            const int expected = 30;
            ICharacter mago = new Wizard("maguito");
            ICharacter elfo = new Elf("elfito");
            elfo.Attacking(mago);
            Assert.AreEqual(expected, mago.HP);
        }
        [Test]
        public void IsWizardGivenItemMagical()
        {
            AttackItem espada = new AttackItem("espadita","corta",10,true);
            ICharacter mago = new Wizard("maguito");
            mago.Add_Item(espada);
            Assert.Contains(espada,mago.Items);
        }
    }
}



