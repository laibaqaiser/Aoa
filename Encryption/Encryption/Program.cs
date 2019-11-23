﻿using System;
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
            Console.Write("Enter key to decode ");
            string key = Console.ReadLine();
            if (key == "123")
            {
                huffmantree.Decoding();
            }
            else
            {
                Console.WriteLine("Invalid key!!!");
            }
        }
    }
}
