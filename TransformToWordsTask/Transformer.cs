using System;
using System.Globalization;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            if (number is double.NaN)
            {
                return "NaN";
            }

            if (number is double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (number is double.NegativeInfinity)
            {
                return "Negative Infinity";
            }

            if (number is double.PositiveInfinity)
            {
                return "Positive Infinity";
            }

            string result = default;
            var nums = number.ToString(CultureInfo.CurrentCulture).ToCharArray();

            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case '-':
                        result += "minus";
                        break;
                    case '+':
                        result += "plus";
                        break;
                    case 'E':
                        result += "E";
                        break;
                    case '0':
                        result += "zero";
                        break;
                    case '1':
                        result += "one";
                        break;
                    case '2':
                        result += "two";
                        break;
                    case '3':
                        result += "three";
                        break;
                    case '4':
                        result += "four";
                        break;
                    case '5':
                        result += "five";
                        break;
                    case '6':
                        result += "six";
                        break;
                    case '7':
                        result += "seven";
                        break;
                    case '8':
                        result += "eight";
                        break;
                    case '9':
                        result += "nine";
                        break;
                    case ',':
                        result += "point";
                        break;
                }

                if (i < nums.Length - 1)
                {
                    result += " ";
                }
            }

            return char.ToUpper(result[0], CultureInfo.CurrentCulture) + result[1..];
        }
    }
}
