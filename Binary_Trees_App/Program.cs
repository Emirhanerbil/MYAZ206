using DataStructures.Trees.BinaryTree;

var bt = new BinaryTree<int>();

new int[] { 1, 2, 3, 4, 5, 6, 7 }
.ToList()
.ForEach(value => bt.Insert(value));



BinaryTree<int>.LevelOrderTraverse(bt.Root)
               .ForEach(node => Console.WriteLine(node));






