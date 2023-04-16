using System;
using System.Data;
using System.Collections.Generic;
namespace Binary_tree
{

    class Program
    {
        static void Main(string[] agrs)
        {
            BinaryTree<int> root = new BinaryTree<int>(
                        new BinaryTree<int>(
                            new BinaryTree<int>(null, null, "4"),
                            new BinaryTree<int>(null, null, "5"),
                            "2"
                        ),
                        new BinaryTree<int>(
                            new BinaryTree<int>(null, null, "6"),
                            new BinaryTree<int>(null, null, "7"),
                            "3"
                        ),
                        "1"
                    );

            int nodeCount = BinaryTreeNodeCounter.countNodes(root);
            Console.WriteLine("Node count: " + nodeCount);
            string str = "Node count";
            string reversedString = StringReverser.reverseString(str);
            Console.WriteLine(reversedString); // output: "tnuoc edoN"
        }


        public class BinaryTree<T> : IBinaryTree<T>
        {
            private BinaryTree<T> left;
            private BinaryTree<T> right;
            private string data;

            public BinaryTree(BinaryTree<T> left, BinaryTree<T> right, String data)
            {
                this.left = left;
                this.right = right;
                this.data = data;
            }

            public IBinaryTree<T> Left
            {
                get { return this.left; }
            }

            public IBinaryTree<T> Right
            {
                get { return this.right; }
            }

            public String Data
            {
                get { return this.data; }
            }


        }
        public interface IBinaryTree<T>
        {
            IBinaryTree<T> Left { get; }
            IBinaryTree<T> Right { get; }
            String Data { get; }
        }

        public static class BinaryTreeNodeCounter
        {
            public static int countNodes<T>(IBinaryTree<T> tree)
            {
                // TODO: What goes here?
                if (tree == null)
                {
                    return 0;
                }
                else
                {
                    int count = 1;
                    count += countNodes(tree.Left);
                    count += countNodes(tree.Right);
                    return count;
                }
            }

        }
        public static class StringReverser
        {
            public static String reverseString(String str)
            {
                // return reversed string
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }






    }


}