This repository has the objective of presenting examples of: data structure, search algorithms, sorting algorithms and their respective complexities in the worst case.

## Data Structures

For data structure, we only look at worst-case time complexity.

| Data Structures                                                                                                                                                 | Insertion | Remove       | Search | Access |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------- | ------------ | ------ | ------ |
| [Array](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/DataStructure/Array/SimpleArray.cs)                                         | O(n)      | O(n)         | O(n)   | O(1)   |
| [Doubly-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/DataStructure/List/DoublyLinkedList/DoublyLinkedList.cs)       | O(1)      | O(1) or O(n) | O(n)   | O(n)   |
| [Circular-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/DataStructure/List/CircularLinkedList/CircularLinkedList.cs) | O(1)      | O(1) or O(n) | O(n)   | O(n)   |
| [Singly-Linked List](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/DataStructure/List/SinglyLinkedList/SinglyLinkedList.cs) | O(n)      | O(n) | O(n)   | O(n)   |
[Hash Map](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/DataStructure/HashMap/HashMap.cs) | O(n)      | O(n) | O(n)   | O(n)   |
| Max Heap   |           |              |        |        |
| Min Heap   |           |              |        |        |
| AVL        |           |              |        |        |
| Binary Search Tree |           |              |        |        |
| B-Tree   |           |              |        |        |
| B+ Tree  |           |              |        |        |
| Red-Black Tree |           |              |        |        |
| 2-3 Tree  |           |              |        |        |

## Sorting Algorithms

| Algorithm      | Best | Average | Wrost | 
| -------------- | ---- | ------- | ----- |
| [Quick Sort](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Sorting/QuickSort/QuickSort.cs)     |   O(n*log(n))    |    O(n*log(n))     |    O(n^2)   | 
| [Mergesort](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Sorting/MergeSort/MergeSort.cs)     |   O(n*log(n))    |    O(n*log(n))     |    O(n*log(n))   | 
| Heapsort       |      |         |       |       |
| [Bubble Sort](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Sorting/BubbleSort/BubbleSort.cs) | O(n)      | O(n^2) | O(n^2)   |
| [Insertion Sort](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Sorting/InsertionSort/InsertionSort.cs) |  O(n)    |   O(n^2)      |    O(n^2)    |  
| [Selection Sort](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Sorting/InsertionSort/SelectionSort.cs) | O(n^2)   |   O(n^2)      |    O(n^2)    |  
| Radix sort     |      |         |       | 

## Search Algorithms

| Algorithm            | Best | Average | Wrost |
| -------------------- | ---- | ------- | ----- |
| [Linear(Array)](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Search/Linear/Linear.cs)      |   O(1)   |    O(n)     |   O(n)    |
| [Binary Search](https://github.com/HenrySaldanha/algorithms/blob/main/Algorithms/src/Search/BinarySearch/BinarySearch.cs)        |    O(1)  |    O(Log(n))     |    O(Log(n))    |
| Binary Tree Search   |      |         |       |
| Breadth-First Search |      |         |       |
| Depth-First Search   |      |         |       |
| A*                   |      |         |       |
| Hash search          |      |         |       |
| Predictive Search    |      |         |       |
| Interpolation Search |      |         |
| Fibonacci Search     |      |         |       |
| Kruskal's Algorithm  |      |         |       |
| Prim's Algorithm     |      |         |       |
| Dijkstra's Algorithm |      |         |       |
