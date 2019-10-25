using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
         public class CharacterTest
         {
                  [Test]
                  public void RemoveMagicItemAttack()
                  {
                           Wizard wizard = new Wizard("gandalf");
                           int AttackExpected = 80;
                           Assert.AreEqual(AttackExpected, wizard.AttackPower);

                           wizard.RemoveItem(wizard.Items[0]);
                           int AttackExpected2 = 0;
                           Assert.AreEqual(AttackExpected2, wizard.AttackPower);
                  }
                  [Test]
                  public void RemoveMagicItemDefense()
                  {
                           Wizard wizard = new Wizard("gandalf");
                           int DefenseExpected = 30;
                           Assert.AreEqual(DefenseExpected, wizard.DefensePower);

                           wizard.RemoveItem(wizard.Items[0]);
                           int DefenseExpected2 = 0;
                           Assert.AreEqual(DefenseExpected2, wizard.DefensePower);
                  }
                  [Test]
                  public void AttackWithHelth()
                  {
                           Wizard wizard = new Wizard("gandalf");
                           int Health = wizard.Health;
                           int Defense = wizard.DefensePower;
                           wizard.ReceiveAttack(Health + Defense);

                           int HealthExpected = 0;
                           
                           wizard.ReceiveAttack(20);
                           Assert.AreEqual(HealthExpected,wizard.Health);
                  }
                  [Test]
                  public void AttackWithArmor()
                  {
                           Wizard wizard = new Wizard("gandalf");
                           int Health = wizard.Health;
                           int Defense = wizard.DefensePower;
                           wizard.ReceiveAttack(10);

                           int HealthExpected = 80;
                           
                           Assert.AreEqual(HealthExpected,wizard.Health);
                  }
         }
}