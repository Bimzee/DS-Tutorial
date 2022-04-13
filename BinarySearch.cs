using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class BinarySearch
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public void Display()
            {
                Console.Write(data + " ");
            }
        }
        public Node root;

        public BinarySearch()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }
        public void Preorder(Node Root)
        {
            //https://www.csharpstar.com/csharp-program-to-implement-binary-search-tree-traversal/
            if (Root != null)
            {
                Console.Write(Root.data + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }

        public void Insert(int i)
        {
            Node newNode = new Node();

            newNode.data = i;

            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }

        }
    }
}
