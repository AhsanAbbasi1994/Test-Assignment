using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pre.Employment.Test
{
    public class GenerateGUID
    {
        //signle object for Random Class
        private static readonly Random randomObj = new Random();
        public static void Main()
        {
            //Collect each Random parts to List
            List<string> guidParts = new List<string>
            {
                GenerateHex(8),
                GenerateHex(4),
                GenerateHex(4),
                GenerateHex(4),
                GenerateHex(12)
            };

            //join with flallted the list items with a delimeter 
            string guid = string.Join("-", guidParts);

            //this section can be ignored only for the test information
            #region canndidate information
            //just to chagne the cosole text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name: Ahsan Aziz Abbasi");
            Console.WriteLine("Position: Dot Net Engineer");
            Console.WriteLine("Assignment: Pre-Employment Test Assignments");
            Console.WriteLine("Company: 01 Systems, Bahrain");
            #endregion

            Console.ForegroundColor = ConsoleColor.Red;

            //print the required result
            Console.WriteLine("\n\nGlobally Unique Identifier:\n" + guid + "\n\n");
        }
        private static string GenerateHex(int length)
        {
            var hex = new char[length];
            //assigning domain for 16bit HEX
            const string hexChars = "0123456789ABCDEF";

            for (int i = 0; i < length; i++)
            {
                hex[i] = hexChars[randomObj.Next(hexChars.Length)];
            }

            return new string(hex);
        }

    }

}

