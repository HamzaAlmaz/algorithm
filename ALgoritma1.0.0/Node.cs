using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALgoritma1._0._0
{
    internal class Node
    {
        public String data;
        public Node left;
        public Node right;

        public Node (string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
        public Node(String data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
