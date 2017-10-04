using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Misc
{
    public class BinaryTree
    {
        public Node root {get; set; }

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(int val)
        {
            root = new Node(val);
        }

        public int depth()
        {
            if (root == null)
            {
                return 0;
            }
            return root.depth();
        }

        public bool insert(Node n)
        {
            if (root == null)
            {
                root = n;
                return true;
            }
            else { 
                return root.insert(n);
            }
        }

        public bool insert(int i)
        {
            return insert(new Node(i));
        }

        public string navigationPath(int i)
        {
            return navigationPath(new Node(i));
        }

        public string sortedTree()
        {
            if(root == null) {
                return "Empty";
            }
            else
            {
                return root.sortedTree();
            }
        }

        public string navigationPath(Node n)
        {
            if (root == null)
            {
                return "Not Found";
            }
            else if (root.value == n.value)
            {
                return "(root)";
            }
            else
            {
                return root.navigationPath(n);
            }
        }

        public string treeLevels()
        {
            Queue<Node> currentLevel = new Queue<Node>();
            Queue<Node> nextLevel = new Queue<Node>();

            nextLevel.Enqueue(root);

            string retValue = "";

            do
            {
                while (nextLevel.Count > 0)
                {
                    Node n = nextLevel.Dequeue();
                    retValue += n.value + " ";
                    currentLevel.Enqueue(n);
                }
                retValue += " \r\n ";

                while (currentLevel.Count > 0)
                {
                    Node c = currentLevel.Dequeue();
                    if (c.left != null)
                    {
                        nextLevel.Enqueue(c.left);
                    }
                    if (c.right != null)
                    {
                        nextLevel.Enqueue(c.right);
                    }
                }
            }
            while (nextLevel.Count > 0);

            return retValue;
        }
    }

    public class Node : Object
    {
        public Node(int val) {
            this.value = val;
        }
        public int value { get; set; }
        public Node parent;
        public Node left;
        public Node right;

        private string NotFound = "Not Found";

        public int depth()
        {
            if (left == null && right == null)
            {
                return 1;
            }
            else if (left == null)
            {
                return 1 + right.depth();
            }
            else if (right == null)
            {
                return 1 + left.depth();
            }
            else
            {
                int depthLeft = left.depth();
                int depthRight = right.depth();
                return 1 + (depthLeft > depthRight ? depthLeft : depthRight);
            }
        }

        public bool insert(int i) {
            return insert(new Node(i));
        }

        public bool insert(Node n) 
        {
            if (n.value < this.value)
            {
                if (this.left == null)
                {
                    this.left = n;
                    return true;
                }
                else
                {
                    return this.left.insert(n);
                }
            }
            else if(n.value > this.value)
            {
                if(this.right == null)
                {
                    this.right = n;
                    return true;
                }
                else
                {
                    return this.right.insert(n);
                }
            }
            else if (n.value == this.value)
            {
                return false;
            }
            else
            {
                throw new InvalidCastException("Invalid value used in comparison");
            }
            return false;
        }

        public string navigationPath(int i)
        {
            return navigationPath(new Node(i));
        }

        public string navigationPath(Node n)
        {
            if (this.value == n.value)
            {
                return "";
            }
            else if (n.value < this.value)
            {
                if (this.left == null)
                {
                    return NotFound;
                }
                else
                {
                    string leftpath = this.left.navigationPath(n);
                    if (leftpath == NotFound)
                    {
                        return leftpath;
                    }
                    else
                    {
                        return "l" + leftpath;
                    }
                }
            }
            else if (n.value > this.value)
            {
                if (this.right == null)
                {
                    return NotFound;
                }
                else
                {
                    string rightpath = this.right.navigationPath(n);
                    if (rightpath == NotFound)
                    {
                        return rightpath;
                    }
                    else
                    {
                        return "r" + rightpath;
                    }
                }
            }
            else
            {
                return NotFound;
            }
        }

        public string sortedTree()
        {
            string valueString = this.value.ToString() + " ";
            if (this.left == null && this.right == null)
            {
                return valueString;
            }
            else if (this.right == null) 
            {
                return this.left.sortedTree() + valueString;
            }
            else if (this.left == null)
            {
                return valueString + this.right.sortedTree();
            }
            else
            {
                return this.left.sortedTree() + valueString + this.right.sortedTree();
            }
        }

    }
 
}
