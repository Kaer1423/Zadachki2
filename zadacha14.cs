using System;

namespace zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем строку для конвертирования и превращаем её в массив символов
            string str ="Любой Текст - Hello World";
            char[] chars = str.ToCharArray();
            Console.WriteLine("Изначальная строка: "+ str);
            
            //Проходимся по массиву символов циклом, менняя регистр каждого элемента
            for (int i= 0; i<chars.Length;i++)
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);

                }
                else
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }
            //преобразуем массив символов обратно в строку
            str = new string(chars);
            Console.WriteLine("Строка после преобраования: " + str);
        }
    }
}
