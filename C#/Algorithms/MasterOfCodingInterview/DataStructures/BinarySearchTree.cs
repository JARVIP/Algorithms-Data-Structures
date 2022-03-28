using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.DataStructures
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            var newNode = new Node(value);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                var currentNode = root;
                while(true)
                {
                    if (value < currentNode.Value)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            return;
                        }
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        if(currentNode.Right == null)
                        {
                            currentNode.Right = newNode;
                            return;
                        }
                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public bool Lookup(int value)
        {
            if(this.root == null)
            {
                return false;
            }

            var currentNode = root;
            while(currentNode != null)
            {
                if(value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if(value > currentNode.Value)
                {
                    currentNode=currentNode.Right;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
