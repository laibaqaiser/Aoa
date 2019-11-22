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
        private Nodes left;
        private Nodes right;

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

        internal Nodes Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        internal Nodes Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }
    }
}
