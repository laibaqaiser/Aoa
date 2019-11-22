using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Encryption
{
    class HuffmanTree
    {
        private Nodes root;
        Nodes n = new Nodes();
        private List<Nodes> nodes = new List<Nodes>();
<<<<<<< HEAD
        private List<bool> encoding = new List<bool>();
       public  void Encoding(string testString)
        {
            /*List<bool> e=Root.PrintTree(testString[3], new List<bool>());
            encoding.AddRange(e);*/
           
            
            foreach(var v in testString)
            {
                List<bool> e =this.Root.PrintTree(v,new List<bool> ());
                encoding.AddRange(e);
            }
            foreach (var v  in encoding)
            {
                Console.Write((v ? 1 : 0) + "");
            }
            
        }       
=======
        private Nodes root;

>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
        internal Nodes Root
        {
            get
            {
                return root;
            }

            set
            {
                root = value;
            }
        }

<<<<<<< HEAD
       
=======
>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
        public void tree(string testString)
        {

            Dictionary<char, int> frequencyTable = new Dictionary<char, int>();
            for (int i = 0; i < testString.Length; i++)
            {
                if (!frequencyTable.ContainsKey(testString[i]))
                {
                    frequencyTable.Add(testString[i], 0);
                }
                frequencyTable[testString[i]]++;
            }
            foreach (var value in frequencyTable.Values)
            {
                Console.WriteLine("Value of the Dictionary Item is: {0}", value);
            }
            Console.WriteLine("You entered '{0}'", testString);

            foreach (KeyValuePair<char, int> letter in frequencyTable)
            {
                Nodes n = new Nodes();
                n.Letter = letter.Key;
                n.Frequency = letter.Value;
                nodes.Add(n);
            }
<<<<<<< HEAD
             while (nodes.Count>1)
             {
                 List<Nodes> orderedNodes = nodes.OrderBy(nodes => nodes.Frequency).ToList<Nodes>();
                 if (orderedNodes.Count >= 2)
                 {
                     var element1 = orderedNodes[0];
                     var element2 = orderedNodes[1];
=======

            
                while(nodes.Count > 1)
             {
                List<Nodes> orderedNodes = nodes.OrderBy(nodes => nodes.Frequency).ToList<Nodes>();
                if (orderedNodes.Count >= 2)
                {
                    var element1 = orderedNodes[0];
                    var element2 = orderedNodes[1];
>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
                    Nodes parentNode = new Nodes();
                    parentNode.Letter = 'p';
                    parentNode.Frequency = element1.Frequency + element2.Frequency;
                    parentNode.Left = element1;
                    parentNode.Right = element2;
<<<<<<< HEAD
                    
=======

>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
                    nodes.Add(parentNode);
                    nodes.Remove(element1);
                    nodes.Remove(element2);
                }
<<<<<<< HEAD
                 this.Root = nodes.FirstOrDefault();
             }
            


            int p1 = 0;
                foreach (Nodes n in nodes)
                {
                    Console.Write("At Position {0}: ", p1);
                    Console.WriteLine(n.Letter);
                    Console.WriteLine(n.Frequency);
                    p1++;
                }
            
=======
                this.Root = nodes.FirstOrDefault();
            }
            

            int p1 = 0;
            foreach (Nodes n in nodes)
            {
                Console.Write("At Position {0}: ", p1);
                Console.WriteLine(n.Letter);
                Console.WriteLine(n.Frequency);
                p1++;
            }
>>>>>>> 44f65a0ddd3604b75482c1fcd66ec9567990a75e
        }
       
    }
}
