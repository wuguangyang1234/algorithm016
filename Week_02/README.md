学习笔记
二叉树前序遍历（根———>左————>右）：
private void preorder(TreeNode root, List<Integer> list) {
    if(root == null) {
        return;
    }
    list.add(root.val);
    preorder(root.left, list);
    preorder(root.right, list);
}
二叉树中序遍历（左———>根————>右）
private void inorder(TreeNode root, List<Integer> list) {
    if(root == null) {
        return;
    }
    inorder(root.left, list);
    list.add(root.val);
    inorder(root.right, list);
}
二叉树后续遍历（左———>右————>根）
private void postorder(TreeNode root, List<Integer> list) {
    if(root == null) {
        return;
    }
    postorder(root.left, list);
    postorder(root.right, list);
    list.add(root.val);
}

堆：
有最大堆和最小堆，可以快速拿到最大或最小值