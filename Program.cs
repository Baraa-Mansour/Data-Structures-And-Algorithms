using DSA.Graphs;
using DSA.Heaps;
using DSA.Trees;
using DSA.Queues;

namespace DSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestPriorityQueue();
        }


        static void TestGeneralTree()
        {
            var companyTree = new GeneralTree<string>("CEO");

            var finance = new GeneralNode<string>("CFO");
            var tech = new GeneralNode<string>("CTO");
            var marketing = new GeneralNode<string>("CMO");

            companyTree.Root.AddChild(finance);
            companyTree.Root.AddChild(tech);
            companyTree.Root.AddChild(marketing);

            var productManager = new GeneralNode<string>("PM");
            productManager.AddChild(new GeneralNode<string>("Developer"));
            productManager.AddChild(new GeneralNode<string>("UX Designer"));

            finance.AddChild(new GeneralNode<string>("Accountant"));
            tech.AddChild(productManager);
            marketing.AddChild(new GeneralNode<string>("Social Media Manager"));

            companyTree.PrintTree();

            Console.WriteLine($"Find PM: {companyTree.Find("PM")}");
            Console.WriteLine($"Find DBA: {companyTree.Find("DBA")}");
        }
        static void TestBinaryTree()
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);
            binaryTree.Insert(28);

            binaryTree.Print();
            Console.WriteLine();

            Console.Write("PreOrder traversal: ");
            binaryTree.PreOrderTraversal();

            Console.Write("PostOrder traversal: ");
            binaryTree.PostOrderTraversal();

            Console.Write("InOrder traversal: ");
            binaryTree.InOrderTraversal();
        }

        static void TestMatrixGraph()
        {
            // Create a list of vertices with string labels
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };


            // Create a new Undirected graph object with the specified vertices
            MatrixGraph<string> graph1 = new MatrixGraph<string>(vertices,
                enGraphDirectionType.Undirected);

            // Add some edges with default weights=1 between vertices
            graph1.AddEdge("A", "B", 1);
            graph1.AddEdge("A", "C", 1);
            graph1.AddEdge("B", "D", 1);
            graph1.AddEdge("C", "D", 1);
            graph1.AddEdge("B", "E", 1);
            graph1.AddEdge("D", "E", 1);

            // Display the adjacency matrix with weights to visualize the graph
            graph1.Print();

            Console.WriteLine("\n------------------------------\n");



            // Create a new graph object with the specified vertices
            MatrixGraph<string> graph2 = new MatrixGraph<string>(vertices, enGraphDirectionType.Directed);

            // Add some edges with weights between vertices
            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);

            // Display the adjacency matrix with weights to visualize the graph
            graph2.Print();


            // Get and display the Indegree (number of edges) of vertex 'D'
            Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegreeCount("D"));

            // Get and display the Outdegree (number of edges) of vertex 'D'
            Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegreeCount("D"));

            Console.WriteLine("\n------------------------------\n");



            // Create a new graph object with the specified vertices
            MatrixGraph<string> graph3 = new MatrixGraph<string>(vertices,
                enGraphDirectionType.Undirected);

            // Add some edges with weights between vertices
            graph3.AddEdge("A", "B", 5);
            graph3.AddEdge("A", "C", 3);
            graph3.AddEdge("B", "D", 12);
            graph3.AddEdge("C", "D", 10);
            graph3.AddEdge("B", "E", 2);
            graph3.AddEdge("D", "E", 7);

            // Display the adjacency matrix with weights to visualize the graph
            graph3.Print();


            // Check if there is an edge between 'A' and 'B' and display the result
            Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));


            // Check if there is an edge between 'A' and 'B' and display the result
            Console.WriteLine("\nIs there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));


            // Check if there is an edge between 'A' and 'A' and display the result
            Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

            // Check if there is an edge between 'A' and 'A' and display the result
            Console.WriteLine("\nIs there an edge between A and A in Graph3? " + graph3.IsEdge("A", "A"));


            // Get and display the Indegree (number of edges) of vertex 'A'
            Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInDegreeCount("A"));

            // Get and display the Indegree (number of edges) of vertex 'A'
            Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutDegreeCount("A"));

            Console.WriteLine("\n------------------------------\n");


            Console.WriteLine("\nRemoveing Edge between E and D:");
            // Remove the edge between 'E' and 'D'
            graph3.RemoveEdge("E", "D");

            // Display the updated adjacency matrix after removing the edge
            graph3.Print();


            // Check if there is an edge between 'A' and 'A' and display the result
            Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));
        }

        static void TestMinHeap()
        {
            MinHeap<int> minHeap = new MinHeap<int>();

            Console.WriteLine("Inserting elements into the Min-Heap...\n");
            minHeap.Insert(10);
            minHeap.Insert(4);
            minHeap.Insert(15);
            minHeap.Insert(2);
            minHeap.Insert(8);

            // Display the heap after insertion
            minHeap.Print();

            Console.WriteLine("\nPeek Minimum Element: Minimum Element is: " + minHeap.Peek());

            // Display the heap after insertion, note that the minimum value is not deleted.
            minHeap.Print();

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Min-Heap:");
            Console.WriteLine("Extracted Minimum: " + minHeap.Extract());
            minHeap.Print();

            Console.WriteLine("\nExtracted Minimum: " + minHeap.Extract());
            minHeap.Print();

        }

        static void TestPriorityQueue()
        {
            PriorityQueue<string> pq = new PriorityQueue<string>();

            Console.WriteLine("Inserting elements into the Priority Queue...\n");

            Console.WriteLine("Inserting (Task 1, 5)");
            Console.WriteLine("Inserting (Task 2, 3)");
            Console.WriteLine("Inserting (Task 3, 4)");
            Console.WriteLine("Inserting (Task 4, 1)");
            Console.WriteLine("Inserting (Task 5, 2)");

            pq.Push("Task 1", 5);
            pq.Push("Task 2", 3);
            pq.Push("Task 3", 4);
            pq.Push("Task 4", 1);
            pq.Push("Task 5", 2);

            // Peek the minimum priority element
            Console.WriteLine("\nPeek Minimum Priority Element: Name = " + pq.Peek().Value +
                ", Priority = " + pq.Peek().Priority);

            // Extract elements based on priority
            Console.WriteLine("\nExtracting elements from the Priority Queue:");
            var extractedNode = pq.Pop();
            Console.WriteLine("\nExtracted Element: Name = " + extractedNode.Value +
                ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Pop();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Value +
                ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Pop();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Value +
                ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Pop();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Value +
                ", Priority = " + extractedNode.Priority);

            extractedNode = pq.Pop();
            Console.WriteLine("Extracted Element: Name = " + extractedNode.Value +
                ", Priority = " + extractedNode.Priority);


        }
    }
}
