using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
         public class TrollTest
         {
                  [Test]
                  public void TestTrollCreator()
                  {
                           Troll troll = new Troll("Troll");

                           int HealthExpected = 150;
                           bool actualStick = troll.Items[0] is Stick;
                           bool actualArmor = troll.Items[1] is Armor;


                           Assert.AreEqual(HealthExpected, troll.Health);
                           Assert.AreEqual(actualStick, true);
                           Assert.AreEqual(actualArmor, true);
                  }
         }
}