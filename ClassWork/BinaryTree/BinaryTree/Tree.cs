using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        public int Num { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public Tree Parent { get; set; }
        public Tree(int num, Tree parent)
        {
            Num = num;
            Parent = parent;
        }


    }
}
