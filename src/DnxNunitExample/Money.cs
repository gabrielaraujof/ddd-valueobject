using System.Collections.Generic;

namespace DnxNunitExample
{
  public class Money : ValueObject<Money>
  {
    protected readonly decimal Value;

    public Money() : this(0m)
    {
    }

    public Money(decimal value)
    {
      Value = value;
    }

    public Money Add(Money money)
    {
      return new Money(Value + money.Value);
    }

    public Money Subtract(Money money)
    {
      if (money.Value > Value)
        return new Money();

      return new Money(Value - money.Value);
    }

    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
      return new List<object>() { Value };
    }

    public static Money operator + (Money left, Money right)
    {
      return new Money(left.Value + right.Value);
    }

    public static Money operator - (Money left, Money right)
    {
      return new Money(left.Value - right.Value);
    }
  }
}
