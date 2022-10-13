using MonosAnillos;


namespace Test.Library
{
    [TestFixture]
    public class ElfTest
    {
        [Test]
        public void IsElfHealed()
        {
            const int expected = 120;
            ICharacter elfo = new Elf("elfito");
            elfo.Healing(elfo,20);
            Assert.AreEqual(expected, elfo.HP);
        }
    }
}
