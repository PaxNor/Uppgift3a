using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3.2


namespace Uppgift3a
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }

    // sub classes
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // my sub classes
    internal class NumericRangeError : UserError
    {
        public override string UEMessage()
        {
            return "Your input exceeded the allowed range. This fired an error!";
        }
    }

    internal class FloatingPointError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a floating point number in an integer only input field. This fired an error!";
        }
    }

    internal class NegativeNumberError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter a negative number in a positive number only input field. This fired an error!";
        }
    }

}
