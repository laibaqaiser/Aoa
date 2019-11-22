using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{


    class Nodes
    {
        private char letter;
        private int frequency;

        public char Letter
        {
            get
            {
                return letter;
            }

            set
            {
                letter = value;
            }
        }

        public int Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                frequency = value;
            }
        }

    }
}
