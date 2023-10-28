using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace D3BinarySearchTreeExample
{
    internal class Program
    {
        // Function to sort array
        // using insertion sort
        static public void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                // Move elements of arr[0..i-1],
                // that are less than key,
                // to one position ahead of
                // their current position (omvendt rækkefølge)
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    
                }
                arr[j + 1] = key;
            }
        }

        // Det her er lidt lort
        // kunne godt bare være en funktion og så bare både håndtere int og string men kunne ikke lige holde til presset
        static void printArrayInt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        static void printArrayString(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i]);

            Console.Write("\n");
        }


        public static void QuickSort(string[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        public static int Partition(string[] array, int low, int high)
        {
            string pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (string.Compare(array[j], pivot) < 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        public static void Swap(string[] arr, int index1, int index2)
        {
            string temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();

            int[] nodeValues = { 5, 2, 1, 4, 8, 6, 9 };

            for (int i = 0; i < nodeValues.Length; i++)
            {
                tree.AddValue(nodeValues[i]);
            }
            int maximum = nodeValues.Max();
            Console.WriteLine("Tree populated successfully, will now search for element: " + maximum);
            Console.ReadKey();

            postOrderSearch(tree.Root, maximum);


            int[] array = { 4, 8, 6, 2, 3, 9, 7, 5 };
            sort(array);
            Console.WriteLine("Det er sorteret");
            printArrayInt(array);
            Console.ReadKey();


            string[] listFile = File.ReadAllLines("..\\arter.txt");
            printArrayString(listFile);
            Console.ReadKey();
            Console.WriteLine("Sorteret");
            QuickSort(listFile, 0, listFile.Length-1);
            printArrayString(listFile);
            Console.ReadKey();

        }

        private static void postOrderSearch(Node node, int number)
        {
            if (node == null) 
            { 
                return; 
            }

            // Visit left child
            postOrderSearch(node.left, number);

            // Visit right child
            postOrderSearch(node.right, number);

            // Process the current Value
            if (node.nodeValue == number) 
            {
                Console.WriteLine("You found the number you were searching for: " + node.nodeValue);
                return;
            }
            else
            {
                Console.WriteLine("the number " + node.nodeValue + " is not the number you are searching for: " + number);
            }
        }   
    }
}
