namespace DataStructures
{
    public class BinaryTree<T>
    {
        public TreeNode Root;

        public void Add(T value)
        {
            if (Root == null)
                Root = new TreeNode(value);
            else
            {
                
            }
        }


        public class TreeNode
        {
            public TreeNode(T value)
            {
                parent = leftChild = rightChild = null;
                this.value = value;
            }

            public TreeNode parent, leftChild, rightChild;
            public T value;
        }
    }
}