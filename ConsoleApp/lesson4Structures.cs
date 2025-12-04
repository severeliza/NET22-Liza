using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class lesson4Structures
    {
        // Циклы
        public static void taskLoop()
        {
            // 1 Необходимо вывести на экран числа от N до 1.
            int N = 0;

            Console.WriteLine("Введите N");

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Некорректный ввод.\n");
            }

            Console.WriteLine("\nЧисла от N до 1:");
            for (int i = N; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //2 Необходимо, чтоб программа выводила последовательность: 7 14 21 28 42 49…..
            Console.WriteLine($"\nТаблица умножения на 7 от 1 до {N}");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(7*i);
            }

            //3 Вывод последовательности Фибоначчи
            Console.WriteLine($"\nПервые {N} чисел последовательности Фибоначчи:");
            int a = 0, b = 1, tmp = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < N-2; i++)
            {
                Console.WriteLine(a+b);
                tmp = a + b;
                a = b;
                b = tmp;
            }

            //3б С массивом
            int[] arr = new int[N];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < N; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }

            Console.WriteLine(arr);
        }

        // Матрицы
        public static void taskMatrix()
        {
            int[,] matrix = createMatrix(out int n, out int m);

            int operation = 0;

            while (operation < 5)
            {
                Console.WriteLine("Выберите задачу:\n1. Вывести матрицу\r\n2. Найти количество положительных/отрицательных чисел в матрице.\r\n3. Вывести матрицу так чтобы в четных строках, отображались только четные элементы, а в нечетных – нечетные. \r\n4. Используя словарь подсчитать и вывести сколько раз, какое число было в матрице.");

                if (!int.TryParse(Console.ReadLine(), out operation) || operation > 4)
                {
                    Console.WriteLine("Некорректный ввод.\n");
                }

                switch (operation)
                {
                    case 1:
                        outputMatrix();
                        break;
                    case 2:
                        qtyPositive(matrix);
                        break;
                    case 3:
                        evenPositionView(matrix);
                        break;
                    case 4:
                        numberDictionary(matrix);
                        break;
                    default:
                        break;
                }
            }

            int[,] createMatrix(out int n, out int m)
            {
                // Заполните автоматически матрицу n*m
                
                Console.WriteLine("Введите n, m < 6");

                if (!int.TryParse(Console.ReadLine(), out n) || n > 6)
                {
                    Console.WriteLine("Некорректный ввод.\n");
                }

                if (!int.TryParse(Console.ReadLine(), out m) || m > 6)
                {
                    Console.WriteLine("Некорректный ввод.\n");
                }

                int[,] localMatrix = new int[n, m];

                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        localMatrix[i, j] = rnd.Next(-9, 10);
                    }
                }

                return localMatrix;
            }

            void outputMatrix()
            {
                string output = "Матрица " + n + " x " + m + "\n";

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        output += matrix[i,j];
                        output += "\t";
                    }

                    output += "\n";
                }

                Console.WriteLine(output);
            }

            void qtyPositive(int[,] arr)
            {
                int qty = 0;
                foreach (int i in arr)
                {
                    if (i > 0)
                        qty++;
                }

                Console.WriteLine("Количество положительных чисел в матрице: " + qty);
            }

            void evenPositionView(int[,] arr)
            {
                string output = "Матрица, в четных строках - только четные элементы, а в нечетных – нечетные.\n";

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        output += (i + arr[i, j]) % 2 == 0 ? arr[i, j] + "\t" : "\t";
                    }

                    output += "\n";
                }

                Console.WriteLine(output);
            }

            void numberDictionary(int[,] arr)
            {
                var numberDictionary = new Dictionary<int,int>();

                foreach (int i in arr)
                {
                    if (numberDictionary.ContainsKey(i))
                        numberDictionary[i]++;
                    else
                        numberDictionary.Add(i, 0);
                }

                var keys = numberDictionary.Keys;

                foreach (int i in keys)
                {
                    Console.WriteLine($"{i} :  \t{numberDictionary[i]+1}");
                }
            }
        }

        public static void taskLists()
        {
            //1. Создать лист целых чисел. Заполнить вручную или Math.random().
            List<int> numbers = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rnd.Next(-9, 10));
            }


            //2. Дать возможность вывода, добавления или удаления элементов.
            int operation = 1;

            while (operation != 0)
            {
                Console.WriteLine("\nВыберите задачу:\n1.Вывести список\n2.Добавить элемент\n3.Удалить элемент\n0.Следующее задание.");

                if (!int.TryParse(Console.ReadLine(), out operation) || operation > 3)
                {
                    Console.WriteLine("Некорректный ввод.\n");
                    continue;
                }

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("List:");
                        printCollection(numbers);
                        break;
                    case 2:
                        int.TryParse(Console.ReadLine(), out int addN);
                        numbers.Add(addN);
                        break;
                    case 3:
                        int.TryParse(Console.ReadLine(), out int removeN);
                        numbers.Remove(removeN);
                        break;
                    default:
                        break;
                }
            }

            //3. Заменить каждый четный элемент на удвоенное значение (*2), я нечетный на 0. Вывести лист.
            List<int> numbers2 = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers2.Add(numbers[i] * numbers[i]);
                } 
                else
                {
                    numbers2.Add(0);
                }
            }

            Console.WriteLine("New list:");
            printCollection(numbers2);

            //4. По этому листу создать HashSet. Вывести.
            HashSet<int> setN = new HashSet<int>(numbers);
            Console.WriteLine("\nHashSet:");
            printCollection(setN);
   
            
            void printCollection(IEnumerable printList)
            {
                foreach (int item in printList)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
