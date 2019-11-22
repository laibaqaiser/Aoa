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
            string testString = System.IO.File.ReadAllText(@"C:\Users\Muhammad Muzzamil\Documents\AoaProject\Aoa\Encryption\Encryption\code.txt");
            huffmantree.tree(testString);
        }
    }
}
