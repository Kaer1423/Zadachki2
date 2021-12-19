using System;

namespace zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество чисел в массиве : "); //Задаем колличество элементов в массиве
            int n = int.Parse(Console.ReadLine());
            int[] X = new int[n];   //Создаем массив с указанным олличеством элементов
            int num = 0;

            //Заполняем массив ранодмными значениями от 0 до 100 (можно любые подставить)
            Random rand = new Random();     
            Console.Write("Получился массив: ");
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(0, 100);
                Console.Write(X[i] + " ");
            }

            //Проходимся циклом по массиву и ищем значения,которые инвертированны
            //( т.е. таких пар элементов, в которых большее число находится слева от меньшего)
            for (int i = 0; i < X.Length - 1; i++)
            {
                if (X[i] > X[i + 1]) num++;
            }

            //Выводи ответ на консоль
            Console.WriteLine("\n"+"Колличество инверсий: " + num);
            Console.Read();
        }
    }
}
