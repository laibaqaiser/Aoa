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
            HuffmanTree huffmantree = new HuffmanTree();
            string testString = System.IO.File.ReadAllText(@"C:\Users\MAHNOOR\Desktop\Encryption\Aoa\Encryption\Encryption\code.txt");
            huffmantree.tree(testString);
            huffmantree.Encoding(testString);
            Console.WriteLine("");
            Console.WriteLine("You have 3 attempts to decode");
            int tries = 1;
            while (tries <= 3)
            {
                Console.Write("Enter key to decode ");
                string key = Console.ReadLine();
                if (key == "123")
                {
                    Console.Write("You entered a valid key.");
                    huffmantree.Decoding();
                    break;
                }
                else
                {
                    Console.WriteLine("You entered an Invalid key!!!");
                    tries++;
                }
            }
        }
    }
}
