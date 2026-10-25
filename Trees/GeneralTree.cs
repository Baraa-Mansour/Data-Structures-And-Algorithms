namespace DSA.Trees
{
    public class GeneralNode<T>
    {
        public T Value { get; set; }
        public List<GeneralNode<T>> Children { get; set; }

        public GeneralNode(T value)
        {
            this.Value = value;
            Children = new List<GeneralNode<T>>();
        }

        public void AddChild(GeneralNode<T> node)
        {
            Children.Add(node);
        }
    }

    public class GeneralTree<T>
    {
        public GeneralNode<T> Root { get; private set; }

        public GeneralTree(T rootValue)
        {
            Root = new GeneralNode<T>(rootValue);
        }

        public bool Find(T value)
        {
            var found = Find(this.Root, value);

            return (found != null);
        }
        public GeneralNode<T>? Find(GeneralNode<T> node, T value)
        {
            if (EqualityComparer<T>.Default.Equals(node.Value, value))
                return node;

            foreach(var child in node.Children)
            {
                var found = Find(child, value);

                if (found != null) 
                    return found;
            }

            return null;
        }

        public void PrintTree()
        {
            PrintTree(this.Root, " ");
        }
        private void PrintTree(GeneralNode<T> root, string indet = " ")
        {
            Console.WriteLine($"{indet}{root.Value}");

            root.Children.ForEach(children =>
            {
                PrintTree(children, indet + " ");
            });
        }
    }
}
