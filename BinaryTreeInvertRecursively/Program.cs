using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInvertRecursively
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 7,6,5,4,3,2,1};
            BinaryTree tree = new BinaryTree(values);
            Console.WriteLine("Before Invert: ");
            Console.WriteLine($"\t\t\t {tree.value}");
            Console.WriteLine("\t\t\t/\\");
            Console.WriteLine("\t\t       /  \\");
            Console.WriteLine($"\t\t      {tree.left.value}    {tree.right.value}");
            Console.WriteLine("\t\t     /\\\t  /\\");
            Console.WriteLine($"\t\t    {tree.left.left.value} {tree.left.right.value}\t {tree.right.left.value} {tree.right.right.value}");
            InvertTree(tree);
            Console.WriteLine("After Invert: ");
            Console.WriteLine($"\t\t\t {tree.value}");
            Console.WriteLine("\t\t\t/\\");
            Console.WriteLine("\t\t       /  \\");
            Console.WriteLine($"\t\t      {tree.left.value}    {tree.right.value}");
            Console.WriteLine("\t\t     /\\\t  /\\");
            Console.WriteLine($"\t\t    {tree.left.left.value} {tree.left.right.value}\t {tree.right.left.value} {tree.right.right.value}");

        }

        static BinaryTree InvertTree(BinaryTree tree)
        {
            if (tree == null) return null;

            var left = tree.left;
            tree.left = InvertTree(tree.right);
            tree.right = InvertTree(left);
            return tree;
        }

        }
    }
}
