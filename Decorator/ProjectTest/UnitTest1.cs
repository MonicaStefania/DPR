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
            double current = myHero.Damage();
            AddArmor armor = new AddArmor(myHero);
            armor.Damage();

            Assert.Equals(current, armor.getDamage());

        }
        [TestMethod]
        public void TestAddScrolls()
        {
            ICharacter myHero = new Mage();
            double current = myHero.Intelligence();

            AddScrolls scroll = new AddScrolls(myHero);
            scroll.Intelligence();

            Assert.AreEqual(current, scroll.getIntelligence());
        }
        [TestMethod]
        public void TestAddPVPGear()
        {
            ICharacter myHero = new Mage();
            double current = myHero.Price();

            AddPVPGear gear = new AddPVPGear(myHero);

            Assert.AreEqual(current, gear.getPrice());
                   }
    }
}
