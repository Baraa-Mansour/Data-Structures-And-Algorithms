# Data Structures And Algorithms

This project is a C# practice workspace for learning and implementing fundamental data structures and algorithms. It includes working examples for graphs, heaps, priority queues, and trees.

> **Project status:** This project is still in progress. This README file and the implementations covered in the project will be updated as new features and examples are added.

## What this project is about

The project is designed to help train and improve skills in:

- Implementing generic data structures using C#
- Working with graphs and adjacency matrices
- Building heap and priority queue implementations
- Creating and traversing binary trees
- Implementing general tree structures
- Printing and exploring data structures in a console application
- Understanding common data structure operations and algorithms

## Level

This repository represents a practical course project for studying data structures and algorithms using C# and .NET 8.

## How to run

1. Open `Data Structures And Algorithms.sln` in Visual Studio or another compatible C# IDE.
2. Build the solution.
3. Run the project using `F5` or the IDE Run button.

You can also run the project from the terminal:

```powershell
dotnet run
```

`Program.cs` currently calls `TestPriorityQueue()` by default. Update the call inside `Main()` to run another test method, such as:

- `TestGeneralTree()`
- `TestBinaryTree()`
- `TestMatrixGraph()`
- `TestMinHeap()`
- `TestPriorityQueue()`

## Topics covered

### Graphs

- Directed and undirected graph types
- Adjacency matrix representation
- Adding and removing edges
- In-degree and out-degree calculations
- Edge existence checks
- Printing graph matrices

### Heaps

- Generic min-heap implementation
- Heap insertion
- Heapify up and heapify down operations
- Extracting the minimum element
- Peeking at the minimum element
- Printing heap elements

### Priority queue

- Priority queue node implementation
- Minimum-priority queue behavior
- Push, peek, and pop operations
- Priority queue built with a min-heap

### Trees

- General tree implementation
- Adding child nodes
- Finding values in a tree
- Printing a tree hierarchy
- Binary tree implementation
- Level-order insertion
- Pre-order, in-order, and post-order traversal
- Console-based tree printing

## Project structure

```text
Data Structures And Algorithms/
├── Graphs/
│   ├── Enums.cs
│   ├── ListGraph.cs
│   └── MatrixGraph.cs
├── Heaps/
│   ├── MaxHeap.cs
│   └── MinHeap.cs
├── Queues/
│   └── PriorityQueue.cs
├── Trees/
│   ├── BinaryTree.cs
│   └── GeneralTree.cs
├── Program.cs
├── Data Structures And Algorithms.csproj
└── Data Structures And Algorithms.sln
```

## Tech Stack

- C#
- .NET 8
- Console application
- Generic collections and classes
- Visual Studio solution files

## Purpose

The main goal of this project is to practice implementing and using fundamental data structures and algorithms. It provides small, reusable implementations and console demonstrations that strengthen understanding of tree, heap, graph, and priority queue behavior.

## Work in progress

Some implementations are intentionally unfinished or planned for future updates. For example:

- `ListGraph` is not implemented yet
- `MaxHeap` is not implemented yet

Additional data structures, algorithms, test examples, and documentation will be added and the existing README will be updated over time.
