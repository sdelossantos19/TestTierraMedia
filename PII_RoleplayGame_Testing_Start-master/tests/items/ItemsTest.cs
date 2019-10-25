using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoleplayGame.Items;

// usar el satus para declarar y definir el World 

namespace Tests
{
    public class ItemsTest
    {
        [Test]
        public void MagicStickAttack()
        {
            MagicStick magicStick1 = new MagicStick();
            Magic magic1 = new Magic();
            Stick stick1 = new Stick();
            int AtaqueMagia = magic1.AttackPower;
            int AtaqueStick = stick1.AttackPower;
            int Actual = (AtaqueMagia + (AtaqueStick * 3));
            int expected = magicStick1.AttackPower;
            Assert.AreEqual(Actual,expected);

        }
        [Test]
        public void MagicStickDefense()
        {
            MagicStick magicStick1 = new MagicStick();
            Magic magic1 = new Magic();
            int actual = magicStick1.DefensePower;
            int expected = magic1.DefensePower;
            Assert.AreEqual(actual,expected);
        }
    }

}