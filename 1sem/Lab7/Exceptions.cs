using System;

namespace Lab7                          //7
{


    class WrongCostValue : Exception
    {
        public WrongCostValue(string message) : base(message)
        {

        }
    }

    class WrongName : ArgumentOutOfRangeException
    {
        int Value { get; set; }
        public WrongName(string message, byte value) : base(message)
        {
            Value = value;

        }
    }


    class IsNotMechanism : ArgumentException
    {
        string Value { get; set; }
        public IsNotMechanism(string message, string value) : base(message)
        {
            Value = value;

        }
    }

    class IsNotName : ArgumentException
    {
        string Value { get; set; }
        public IsNotName(string message, string value) : base(message)
        {
            Value = value;

        }
    }

}
