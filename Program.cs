using System;

namespace Sarachuk
{
    class Program
    {       
        static void Main(string[] args)
        {
            int num = 0, t1 = 0;
            string s1 = string.Empty;
            Console.WriteLine("   Задания:");
            Console.WriteLine("1) если введенное число больше 7, то вывести Привет");
            Console.WriteLine("2) если введенное имя совпадает с Вячеслав, то вывести Привет, Вячеслав, если нет, то вывести Нет такого имени");
            Console.WriteLine("3) на входе есть числовой массив, необходимо вывести элементы массива кратные 3");
            Console.Write("Введите номер задания: ");                        
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nException: {ex.Message}");
                Console.WriteLine("Press Enter to continue\n");                    
                Console.ReadKey();
            }            

            //Задание 1
            if (num == 1) {
                Console.WriteLine($"Вы выбрали Задание №{num}");
                Console.Write("Введите число больше 7: ");
                try
                {
                    t1 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nException: {ex.Message}");
                    Console.WriteLine("Press Enter to continue\n");                                        
                }
                if (t1 > 7)
                {
                    Console.WriteLine("\nПривет\n");
                }
                else
                {
                    Console.WriteLine($"\nВаше число: {t1}\n");
                }
                Console.ReadKey();
            }
            
            //Задание 2
            else if (num == 2) {
                Console.WriteLine($"Вы выбрали Задание №{num}");
                Console.Write("Введите имя, например Вячеслав: ");
                s1 = Console.ReadLine();
                if (s1.Equals("Вячеслав"))
                {
                    Console.WriteLine("\nПривет, Вячеслав\n");
                }
                else
                {
                    Console.WriteLine($"\nНет такого имени\n");
                }
                Console.ReadKey();
            }
            
            //Задание 3
            else if (num == 3) {
                Console.WriteLine($"Вы выбрали Задание №{num}");
                Console.Write("Введите количество элементов массива: ");
                int n3 = 0;
                try
                {
                    n3 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nException: {ex.Message}");
                    Console.WriteLine("Количество элементов массива: 0\n");
                    n3 = 0;
                }                
                int[] a3 = new int[n3];
                if (n3 > 0) Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n3; i++)
                {
                    try
                    {
                        a3[i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception: {ex.Message}");
                        Console.WriteLine("Элементу массива присвоено значение 0.");
                        a3[i] = 0;
                    }
                }
                if (n3 > 0) Console.Write("Элементы массива, кратные 3: ");
                int sd3 = 0;
                foreach (int s in a3)
                {
                    if (s%3 == 0) {
                        Console.Write(s+ " ");
                        sd3++;
                    }
                }
                if (sd3 == 0) Console.WriteLine("не найдены");
                Console.ReadKey();
            }
            
            //Задание не найдено
            else {
                Console.WriteLine($"\n   Задание не найдено. Введите доступный номер из списка заданий.");
            }            
            
            //Console.ReadKey();
            Main(args);
        }        
    }
}