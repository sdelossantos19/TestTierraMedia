using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
         public class ElfTest
         {
                  [Test]
                  public void TestElfCreator()
                  {
                           Elf elf = new Elf("Legolas");

                           int HealthExpected = 120;
                           bool actual = elf.Items[0] is Robes;
                           

                           Assert.AreEqual(HealthExpected,elf.Health);
                           Assert.AreEqual(actual,true);
                  }
         }
}