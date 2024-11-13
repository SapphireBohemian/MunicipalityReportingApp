using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

// AVLTree.cs
namespace MunicipalityReportingApp
{
    public class AVLTreeNode
    {
        public ServiceRequest Request { get; set; }
        public AVLTreeNode Left { get; set; }
        public AVLTreeNode Right { get; set; }
        public int Height { get; set; }

        public AVLTreeNode(ServiceRequest request)
        {
            Request = request;
            Height = 1;
        }
    }

    public class AVLTree
    {
        private AVLTreeNode root;

        // Insert a new service request into the AVL Tree
        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private AVLTreeNode InsertRec(AVLTreeNode node, ServiceRequest request)
        {
            if (node == null)
                return new AVLTreeNode(request);

            if (string.Compare(request.Id, node.Request.Id) < 0)
                node.Left = InsertRec(node.Left, request);
            else if (string.Compare(request.Id, node.Request.Id) > 0)
                node.Right = InsertRec(node.Right, request);
            else
                return node; // Duplicate IDs are not allowed

            // Update the height of the ancestor node
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            // Balance the tree
            return Balance(node);
        }

        private AVLTreeNode Balance(AVLTreeNode node)
        {
            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && string.Compare(node.Left.Request.Id, node.Request.Id) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && string.Compare(node.Right.Request.Id, node.Request.Id) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && string.Compare(node.Left.Request.Id, node.Request.Id) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && string.Compare(node.Right.Request.Id, node.Request.Id) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node; // Return the (unchanged) node pointer
        }

        private int GetHeight(AVLTreeNode node)
        {
            return node == null ? 0 : node.Height;
        }

        private int GetBalance(AVLTreeNode node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }

        private AVLTreeNode RightRotate(AVLTreeNode y)
        {
            AVLTreeNode x = y.Left;
            AVLTreeNode T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            // Return the new root
            return x;
        }

        private AVLTreeNode LeftRotate(AVLTreeNode x)
        {
            AVLTreeNode y = x.Right;
            AVLTreeNode T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            // Return the new root
            return y;
        }
    }
}