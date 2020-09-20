using System;
using System.Collections.Generic;
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return new List<int>() { };
        IList<int> result = new List<int>();
        Stack<TreeNode> treeNodeStack = new Stack<TreeNode>();
        while (root != null)
        {
            if (root.left != null)
            {//此处判断当前是否还存在左子树，若存在，则继续查找其左子树，直至为空
                treeNodeStack.Push(root);
                root = root.left;
            }
            else
            {//左子树为空后将当前查询的节点的值添加到结果中，并设置下一个查询节点为当前节点的右子节点
                result.Add(root.val);
                root = root.right;
                if (root == null && treeNodeStack.Count > 0)
                {
                    root = treeNodeStack.Pop();
                    root.left = null;
                }
            }
        }
        return result;
    }
}
