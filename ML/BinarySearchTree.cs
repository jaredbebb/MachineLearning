using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    class BinarySearchTree
    {
        public Node addNode(int key, Node head)
        {
            Node tempHead = head;
            Node n = new Node(key);
            if (head == null)
            {
                head = n;
                return head;
            }
            Node prev = null;
            while (head != null)
            {
                prev = head;
                if (head.getKey() < key)
                {
                    head = head.getRight();
                }
                else
                {
                    head = head.getLeft();
                }
            }
            if (prev.getKey() < key)
            {
                prev.setRight(n);
            }
            else
            {
                prev.setLeft(n);
            }
            return tempHead;
        }
    }
}
