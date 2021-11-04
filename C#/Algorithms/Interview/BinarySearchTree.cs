using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview
{

    public class Node
    {
        public int data;
        public Node leftChild = null;
        public Node rigthChild = null;
        public Node parent;

        public Node(int data, Node parent)
        {
            this.data = data;
            this.parent = parent;
        }
    }

    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int data)
        {
            if(root == null)
            {
                root = new Node(data, null);
            }
            else
            {
                InsertNode(data, root);
            }
        }

        public void Traverse()
        {
            if(root != null)
            {
                TraverseInOrder(root);
            }
        }

        public int GetMaxValue()
        {
            if(root != null)
            {
                return GetMax(root);
            }
            return 0;
        }


        public int GetMinValue()
        {
            if (root != null)
            {
                return GetMin(root);
            }
            return 0;
        }

        public void Remove(int data)
        {
            if(root != null)
            {
                RemoveNode(data, root);
            }
        }
        private void RemoveNode(int data, Node node)
        {
            if(node == null)
            {
                return;
            }

            if(data < node.data)
            {
                RemoveNode(data, node.leftChild);
            }else if(data > node.data)
            {
                RemoveNode(data, node.rigthChild);
            }
            else
            {
                if(node.leftChild == null && node.rigthChild == null)
                {
                    Console.WriteLine("Removing a leaf node " + node.data);
                    var parent = node.parent;
                    if(parent != null && parent.leftChild == node)
                    {
                        parent.leftChild = null;
                    }
                    if(parent != null && parent.rigthChild == node)
                    {
                        parent.rigthChild = null;
                    }    
                    if(parent == null)
                    {
                        root = null;
                    }
                }else if(node.leftChild == null && node.rigthChild != null)
                {
                    Console.WriteLine("Removing a node with single right child...");

                    var parent = node.parent;

                    if(parent != null)
                    {
                        if(parent.leftChild == node)
                        {
                            parent.leftChild = node.leftChild;
                        }
                        if(parent.rigthChild == node)
                        {
                            parent.rigthChild = node.rigthChild;
                        }
                    }
                    else
                    {
                        root = node.rigthChild;
                    }
                    node.rigthChild.parent = parent;
                }
                else if(node.rigthChild == null && node.leftChild != null)
                {
                    Console.WriteLine("Removing a node with single left child...");

                    var parent = node.parent;

                    if(parent != null)
                    {
                        if(parent.leftChild == node)
                        {
                            parent.leftChild = node.leftChild;
                        }
                        if(parent.rigthChild == node)
                        {
                            parent.rigthChild = node.rigthChild;
                        }
                    }
                    else
                    {
                        root = node.leftChild;
                    }
                    node.leftChild.parent = parent;
                }
                else
                {
                    Console.WriteLine("Removing a node with two children...");

                    var predecessor = GetPredecessor(node.leftChild);

                    var temp = predecessor.data;
                    predecessor.data = node.data;
                    node.data = temp;

                    RemoveNode(data, predecessor);
                }
            }
        }

        private Node GetPredecessor(Node node)
        {
            if(node.rigthChild != null)
            {
                return GetPredecessor(node.rigthChild);
            }
            return node;
        }

        private int GetMin(Node node)
        {
            if (node.leftChild != null)
            {
                return GetMin(node.leftChild);
            }
            else
            {
                return node.data;
            }
        }
        private void TraverseInOrder(Node node)
        {
            if (node.leftChild != null)
            {
                TraverseInOrder(node.leftChild);
            }

            Console.WriteLine(node.data);

            if (node.rigthChild != null)
            {
                TraverseInOrder(node.rigthChild);
            }
        }

        private int GetMax(Node node)
        {
            if (node.rigthChild != null)
            {
                return GetMax(node.rigthChild);
            }
            else
            {
                return node.data;
            }
        }

        private void InsertNode(int data, Node node)
        {
            if (data < node.data)
            {
                if (node.leftChild != null)
                {
                    InsertNode(data, node.leftChild);
                }
                else
                {
                    node.leftChild = new Node(data, node);
                }
            }
            else
            {
                if (node.rigthChild != null)
                {
                    InsertNode(data, node.rigthChild);
                }
                else
                {
                    node.rigthChild = new Node(data, node);
                }
            }
        }
    }
}
