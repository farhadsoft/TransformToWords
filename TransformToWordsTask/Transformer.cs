using System;
using System.Globalization;
using System.Text;

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

            StringBuilder str = new StringBuilder();
            var nums = number.ToString(CultureInfo.CurrentCulture).ToCharArray();

            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case '-':
                        str.Append("minus");
                        break;
                    case '+':
                        str.Append("plus");
                        break;
                    case 'E':
                        str.Append("E");
                        break;
                    case '0':
                        str.Append("zero");
                        break;
                    case '1':
                        str.Append("one");
                        break;
                    case '2':
                        str.Append("two");
                        break;
                    case '3':
                        str.Append("three");
                        break;
                    case '4':
                        str.Append("four");
                        break;
                    case '5':
                        str.Append("five");
                        break;
                    case '6':
                        str.Append("six");
                        break;
                    case '7':
                        str.Append("seven");
                        break;
                    case '8':
                        str.Append("eight");
                        break;
                    case '9':
                        str.Append("nine");
                        break;
                    case ',':
                    case '.':
                        str.Append("point");
                        break;
                }

                if (i < nums.Length - 1)
                {
                    str.Append(" ");
                }
            }

            string result = str.ToString();

            return char.ToUpper(result[0], CultureInfo.CurrentCulture) + result[1..];
        }
    }
}
