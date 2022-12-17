using System;

namespace Kulishovlab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Задание 1: Напишите программу, чтобы найти значение указанного выражения");
            int a = (101 + 0) / 3;
            Console.WriteLine(a);
            double b = Math.Pow(3, -6) * 10000000.1;
            Console.WriteLine(b);
            bool c = true && true;
            Console.WriteLine(c);
            bool d = false && true;
            Console.WriteLine(d);
            bool e = (false && false) && (false && true);
            Console.WriteLine(e);
            bool f = (false && false) && (true && true);
            Console.WriteLine(f);

            Console.WriteLine("Задание 2: Напишите программу, которая принимает четыре целых числа от пользователя и выводит надпись равно, если все четыре равны, и не равно в противном случае");
            int firstNum, secondNum, thirdNum, fourthNum;
            Console.WriteLine("Напишите 4 числа");
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            thirdNum = Convert.ToInt32(Console.ReadLine());
            fourthNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum == secondNum && firstNum == thirdNum && firstNum == fourthNum)
            {
                Console.WriteLine("равно");
            }
            else
            {
                Console.WriteLine("не равно");
            }

            Console.WriteLine("Задание 3: Напишите программу для поиска k самых больших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");
            int[] arrInt = new int[random.Next(1, 100 + 1)];
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = random.Next(1, 100 + 1);
            }
            Sort(arrInt);
            Console.WriteLine("Введите к");
            int k = Convert.ToInt32(Console.ReadLine());
            int k1 = arrInt.Length - k;
            for (int i = arrInt.Length - 1; i > k1 - 1; i--)
            {
                Console.Write(arrInt[i] + " ");
            }


            Console.WriteLine();
            Console.WriteLine("Задание 4: Напишите программу для поиска k наименьших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arrInt[i] + " ");
            }

            Console.WriteLine("Задание 5: Напишите программу для поиска чисел, превышающих среднее значение чисел данного массива.");

            int[] arrIntTAsk5 = new int[random.Next(1, 100 + 1)];
            int numOverAveTask5 = 0;
            double aveTask5;

            for (int i = 0; i < arrIntTAsk5.Length; i++)
            {
                arrIntTAsk5[i] = random.Next(1, 100 + 1);
                numOverAveTask5 += arrIntTAsk5[i];
            }

            foreach (int i in arrIntTAsk5)
            {
                Console.Write(i + " ");
            }

            aveTask5 = numOverAveTask5 / arrIntTAsk5.Length;

            Console.WriteLine("\n" + aveTask5 + "\n");


            foreach (int i in arrIntTAsk5)
            {
                if (i > aveTask5)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 6: Напишите программу для умножения двух заданных целых чисел без использования оператора умножения(*).");
            Console.WriteLine("Введите целое первое число");
            int firstNumTask6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое второе число");
            int secondNumTask6 = Convert.ToInt32(Console.ReadLine());
            int resultTask6 = 0;
            for (int i = 0; i < secondNumTask6; i++)
            {
                resultTask6 += firstNumTask6;
            }
            Console.WriteLine(resultTask6);

            Console.WriteLine("Задание 7: Напишите для разбиения заданного массива целых чисел на четное число первым и нечетное число вторым.");
            int[] firstArr = new int[arrInt.Length];
            int[] secondArr = new int[arrInt.Length];
            for (int i = 0; i < arrInt.Length; i++)
            {
                double a7 = arrInt[i] % 2;
                if (a7 != 0)
                {
                    firstArr[i] = arrInt[i];
                }
                else
                {
                    secondArr[i] = arrInt[i];
                }
            }
            Console.WriteLine("Не чётные ==");
            foreach (int i in firstArr)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Чётные ==");
            foreach (int i in secondArr)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("Задание 8: Напишите програмиу для преобразования температуры из градуса Фаренгейта в градус Цельсия.");
            Console.WriteLine("Напишите температуру в Фаренгейтах");
            double far = Convert.ToDouble(Console.ReadLine());
            double celsiusc = (far - 32) * 5 / 9;
            Console.WriteLine("C = {0}", celsiusc);

            Console.WriteLine("Задание 9: Напишите программу для вычисления индекса массы тела (ИМТ). ИМТ = ВЕС / РОСТ2");
            Console.WriteLine("Напишите вес тела");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите рост в  метрах");
            double b9 = Convert.ToDouble(Console.ReadLine());
            double c9 = a9 / b9;
            Console.WriteLine(c9 + "= имт");

            Console.WriteLine("Задание 10: Напишите программу, которая считывает число и отображает квадрат, куб и четвертую степень. ");
            Console.WriteLine("Напишите число");
            int numTask10 = Convert.ToInt32(Console.ReadLine());
            double  numSqu= Math.Pow(numTask10, 2);
            Console.WriteLine(numSqu);
            double numCube = Math.Pow(numTask10, 3);
            Console.WriteLine(numCube);
            double num4degree = Math.Pow(numTask10, 4);
            Console.WriteLine(num4degree);

            Console.WriteLine("Задание 11: Напишите программу, чтобы проверить, могут ли три заданные длины сторон (целые числа) образовать треугольник или нет.");
            Console.WriteLine("Напишите 3 стороны");
            int firstSide= Convert.ToInt32(Console.ReadLine());
            int secondSide = Convert.ToInt32(Console.ReadLine());
            int thirdSide = Convert.ToInt32(Console.ReadLine());
            if (firstSide + secondSide > thirdSide || firstSide + thirdSide > secondSide || thirdSide + secondSide > firstSide)
            {
                Console.WriteLine("могут");
            }
            else
            {
                Console.WriteLine("не могут");
            }


          
        }

        static void Sort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
