using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{


    public class Node
    {
        Node parent;
        Node left;
        Node right;
        int key;
        public string label;
        public Node(int key)
        {
            parent = null;
            left = null;
            right = null;
            this.key = key;
        }

        public Node getParent()
        {
            return parent;
        }
        public void setParent(Node parent)
        {
            this.parent = parent;
        }
        public Node getLeft()
        {
            return left;
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        public void setLeft(Node left)
        {
            this.left = left;
        }
        public Node getRight()
        {
            return right;
        }
        public void setRight(Node right)
        {
            this.right = right;
        }
        public void setKey(int key)
        {
            this.key = key;
        }

        public int getKey()
        {
            return key;
        }

    }
}
