using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class HuffmanTree
    {


        Nodes n = new Nodes();
        private List<Nodes> nodes = new List<Nodes>();
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
            List<Nodes> orderedNodes = nodes.OrderBy(nodes => nodes.Frequency).ToList<Nodes>();

            int p1 = 0;
            foreach (Nodes n in orderedNodes)
            {
                Console.Write("At Position {0}: ", p1);
                Console.WriteLine(n.Letter);
                Console.WriteLine(n.Frequency);
                p1++;
            }
        }

    }
}
