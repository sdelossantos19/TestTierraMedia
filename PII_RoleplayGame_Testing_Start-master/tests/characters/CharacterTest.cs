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

        [Test]
        public void TestDefensePowerSum()
        {
            //Desafio 12
            Wizard wizard = new Wizard("Wizard");
            int baseDefensePower = wizard.DefensePower;
            MagicStick magicStick = new MagicStick();
            Armor armor = new Armor();

            wizard.AddItem(new MagicStick());
            wizard.AddItem(new Armor());

            int defensePowerFromItems = magicStick.DefensePower + armor.DefensePower;
            int expectedDefensePower = baseDefensePower + defensePowerFromItems;
            int actualDefensePower = wizard.DefensePower;

            Assert.AreEqual(expectedDefensePower, actualDefensePower);
        }
        [Test]
        public void CharacterMagicAttack()
        {
            Elf elf1 = new Elf("Elf1");
            Magic magic1 = new Magic();
            elf1.AddItem(magic1);
            int actual = elf1.AttackPower;
            int expected = 80;
            Assert.AreEqual(actual,expected);

        }
        [Test]
        public void CharacterMagicDefense()
        {
            Elf elf1 = new Elf("Elf1");
            Magic magic1 = new Magic();
            elf1.AddItem(magic1);
            int actual = elf1.DefensePower;
            int expected = 32;
            Assert.AreEqual(actual,expected);

        }

        [Test]
        public void CharacterAttack()
        {
            Elf elf1 = new Elf("Elf1");
            Wizard wizard1 = new Wizard("Wizard1");
            elf1.ReceiveAttack(wizard1.AttackPower);
            int actual = elf1.Health;
            int expected = (120 - (80 - 2));
            Assert.AreEqual(actual,expected);

        }

        [Test]
        public void CharacterExceptionItem()
        {
            Wizard wizard = new Wizard("Wizard1");
            Robes robes = new Robes();
            bool throwexcexption = false;
            try
            {
              wizard.RemoveItem(robes);  
            }
            catch (ItemNotFoundException)
            {
                
                throwexcexption = true;
            }
            
            Assert.True(throwexcexption);

        }
    }
}