using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.ValueObjects
{
    public class Money : BaseValueObject<Money>
    {
        public decimal Value { get; }
        public Money(decimal rialValue)
        {
            if (rialValue < 0)
                throw new Exception();
            Value = rialValue;
        }

        public static Money GetToman(decimal value)
        {
            return new Money(value / 10);
        }

        public static Money operator +(Money left, Money right)
        {
            return new Money(left.Value + right.Value);
        }

        public static Money operator -(Money left, Money right)
        {
            return new Money(left.Value - right.Value);
        }

    }
}
