using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class WizardTest
    {
        [Test]
        public void TestCreation()
        {
            //Desafio 5
            Wizard wizard = new Wizard("wizard");
            int expectedHealth = 80;
            IItem expectedMagic = wizard.Items[0];
            bool findMagic = false;

            foreach (IItem item in wizard.Items)
            {
                if (item is Magic)
                {
                    findMagic = true;
                    break;
                }
            }
            
            Assert.True(findMagic);
            Assert.AreEqual(wizard.Health, expectedHealth);
        }
    }
}