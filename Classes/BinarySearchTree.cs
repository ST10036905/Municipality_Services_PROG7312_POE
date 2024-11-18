using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mayra Selemane
// ST10036905
// PROG7312 POE PART
// Class used to manipulate binary search trees

namespace Municipality_Services_PROG7321_POE.Classes
{
    public class BinarySearchTree
    {
        public class TreeNode
        {
            public ReportData Data; // Data stored in this node (of type ReportData)
            public TreeNode Left;   // Left child of the node
            public TreeNode Right;  // Right child of the node

            public TreeNode(ReportData data)
            {
                Data = data;  // Set the node's data
                Left = null;   // Initialize Left child as null
                Right = null;  // Initialize Right child as null
            }
        }

        private TreeNode root; // Root node of the binary search tree

        public BinarySearchTree()
        {
            root = null;  // Initially, the tree is empty
        }

        /// <summary>
        /// Inserts a new report data into the tree based on its RequestID.
        /// </summary>
        /// <param name="data">The ReportData object to be inserted into the tree.</param>
        public void Insert(ReportData data)
        {
            root = InsertRec(root, data);  // Call the recursive insert method
        }

        /// <summary>
        /// Recursive method to insert a report data into the tree.
        /// </summary>
        /// <param name="root">The current node in the binary search tree.</param>
        /// <param name="data">The ReportData object to be inserted.</param>
        /// <returns>The root of the modified subtree.</returns>
        private TreeNode InsertRec(TreeNode root, ReportData data)
        {
            if (root == null)
            {
                root = new TreeNode(data);  // Create a new node if root is null
                return root;  // Return the new node
            }

            // Compare the RequestID of the current node with the new data's RequestID
            if (string.Compare(data.RequestID, root.Data.RequestID) < 0)
                root.Left = InsertRec(root.Left, data);  // Insert into the left subtree
            else if (string.Compare(data.RequestID, root.Data.RequestID) > 0)
                root.Right = InsertRec(root.Right, data);  // Insert into the right subtree

            return root;  
        }

        /// <summary>
        /// Searches for a report by its RequestID in the tree.
        /// </summary>
        /// <param name="requestId">The RequestID to search for.</param>
        /// <returns>The ReportData object associated with the given RequestID, or null if not found.</returns>
        public ReportData Search(string requestId)
        {
            return SearchRec(root, requestId);  
        }

        /// <summary>
        /// Recursive method to search for a report by its RequestID.
        /// </summary>
        /// <param name="root">The current node in the binary search tree.</param>
        /// <param name="requestId">The RequestID to search for.</param>
        /// <returns>The ReportData object if found, or null if not found.</returns>
        private ReportData SearchRec(TreeNode root, string requestId)
        {
            if (root == null || root.Data.RequestID == requestId)
                return root?.Data;  

            // Recursively search left or right based on the comparison of RequestIDs
            if (string.Compare(requestId, root.Data.RequestID) < 0)
                return SearchRec(root.Left, requestId);  

            return SearchRec(root.Right, requestId);  
        }

        /// <summary>
        /// Performs an inorder traversal of the tree to get all reports sorted by RequestID.
        /// </summary>
        /// <returns>A list of ReportData objects in sorted order.</returns>
        public List<ReportData> InOrderTraversal()
        {
            var result = new List<ReportData>();  
            InOrderRec(root, result);  
            return result;  
        }

        /// <summary>
        /// Recursive method for inorder traversal of the tree.
        /// </summary>
        /// <param name="root">The current node in the binary search tree.</param>
        /// <param name="result">The list to store the sorted report data.</param>
        private void InOrderRec(TreeNode root, List<ReportData> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);  
                result.Add(root.Data);  
                InOrderRec(root.Right, result); 
            }
        }

    }//________________________________________________________End of File___________________________________________________________________________________
}//___________________________________________________________________________________________________________________________________________________________
