using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3BinarySearchTreeExample
{
    public class Node
    {
        // each node contains a data value, in this instance it called nodeValue
        // each node contains a reference to other nodes via the left and right notation
        // notice a node have either 0, 1 or 2 'children', so either a Node consist of no references (both left and right contains null)
        // 1 reference = 1 child, which means one either left or right contains another node, while the other left or right conatins null.
        // Or 2 references, both left and right contains Nodes. 
        public int nodeValue { get; set; }
        public Node left { get; set; } = null;
        public Node right { get; set; } = null;

        public Node(int value) => nodeValue = value;

        // This method adds new nodes added to the tree using recursive function calls!
        public void AddChildNode(int newValue)
        {
            if (newValue.CompareTo(nodeValue) < 0)
            {
                if (left == null)
                {
                    left = new Node(newValue);
                }
                else
                {
                    // AddChildNode is now a recursive method, which means the method calls itself inside the method!
                    left.AddChildNode(newValue);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(newValue);
                }
                else
                {
                    right.AddChildNode(newValue);
                }
            }
        }
    }
}
