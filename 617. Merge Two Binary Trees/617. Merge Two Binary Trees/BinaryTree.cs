using System;
using System.Collections.Generic;
using System.Text;

namespace _617._Merge_Two_Binary_Trees
{
    class BinaryTree
    {
        private TreeNode _root;
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int nodeValue)
        {
            //if the tree is empty, return a new single node
            if(_root == null)
            {
                _root = new TreeNode(nodeValue);
                return;
            }
            // else start the tree
            InsertNode(_root, new TreeNode(nodeValue));
        }
        public void InsertNode(TreeNode root, TreeNode newNode)
        {
            if (root == null)
                root = newNode;

            if(newNode.val < root.val)
            {
                if (root.left == null)
                    root.left = newNode;
                else
                    InsertNode(root.left, newNode);
            }
            else
            {
                if (root.right == null)
                    root.right = newNode;
                else
                    InsertNode(root.right, newNode);
            }
        }

        public void DisplayTree(TreeNode root)
        {
            if (root == null) return;
            DisplayTree(root.left);
            Console.WriteLine(root.val + " ");
            DisplayTree(root.right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}
