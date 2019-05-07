using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree2
{//str.61/zad.20 + BinarySearchTree /insert/find
    class Node
    {
        public int value;
        public Node left;
        public Node right;

    }

    class Tree
    {


        public Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.value = value;
            }
            else if (value < root.value)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }

            return root;

        }
        public bool Correct(Node root,int value)
        {
            return root.value == value;
        }
        public bool Search(Node root, int value)
        {
            try
            {
                if (root == null || root.value == value)
                {
                    if (root.value == value) Console.WriteLine("["+value+"]"+" found!");
                    return true;

                }
                
                if (root.value > value)
                    return Search(root.left, value);

                
                return Search(root.right, value);
            }
            catch (NullReferenceException) {
                Console.WriteLine("[" + value + "]" + " not found!");
                return false;
            }
        }

        public int FindMinVal(Node root)
        {
            Node current = root;

            while (current.left != null)
            {
                current = current.left;
            }
            return current.value;
        }

        public int FindMaxVal(Node root)
        {
            Node current = root;

            while(current.right!=null)
            {
                current = current.right;
            }
            return current.value;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[] inputs = new int[9] {10,7,15,12,16,5,8,19,14};
            Node root = null;
            Tree binarySearchTree = new Tree();

            for (int i = 0; i < inputs.Length; i++)
            {
                root=binarySearchTree.Insert(root,inputs[i]);
            }
          
            Console.WriteLine(binarySearchTree.FindMinVal(root));
            Console.WriteLine(binarySearchTree.FindMaxVal(root));
           
            Console.WriteLine(binarySearchTree.Search(root, 19));//returns false
            
            


        }
    }
}
