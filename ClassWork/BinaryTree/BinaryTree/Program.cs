using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main()
        {
            Tree tree;
            Queue<Tree> trees;
            Stack<Tree> trees1;
            trees = new Queue<Tree>();
            trees1 = new Stack<Tree>();
            tree = new Tree(5, null);
            tree.Right = new Tree(10, tree);
            tree.Left = new Tree(15, tree);
            tree.Right.Left = new Tree(13, tree.Right);
            tree.Right.Right = new Tree(18, tree.Right);
            tree.Left.Left = new Tree(3, tree.Left);
            tree.Left.Right = new Tree(35, tree.Left);
            tree.Left.Right.Right = new Tree(351, tree.Left.Right);
            Methods.FirstType(tree);
            Console.WriteLine();
            trees1.Push(tree);
            Methods.FirstType1(trees1);
            Console.WriteLine();
            trees.Enqueue(tree);
            Methods.SecondType(trees); 

        }
        /*void FirstType(Tree tree)
        {
            Console.WriteLine(tree.Num.ToString());
            if (tree.Left != null)
                FirstType(tree.Left);
            if (tree.Right != null)
                FirstType(tree.Right);
        }*/
    }
}
