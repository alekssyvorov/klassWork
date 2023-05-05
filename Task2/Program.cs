using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Создайте приложение, отображающее количество
            //значений в массиве меньше заданного параметра пользователем. Например, количество значений меньших, чем 7
            //(7 введено пользователем с клавиатуры).

            Console.WriteLine("Input number");
            int number = int.Parse(Console.ReadLine());
            int[] arr = InitMass();
            Console.WriteLine($"Count elem < user {Check(arr, number)}");
        }

        static int[] InitMass()
        {
            Random r = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-50, 50);
            }
            return mass;
        }

        static int Check(int[] mass, int user)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < user)
                    count++;
            }
            return count;
        }
    }
}
