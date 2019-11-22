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

        public List<bool> PrintTree(char letter, List<bool> data)
        {
            if (Left == null && Right == null)
            {
                if (Letter == letter)
                {
                    return data;
                }
                else
                {
                    return null;
                }

            }
            else

            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);
                    left = Left.PrintTree(letter, leftPath);



                }
                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.PrintTree(letter, rightPath);
                }
                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }

            }
        }
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