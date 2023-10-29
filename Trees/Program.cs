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

        // Christian Walker Petersen 3.D

        // insertion sort
        static public void Insertionsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {

                int key = arr[i]; // gemmer værdien som insertionsort skal bytte rundt om
                int j = i - 1;

                // tjekker og bytter om på elemnterne i den sorteret del af arrayet
                // således at key står i den rigtige position
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    
                }
                arr[j + 1] = key;
            }
        }

        //Funktion til at udskirve array, bruger det 2 gange
        static void printArrayInt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
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
            printArrayInt(array);
            Insertionsort(array);
            Console.WriteLine("Det er sorteret");
            printArrayInt(array);
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
