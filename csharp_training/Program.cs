using System;
using System.Text;

namespace csharp_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a string's characters
            // as ASCII and returns each character's
            // hexadecimal value as a string.
            // hex characters must be lowercase
            // each byte must be seperated by a space

            string huhu = "ich bins nur";

            Console.WriteLine(stringIntoHex(huhu));

            Console.ReadKey();
        }

        protected static string stringIntoHex(string huch)
        {
            // ASCII for each char
            // from ASCII representation to HEX
            // ASCII value / 16 = first digit
            // remaining = second digit ( in hex notation ) 
            // hex notation being : 0 1 2 3 4 5 6 7 8 9 A B C D E F 
            // 16 possible values

            string finalValue = null;
            int value;

            foreach(char c in huch)
            {
                value = Convert.ToInt32(c);
                finalValue = String.Format("{0} {1:X}", finalValue, value);
            }
           

            return finalValue.TrimEnd().ToLower();
        }
    }
}
