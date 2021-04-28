using System;

namespace _617._Merge_Two_Binary_Trees
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree();
            TreeNode root1 = new TreeNode();
            tree1.Insert(1);
            tree1.Insert(3);
            tree1.Insert(2);
            tree1.Insert(5);

            BinaryTree tree2 = new BinaryTree();
            TreeNode root2 = new TreeNode();
            tree1.Insert(2);
            tree1.Insert(1);
            tree1.Insert(3);
            tree1.Insert(7);
            tree1.Insert(1);
            tree1.Insert(3);

            MergeTrees(tree1, tree2);


        }

        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            // if both of the head/roots are null then return null ...
            if (root1 == null && root2 == null)
            {
                return null;
            }
            TreeNode twoTreesMerged = new TreeNode(0);
            if(root1 == null && root2 != null)
            {
                twoTreesMerged.val = root2.val;
                twoTreesMerged.left = MergeTrees(root2.left, null);
                twoTreesMerged.right = MergeTrees(null, root2.right);
            }
            else if(root1 != null && root2 == null)
            {
                twoTreesMerged.val = root1.val;
                twoTreesMerged.left = MergeTrees(root1.left, null);
                twoTreesMerged.left = MergeTrees(null, root1.right);
            }
            else
            {
                twoTreesMerged.left = MergeTrees(root1.left, root2.left);
                twoTreesMerged.right = MergeTrees(root1.right, root2.right);
                twoTreesMerged.val = root1.val + root2.val;
            }
            return twoTreesMerged;

        }
    }

}
