using System;

namespace Binary
{
    public class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            int first = 0;
            int last = array.Length - 1;
            while (first <= last)
            {
                int mid = first + (last - first) / 2;
                if (value < array[mid])
                    last = mid - 1;
                else if (value > array[mid])
                    first = mid + 1;
                else
                    return mid;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            TestNegativeNumbers();
            TestNonExistentElement();
            TestEmptyArray();
            TestHugeArray();
            TestFiveArray();
            TestDuplicateElement();
            Console.ReadKey();
        }

        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента работает корректно");
        }

        private static void TestEmptyArray()
        {
            //Поиск в пустом массиве (содержащем 0 элементов)
            int[] numbers = new int[0] { };
            if (BinarySearch(numbers, 1) >= 0)
                Console.WriteLine("! Поиск нашёл число 1 в пустом массиве");
            else
                Console.WriteLine("Поиск элемента в пустом массиве работает корректно");
        }

        private static void TestHugeArray()
        {
            //Поиск в массиве из 100001 элементов
            int[] hugeNumbers = new int[100001];
            for (int i = 0; i < hugeNumbers.Length; i++)
            {
                hugeNumbers[i] = i;
            }
            if (BinarySearch(hugeNumbers, 5) != 5)
                Console.WriteLine("! Поиск не нашёл число 5 в  массиве из 100001 элементов");
            else
                Console.WriteLine("Поиск в массиве из 100001 элементов работает корректно");
        }

        private static void TestFiveArray()
        {
            //Поиск одного элемента в массиве из 5 элементов
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            if (BinarySearch(numbers, 3) != 2)
                Console.WriteLine("! Поиск не нашёл число 3 среди чисел { 1, 2, 3, 4, 5 }");
            else
                Console.WriteLine("Поиск одного элемента в массиве из 5 работает корректно");
        }

        private static void TestDuplicateElement()
        {
            //Поиск элемента, повторяющегося несколько раз
            int[] array = new int[] { 1, 1, 1, 2 };
            if (BinarySearch(array, 1) != 1)
                Console.WriteLine("! Поиск нашёл не тот индекс элемента 1 среди чисел { 1, 1, 1, 2 }");
            else
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз работает корректно");
        }
    }
}