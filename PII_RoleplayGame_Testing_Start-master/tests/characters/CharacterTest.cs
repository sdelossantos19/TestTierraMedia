using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class CharacterTest
    {
        [Test]
        public void TestDeath()
        {
            //Desafio 6
            Wizard wizard = new Wizard("wizard");

            int health = wizard.Health;
            int defensePower = 0;
            foreach (IItem item in wizard.Items)
            {
                if (item is IDefenseItem)
                {
                    defensePower += ((IDefenseItem)item).DefensePower;
                }
            }

            wizard.ReceiveAttack(health + defensePower);

            bool expectedDeathValue = true;
            bool actualDeathValue = wizard.IsDead;

            Assert.AreEqual(expectedDeathValue, actualDeathValue);
        }

        [Test]
        public void TestAttackPowerSum()
        {
            //Desafio 11
            Wizard wizard = new Wizard("Wizard");
            int baseAtackPower = wizard.AttackPower;
            MagicStick magicStick = new MagicStick();
            Gauntlet gauntlet = new Gauntlet();

            wizard.AddItem(new MagicStick());
            wizard.AddItem(new Gauntlet());

            int atackPowerFromItems = magicStick.AttackPower + gauntlet.AttackPower;
            int expectedAtackPower = baseAtackPower + atackPowerFromItems;
            int actualAtackPower = wizard.AttackPower;

            Assert.AreEqual(expectedAtackPower, actualAtackPower);
        }
    }
}