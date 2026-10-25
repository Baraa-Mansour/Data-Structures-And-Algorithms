namespace DSA.Graphs
{
    public class MatrixGraph<T> where T : notnull
    {
        private readonly enGraphDirectionType _directionType;
        private readonly int[,] _adjacencyMatrix;
        private readonly Dictionary<T, int> _vertexDictionary;
        private readonly int _verticesCount;

        public MatrixGraph(List<T> vertices, 
            enGraphDirectionType graphDirectionType = enGraphDirectionType.Undirected)
        {
            _directionType = graphDirectionType;
            _adjacencyMatrix = new int[vertices.Count, vertices.Count];
            _vertexDictionary = new Dictionary<T, int>();
            _verticesCount = vertices.Count;

            for (int i = 0; i < vertices.Count; i++) 
                _vertexDictionary.Add(vertices[i], i);
        }

        public void AddEdge(T vertex1, T vertex2, int weight = 1)
        {
            if (!_vertexDictionary.TryGetValue(vertex1, out int vrtx1Index) || 
                !_vertexDictionary.TryGetValue(vertex2, out int vrtx2Index))
                return;

            _adjacencyMatrix[vrtx1Index, vrtx2Index] = weight;

            if(_directionType == enGraphDirectionType.Undirected)
                _adjacencyMatrix[vrtx2Index, vrtx1Index] = weight;
        }

        public void RemoveEdge(T src, T dst)
        {
            AddEdge(src, dst, 0);
        }

        public void Print()
        {
            // Print header
            Console.Write("  ");
            foreach (var vertex in _vertexDictionary.Keys)
                Console.Write(vertex + " ");
            Console.WriteLine();

            foreach (var index in _vertexDictionary)
            {
                Console.Write(index.Key + " ");

                for (int i = 0; i < _verticesCount; i++)
                    Console.Write(_adjacencyMatrix[index.Value, i] + " ");

                Console.WriteLine();
            }
        }

        public int GetInDegreeCount(T vertex)
        {
            if(!_vertexDictionary.TryGetValue(vertex, out int vrtxIndex))
                return 0;

            int counter = 0;
            for(int i = 0; i < _verticesCount; i++)
            {
                if (_adjacencyMatrix[i, vrtxIndex] > 0)
                    counter++;
            }

            return counter;
        }

        public int GetOutDegreeCount(T vertex)
        {
            if (!_vertexDictionary.TryGetValue(vertex, out int vrtxIndex))
                return 0;

            int counter = 0;
            for (int i = 0; i < _verticesCount; i++)
            {
                if (_adjacencyMatrix[vrtxIndex, i] > 0)
                    counter++;
            }

            return counter;
        }

        public bool IsEdge(T src, T dst)
        {
            if (!_vertexDictionary.TryGetValue(src, out int srcIndex) ||
                !_vertexDictionary.TryGetValue(dst, out int dstIndex))
                return false;

            return _adjacencyMatrix[srcIndex, dstIndex] > 0;
        }
    }
}
