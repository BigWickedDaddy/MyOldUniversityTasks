using System;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            INumber[] numbers = new INumber[]
            {
                new SimpleLongNumber(5),
                new VeryLongNumber("5"),
            };
            var sum = numbers[0].Add(numbers[1]);
        }

        interface INumber
        {
            long Value { get; }
            INumber Add(INumber n);
            INumber Sub(INumber n);
            int CompareTo(INumber n);
        }

        class NotNaturalNumberException : Exception
        {
            public NotNaturalNumberException(string message) : base(message)
            {

            }
        }

        class SimpleLongNumber : INumber
        {
            private long _value;

            public long Value
            {
                get => _value;
                set
                {
                    if (value < 0)
                    {
                        throw new NotNaturalNumberException("Не натуральное");
                    }
                    _value = value;
                }
            }

            public SimpleLongNumber(long num) => Value = num;
            public INumber Add(INumber n)
            {
                return new SimpleLongNumber(Value + n.Value);
            }

            public INumber Sub(INumber n)
            {
                return new SimpleLongNumber(Value - n.Value);
            }

            public int CompareTo(INumber n)
            {
                if (Value > n.Value) return 1;
                if (Value == n.Value) return 0;
                return -1;
            }
        }

        class VeryLongNumber : INumber
        {
            private string _value;

            public long Value
            {
                get => Convert.ToInt64(_value);
                set
                {
                    if (Convert.ToInt64(value) < 0)
                    {
                        throw new NotNaturalNumberException("Не натуральное");
                    }
                    _value = Convert.ToString(value);
                }
            }

            public VeryLongNumber(string num) => Value = Convert.ToInt64(num);
            public INumber Add(INumber n)
            {
                return new VeryLongNumber(Convert.ToString(Value + n.Value));
            }

            public INumber Sub(INumber n)
            {
                return new VeryLongNumber(Convert.ToString(Value - n.Value));
            }

            public int CompareTo(INumber n)
            {
                if (Value > n.Value) return 1;
                if (Value == n.Value) return 0;
                return -1;
            }
        }        
    }
}
