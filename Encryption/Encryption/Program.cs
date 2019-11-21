using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            for(int i =0;i< testString.Length;i++)
            {
                if(!frequency.ContainsKey(testString[i]))
                {
                    frequency.Add(testString[i],0);
                }
                frequency[testString[i]]++;
            }

              foreach (var value in frequency.Values)
            {
                Console.WriteLine("Value of the Dictionary Item is: {0}", value);
            }
            Console.WriteLine("You entered '{0}'", testString);
        }
    }
}
