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
<<<<<<< HEAD
           HuffmanTree huffmantree = new HuffmanTree();
            string testString = System.IO.File.ReadAllText(@"C:\Users\MAHNOOR\Desktop\Encryption\Aoa\Encryption\Encryption\code.txt");
=======
            HuffmanTree huffmantree = new HuffmanTree();
            string testString = System.IO.File.ReadAllText(@"C:\Users\Muhammad Muzzamil\Documents\AoaProject\Aoa\Encryption\Encryption\code.txt");
>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
            huffmantree.tree(testString);
            huffmantree.Encoding(testString);

        }
    }
}
