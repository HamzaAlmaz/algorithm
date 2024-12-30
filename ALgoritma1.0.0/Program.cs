using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ALgoritma1._0._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fibonachi(int.Parse(Console.ReadLine()));

            //Faktorial(int.Parse(Console.ReadLine()));

            //Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));

            int[] numbers = { 5, 2, 8, 1, 9, 11, 15, 12, 26, 25, 4, 3, };
            //Console.WriteLine(maxİnArray(numbers));
            //Console.WriteLine(minİnArray(numbers));

            //int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            //Console.WriteLine(binarySearch(numbers, 22));


            //int[] array = { 100, 50, 75, 25, 125, 10, 150, 80, 110, 60 };
            //QuickSort(array, 0, array.Length-1);
            //Console.Write(string.Join(", ", array));

            //Node tree = creatTree();

            //Console.Write("BFS-->");
            //BFS(tree);

            //Console.WriteLine();
            //Console.Write("DFS-->");
            //DFS(tree);

            //selectionSort(numbers);
            //int[] numbers2 = { 8, 98, 7, 9 };
            //numbers2 = numbers;
            //numbers[0] = 1414141;

            //Console.Write(string.Join(",", numbers2));
            //int[,] matrix1 = {{ 2, 4, 5, 6, 7, 8, 9,},
            //                 { 5, 6, 7, 8, 9, 10, 11,},
            //                 { 8, 9, 10, 11, 12, 13, 15,},
            //                 { 9, 11, 12,13, 14, 15, 26,} };
            //int[,] matrix2 = {{ 25, 26, 27, 51, 6, 3, 3 },
            //                  { 6, 5, 32, 55, 22, 31, 6,},
            //                  { 22, 62, 6, 3, 1, 5, 6 },
            //                  { 2, 5, 8, 2, 7, 91, 5 },
            //                  { 18, 19, 1, 3, 5, 3, 8} };
            //GrapFilter(matrix1, matrix2);
           
            Console.Read();

        }
        
        private static void GrapFilter(int[,] matrix1, int[,] matrix2)
        {
            float result = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    result = result + Math.Abs(matrix1[i, j] - matrix2[i, j]);

                }
            }
            result = result / 2;
            Console.WriteLine(result);
        }

        public static void DFS (Node node)
        {
            if(node==null) return;
            Console.Write(node.data + ",");
            DFS(node.left);
            DFS(node.right);
        }
        public static void BFS(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count != 0)
            {
                node = q.Dequeue();
                Console.Write(node.data + ",");
                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }

            }
        }

        public static Node creatTree()
        {
            Node root= new Node("A",
                new Node("B",new Node("C"),new Node("D")),
                new Node("E",new Node("F"),
                new Node("G", new Node("H"),null)));

            return root;
        }
        
        public static void selectionSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j<array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void QuickSort(int[] array , int low , int high)
        {
            if( low < high)
            {
                int pi = pivotProcess(array, low, high);
                QuickSort(array, low, pi-1);
                QuickSort(array , pi+1, high);
            }

        }

        public static int pivotProcess(int[] array , int low , int high)
        {
            int pivot= array[high];
            int i= low-1;
            for(int j= low; j<= high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int tmp= array[i];
                    array[i]= array[j];
                    array[j]= tmp;
                   
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i+1;

        }
        public static int binarySearch(int[] array , int num)
        {
            int numİdx=0;
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == num)
                {
                    return mid; 
                }
                else if (array[mid] < num)
                {
                    low = mid + 1; 
                }
                else
                {
                    high = mid - 1; 
                }
            }
            return -1;
        }
        public static int maxİnArray(int[] array)
        {
            int max = array[0];
            foreach (int i in array) { 
                if (i > max) max = i;
            }
            return max;

        }
        public static int minİnArray(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min) min = i;
            }
            return min;

        }

        public static bool Palindrome(int num)
        {
            int result = num;
            int reverseNum = 0;
            while (result > 0)
            {
                int temp = result % 10;
                reverseNum = reverseNum * 10 + temp;
                result /= 10;
            }
            return num == reverseNum;
        }

        public static void Faktorial(int fact)
        {
            int result1 = 1;
            for (int i = 1; i <= fact; i++)
            {
                result1 = result1 * i;



            }
            Console.WriteLine(result1);
        }

        public static void Fibonachi(int fibo)
        {
            int f1 = 1;
            int f2 = 1;

            Console.Write(f1 + " , " + f2);
            for (int i = 0; i < fibo; i++)
            {
                int result = f1 + f2;
                Console.Write(" , " + result);
                f1 = f2;
                f2 = result;
            }
        }
    }
}
