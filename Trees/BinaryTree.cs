namespace DSA.Trees
{
    public class BinaryTreeNode<T>
    {
        public T Value { set; get; }
        public BinaryTreeNode<T>? Left {  set; get; }
        public BinaryTreeNode<T>? Right { set; get; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T>? Root { private set; get; }

        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Insert value using Level-order insertion strategy
        /// </summary>
        /// <param name="value">Value to insert</param>
        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if(Root == null)
            {
                Root = newNode;
                return;
            }
            
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();

                if(current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }

                if(current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        public void Print()
        {
            Print(Root, 0);
        }
        private void Print(BinaryTreeNode<T>? root, int space)
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if (root == null)
                return;


            space += COUNT;
            Print(root.Right, space); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value); // Print the current node after space


            Print(root.Left, space); // Recur on the left child
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }
        private void PreOrderTraversal(BinaryTreeNode<T>? node)
        {
            if(node == null) 
                return;

            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
        private void PostOrderTraversal(BinaryTreeNode<T>? node)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }
        private void InOrderTraversal(BinaryTreeNode<T>? node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }
}
