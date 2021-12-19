using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем массив с 10 элементами и заполняем его рандомными значениями
            double[] arr =new double[10];
            Random rand = new Random();
            Console.Write("Массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");
            }

            //Вводим с консоле наименьшее число интервала и наибольшее
            Console.WriteLine("\n"+"Введите нижнюю границу диапазона: ");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона: ");
            double max = double.Parse(Console.ReadLine());
            while (max<min) // проверяем что наибольшее число всёже больше (дабы избежать ошибок в вводе)
            {
                Console.WriteLine("!--Верхняя граница не может быть меньше нижней");
                Console.WriteLine("Введите верхнюю границу диапазона: ");
                max = double.Parse(Console.ReadLine());
            }

            //подсчитываем колличество элементов попавших в интервал
            double count=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= min && arr[i] <= max) count++;
            }

            //Выводим ответ на консоль
            Console.WriteLine();
            Console.WriteLine("Колличесвто элементов массива в диапозоне: " + count);
            Console.WriteLine("Доля элементов массива в диапозоне: " + count / arr.Length);
        }
    }
}
