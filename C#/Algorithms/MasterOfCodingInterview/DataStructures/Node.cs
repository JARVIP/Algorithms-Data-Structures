using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.DataStructures
{
    public class Node
    {

        public Node(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
