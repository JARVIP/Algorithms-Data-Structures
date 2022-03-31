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

        public List<int> BFS()
        {
            var currentNode = root;
            var list = new List<int>();
            var queue = new Queue<Node>();
            queue.Enqueue(currentNode);
            while(queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Value);
                list.Add(currentNode.Value);
                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return list;
        }


        public List<int> DFSInOrder()
        {
            return TraverInOrder(this.root, new List<int>());
        }


        public List<int> DFSPostOrder()
        {
            return TraverPostOrder(this.root, new List<int>());

        }

        public List<int> DFSPreOrder()
        {
            return TraverPreOrder(this.root, new List<int>());

        }

        private List<int> TraverInOrder(Node node, List<int> list)
        {
            if(node.Left != null)
            {
                TraverInOrder(node.Left, list);
            }
            list.Add(node.Value);
            if(node.Right != null)
            {
                TraverInOrder(node.Right, list);
            }
            return list;
        }

        private List<int> TraverPostOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraverPostOrder(node.Left, list);
            }
            if (node.Right != null)
            {
                TraverPostOrder(node.Right, list);
            }
            list.Add(node.Value);
            return list;
        }


        private List<int> TraverPreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);
            if (node.Left != null)
            {
                TraverPreOrder(node.Left, list);
            }
            if (node.Right != null)
            {
                TraverPreOrder(node.Right, list);
            }
            return list;
        }
    }
}
