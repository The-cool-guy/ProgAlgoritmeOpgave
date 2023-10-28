using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3BinarySearchTreeExample
{
    public class BinaryTree
    {
        public Node Root { get; set; } = null;

        public void AddValue(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Root.AddChildNode(value);
            }
        }
    }
}
