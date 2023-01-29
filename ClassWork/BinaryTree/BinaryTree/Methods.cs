using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    static class Methods
    {
        public static void FirstType(Tree tree)
        {
            Console.Write(tree.Num.ToString() + " ");
            if (tree.Left != null)
                FirstType(tree.Left);
            if (tree.Right != null)
                FirstType(tree.Right);
        }
        
        public static void FirstType1(Stack<Tree> trees)
        {
            Tree tree = trees.Pop();
            Console.Write(tree.Num.ToString() + " ");            
            if (tree.Right != null)
                trees.Push(tree.Right);
            if (tree.Left != null)
                trees.Push(tree.Left);
            if (trees.Count > 0)
                FirstType1(trees);
        }
        public static void SecondType(Queue<Tree> trees)
        {
            Tree tree = trees.Dequeue();
            Console.Write(tree.Num.ToString() + " ");
            if (tree.Left != null)
                trees.Enqueue(tree.Left);
            if (tree.Right != null)
                trees.Enqueue(tree.Right);
            if (trees.Count > 0)
                SecondType(trees);
        }
    }
}
