using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

// usar el satus para declarar y definir el World 

namespace Tests
{
    public class CharacterTest
    {
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