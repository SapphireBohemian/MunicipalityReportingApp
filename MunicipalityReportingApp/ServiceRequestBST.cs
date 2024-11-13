using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ServiceRequestBST.cs
namespace MunicipalityReportingApp
{
    public class BSTNode
    {
        public ServiceRequest Request { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode(ServiceRequest request)
        {
            Request = request;
            Left = null;
            Right = null;
        }
    }

    public class ServiceRequestBST
    {
        private BSTNode root;

        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private BSTNode InsertRec(BSTNode root, ServiceRequest request)
        {
            if (root == null)
            {
                return new BSTNode(request);
            }

            if (string.Compare(request.Id, root.Request.Id) < 0)
            {
                root.Left = InsertRec(root.Left, request);
            }
            else
            {
                root.Right = InsertRec(root.Right, request);
            }
            return root;
        }

        public ServiceRequest Search(string requestID)
        {
            return SearchRec(root, requestID);
        }

        private ServiceRequest SearchRec(BSTNode root, string requestID)
        {
            if (root == null || root.Request.Id == requestID)
            {
                return root?.Request;
            }

            return string.Compare(requestID, root.Request.Id) < 0
                ? SearchRec(root.Left, requestID)
                : SearchRec(root.Right, requestID);
        }
    }
}
