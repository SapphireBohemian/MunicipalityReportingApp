using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReportingApp
{
    public class TreeNode
    {
        public ServiceRequest Request { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(ServiceRequest request)
        {
            Request = request;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        private TreeNode root;

        // Insert a new service request into the BST
        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private TreeNode InsertRec(TreeNode root, ServiceRequest request)
        {
            if (root == null)
            {
                root = new TreeNode(request);
                return root;
            }

            if (string.Compare(request.Id, root.Request.Id) < 0)
                root.Left = InsertRec(root.Left, request);
            else if (string.Compare(request.Id, root.Request.Id) > 0)
                root.Right = InsertRec(root.Right, request);

            return root;
        }

        // Search for a service request by ID
        public ServiceRequest Search(string id)
        {
            return SearchRec(root, id);
        }

        private ServiceRequest SearchRec(TreeNode root, string id)
        {
            if (root == null || root.Request.Id == id)
                return root?.Request;

            if (string.Compare(id, root.Request.Id) < 0)
                return SearchRec(root.Left, id);

            return SearchRec(root.Right, id);
        }
    }
}
