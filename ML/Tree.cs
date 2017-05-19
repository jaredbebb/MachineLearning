using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Tree
    {
        Node root;

        public Tree(Node root)
        {
            this.root = root;

        }

        public Node TreeSearch(Node x,int k)
        {
            if((x==null) | (k == x.getKey()))
            {
                return x;
            }
            if(k < x.getKey())
            {
                return TreeSearch(x.getLeft(), k);
            }
            else
            {
                return TreeSearch(x.getRight(), k);
            }
        }

        public Node IterativeTreeSearch(Node x, int k)
        {
            while ((x != null)&& (k !=x.getKey()))
            {
                if (k < x.getKey())
                {
                    x = x.getLeft();
                }
                else
                {
                    x = x.getRight();
                }
            }
            return x;
        }
        public Node TreeMinimum(Node x)
        {
            while (x.getLeft() != null)
            {
                x = x.getLeft();
            }
            return x;
        }

    }
}
