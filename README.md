This repository has the objective of presenting examples of data structure, search algorithms, sorting algorithms, and their respective complexities in the worst case. 

To apply the concepts of the topics above, I created a project called "problems", in this project I solve problems of the [leetcode](https://leetcode.com/) platform. The explanation of each problem is in the solution itself. You can find them by accessing the root of the solution and `/src/problems`

For most of the code I also developed the unit tests, you can find them by accessing the root of the solution and `/test`.

This repository is under construction so some algorithms mentioned in the tables may be missing from the solution


## Data Structures

For data structure, we only look at worst-case time complexity.

| Data Structures                                                                                                                                                 | Insertion | Remove       | Search | Access |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------- | ------------ | ------ | ------ |
| [Array](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/Array/SimpleArray.cs)                                         | O(n)      | O(n)         | O(n)   | O(1)   |
| [Doubly-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/List/DoublyLinkedList/DoublyLinkedList.cs)       | O(1)      | O(1) or O(n) | O(n)   | O(n)   |
| [Circular-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/List/CircularLinkedList/CircularLinkedList.cs) | O(1)      | O(1) or O(n) | O(n)   | O(n)   |
| [Singly-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/List/SinglyLinkedList/SinglyLinkedList.cs) | O(n)      | O(n) | O(n)   | O(n)   |
| [Hash Map](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/HashMap/HashMap.cs) | O(n)      | O(n) | O(n)   | O(n)   |
| [Min Heap](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/Heap/MinHeap/MinHeap.cs)  |      O(log(n))     |      O(log(n))        |    O(n)    |        |
| [AVL](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/Tree/AVL/AVL.cs) | O(log(n))      | O(log(n)) | O(log(n))   |    |
| [Binary Search Tree](https://github.com/HenrySaldanha/algorithms/blob/main/src/DataStructure/Tree/BinarySearchTree/BinarySearchTree.cs) | O(n)      | O(n) | O(n)   |    |

## Sorting Algorithms

| Algorithm      | Best | Average | Wrost | 
| -------------- | ---- | ------- | ----- |
| [Quick Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/QuickSort/QuickSort.cs)     |   O(n*log(n))    |    O(n*log(n))     |    O(n^2)   | 
| [Mergesort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/MergeSort/MergeSort.cs)     |   O(n*log(n))    |    O(n*log(n))     |    O(n*log(n))   | 
| [Heapsort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/HeapSort/HeapSort.cs)      |  O(n*log(n))    |   O(n*log(n))      |   O(n*log(n))    |       |
| [Bubble Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/BubbleSort/BubbleSort.cs) | O(n)      | O(n^2) | O(n^2)   |
| [Insertion Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/InsertionSort/InsertionSort.cs) |  O(n)    |   O(n^2)      |    O(n^2)    |  
| [Selection Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/SelectionSort/SelectionSort.cs) | O(n^2)   |   O(n^2)      |    O(n^2)    |  
| [Radix Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/RadixSort/RadixSort.cs) | O(n+k)   |   O(n+k)      |    O(n+k)    |  
| [Counting Sort](https://github.com/HenrySaldanha/algorithms/blob/main/src/Sorting/CountingSort/CountingSort.cs) | O(n+k)   |   O(n+k)      |    O(n+k)    |  

## Search Algorithms

| Algorithm            | Best | Average | Wrost |
| -------------------- | ---- | ------- | ----- |
| [Linear(Array)](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/Linear/Linear.cs)      |   O(1)   |    O(n)     |   O(n)    |
| [Binary Search](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/BinarySearch/BinarySearch.cs)        |    O(1)  |    O(Log(n))     |    O(Log(n))    |
| [Binary Search Tree](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/BinarySearchTree/BinarySearchTree.cs)  |   O(log(n))   |    O(n)     |   O(n)      |
| [Breadth-First Search](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/BreadthFirstSearch/BreadthFirstSearch.cs) |    |     O(V+E)     |      |
| [Depth-First Search](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/DepthFirstSearch/DepthFirstSearch.cs)   |        |     O(V+E)     |      |
| [A*](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/AStar/AStarAlgorithm.cs)                   |      |     O(E)     |       |
| Predictive Search    |      |         |       |
| [Interpolation Search](https://github.com/HenrySaldanha/AlgorithmsAndDataStructure/blob/main/src/Search/InterpolationSearch/InterpolationSearch.cs) |   O(log(log(n))   |    O(log(log(n))     | O(n) |
| [Fibonacci Search](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/FibonacciSearch/FibonacciSearch.cs)      |   O(1)   |    O(log(n))     |   O(log(n))    |
| Kruskal's Algorithm  |      |         |       |
| [Prim's Algorithm](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/Prim/PrimAlgorithm.cs)   |    O(v^2)    |    O(v^2)     |   O(v^2)    |
| [Dijkstra's Algorithm](https://github.com/HenrySaldanha/algorithms/blob/main/src/Search/Dijkstra/DijkstraAlgorithm.cs)   |    O(v^2)    |    O(v^2)     |   O(v^2)    |


## This project was built with
* [xUnit](https://xunit.net/)
* [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* ~~coffee, pizza and late nights~~

## My contacts
* [LinkedIn](https://www.linkedin.com/in/henry-saldanha-3b930b98/)
* [LeetCode](https://leetcode.com/user5265z/)