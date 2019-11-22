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
        private List<bool> encoding = new List<bool>();
        public void Encoding(string testString)
        {
            foreach (var v in testString)
            {
                List<bool> e = this.Root.PrintTree(v, new List<bool>());
                encoding.AddRange(e);
            }
            foreach (var v in encoding)
            {
                Console.Write((v ? 1 : 0) + "");
            }

        }

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
            while (nodes.Count > 1)
            {
                List<Nodes> orderedNodes = nodes.OrderBy(nodes => nodes.Frequency).ToList<Nodes>();
                if (orderedNodes.Count >= 2)
                {
                    var element1 = orderedNodes[0];
                    var element2 = orderedNodes[1];
                    Nodes parentNode = new Nodes();
                    parentNode.Letter = 'p';
                    parentNode.Frequency = element1.Frequency + element2.Frequency;
                    parentNode.Left = element1;
                    nodes.Add(parentNode);
                    nodes.Remove(element1);
                    nodes.Remove(element2);
                }
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
        }

    }
}

