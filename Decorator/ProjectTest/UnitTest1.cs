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
    }
}
