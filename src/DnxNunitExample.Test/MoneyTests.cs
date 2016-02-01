using NUnit.Framework;

namespace DnxNunitExample.Test
{
  [TestFixture]
  public class MoneyTests
  {
    [TestCase(2, 3, 5)]
    [TestCase(4, 12, 16)]
    [TestCase(0, 3790, 3790)]
    public void AddingSomeMoney(decimal value1, decimal value2, decimal expected)
    {
      var m = new Money(value1);
      var m2 = new Money(value2);
      Assert.That(new Money(expected), Is.EqualTo(m.Add(m2)));
    }

    [TestCase(8, 3, 5)]
    [TestCase(17, 0, 17)]
    [TestCase(3, 8, 0)]
    public void SubtractingSomeMoney(decimal value1, decimal value2, decimal expected)
    {
      var m = new Money(value1);
      var m2 = new Money(value2);
      Assert.That(new Money(expected), Is.EqualTo(m.Subtract(m2)));
    }
  }
}
