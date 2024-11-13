using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RedBlackTree.cs

namespace MunicipalityReportingApp
{
    public enum Color { Red, Black }

    public class RedBlackTreeNode
    {
        public ServiceRequest Request { get; set; }
        public Color Color { get; set; }
        public RedBlackTreeNode Left { get; set; }
        public RedBlackTreeNode Right { get; set; }
        public RedBlackTreeNode Parent { get; set; }

        public RedBlackTreeNode(ServiceRequest request)
        {
            Request = request;
            Color = Color.Red; // New nodes are red by default
            Left = Right = Parent = null;
        }
    }

    public class RedBlackTree
    {
        private RedBlackTreeNode root;

        public void Insert(ServiceRequest request)
        {
            RedBlackTreeNode newNode = new RedBlackTreeNode(request);
            root = BSTInsert(root, newNode);
            FixViolations(newNode);
        }

        private RedBlackTreeNode BSTInsert(RedBlackTreeNode root, RedBlackTreeNode newNode)
        {
            if (root == null)
                return newNode;

            if (string.Compare(newNode.Request.Id, root.Request.Id) < 0)
            {
                root.Left = BSTInsert(root.Left, newNode);
                root.Left.Parent = root;
            }
            else if (string.Compare(newNode.Request.Id, root.Request.Id) > 0)
            {
                root.Right = BSTInsert(root.Right, newNode);
                root.Right.Parent = root;
            }

            return root;
        }

        private void FixViolations(RedBlackTreeNode node)
        {
            RedBlackTreeNode parent = null;
            RedBlackTreeNode grandparent = null;

            while (node != root && node.Color == Color.Red && node.Parent.Color == Color.Red)
            {
                parent = node.Parent;
                grandparent = parent.Parent;

                // Case A: Parent is a left child
                if (parent == grandparent.Left)
                {
                    RedBlackTreeNode uncle = grandparent.Right;

                    // Case 1: Uncle is red
                    if (uncle != null && uncle.Color == Color.Red)
                    {
                        grandparent.Color = Color.Red;
                        parent.Color = Color.Black;
                        uncle.Color = Color.Black;
                        node = grandparent;
                    }
                    else
                    {
                        // Case 2: Node is a right child
                        if (node == parent.Right)
                        {
                            RotateLeft(parent);
                            node = parent;
                            parent = node.Parent;
                        }

                        // Case 3: Node is a left child
                        RotateRight(grandparent);
                        Color temp = parent.Color;
                        parent.Color = grandparent.Color;
                        grandparent.Color = temp;
                        node = parent;
                    }
                }
                else
                {
                    RedBlackTreeNode uncle = grandparent.Left;

                    // Case 1: Uncle is red
                    if (uncle != null && uncle.Color == Color.Red)
                    {
                        grandparent.Color = Color.Red;
                        parent.Color = Color.Black;
                        uncle.Color = Color.Black;
                        node = grandparent;
                    }
                    else
                    {
                        // Case 2: Node is a left child
                        if (node == parent.Left)
                        {
                            RotateRight(parent);
                            node = parent;
                            parent = node.Parent;
                        }

                        // Case 3: Node is a right child
                        RotateLeft(grandparent);
                        Color temp = parent.Color;
                        parent.Color = grandparent.Color;
                        grandparent.Color = temp;
                        node = parent;
                    }
                }
            }

            root.Color = Color.Black; // Ensure the root is always black
        }

        private void RotateLeft(RedBlackTreeNode node)
        {
            RedBlackTreeNode rightChild = node.Right;
            node.Right = rightChild.Left;

            if (node.Right != null)
                node.Right.Parent = node;

            rightChild.Parent = node.Parent;

            if (node.Parent == null)
                root = rightChild; // Node was root
            else if (node == node.Parent.Left)
                node.Parent.Left = rightChild;
            else
                node.Parent.Right = rightChild;

            rightChild.Left = node;
            node.Parent = rightChild;
        }

        private void RotateRight(RedBlackTreeNode node)
        {
            RedBlackTreeNode leftChild = node.Left;
            node.Left = leftChild.Right;

            if (node.Left != null)
                node.Left.Parent = node;

            leftChild.Parent = node.Parent;

            if (node.Parent == null)
                root = leftChild; // Node was root
            else if (node == node.Parent.Right)
                node.Parent.Right = leftChild;
            else
                node.Parent.Left = leftChild;

            leftChild.Right = node;
            node.Parent = leftChild;
        }
    }
}