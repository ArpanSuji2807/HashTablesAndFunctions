using System;
using HashTablesAndFunctions;
class program
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(70);
        binarySearch.Insert(30);
        binarySearch.Insert(56);
        binarySearch.Insert(70);
        bool result = binarySearch.IfExists(70, binarySearch);
        binarySearch.Display();
    }
}
