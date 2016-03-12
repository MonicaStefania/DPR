using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator;

namespace ProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddArmor()
        {
            ICharacter myHero = new Mage();
            double current = myHero.Damage() + 15;
            AddArmor armor = new AddArmor(myHero);
            armor.Damage();

            Assert.AreEqual(current, armor.Damage());

        }
        [TestMethod]
        public void TestAddScrolls()
        {
            ICharacter myHero = new Mage();
            AddScrolls scroll = new AddScrolls(myHero);
            scroll.Intelligence();
            double current = myHero.Intelligence() + 150;

            Assert.AreEqual(current, scroll.Intelligence());
        }
        [TestMethod]
        public void TestAddPVPGear()
        {
            ICharacter myHero = new Mage();
            double current = myHero.Price() + 300;
            AddPVPGear gear = new AddPVPGear(myHero);

            Assert.AreEqual(current, gear.Price());
        }
    }
}
