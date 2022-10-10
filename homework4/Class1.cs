using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework4
{
    class Arrays
    {

        private int[] array;

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public Arrays(int[] array)
        {

            this.array = array;

        }


        public Arrays(int size, int step)
        {

            array = new int[size];
            int num = 0;

            for (int i = 0; i < size; i++) //создаем массив, выбираем его размер и шаг при вызове 
            {

                array[i] = num; //значение, которое записывается по индексу i. на каждой итерации мы прибавляем шаг и заносим в следующую ячейку результат
                num += step;

            }

        }

        public int Sum //свойство суммы чисел в массиве
        {

            get
            {
                this.array = array;
                int summ = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    summ += array[i];
                }
                return summ;
            }


        }

        public int MaxCount //свойство суммы чисел в массиве
        {

            get
            {
                this.array = array;
                int max = array[0];
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        count = 1;
                    }
                    else if (array[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }

        }




        public void Multi(int num)
        {
            this.array = array;
            int multi;
            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                multi = array[i] * num;
                Console.WriteLine($"{array[i]} * {num} = {multi}");
            }

        }


        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }

    internal class Class1
    {





        static void Main(string[] args)
        {

            Arrays myArray = new Arrays(10, 2); //создаем массив в котором 10 элементов с шагом 2
            myArray.PrintArray();

            Console.WriteLine($"Сумма чисел в массиве = {myArray.Sum}");

            myArray.Multi(2); //умножаем каждое число на 2

            Console.WriteLine($"{myArray.MaxCount}");



            static void Login(string userLogin = null, string userPassword = null) //проверка логина и пароля методом
            {

                int i = 3;
                string[] users = File.ReadAllLines("F:\\курсы\\homework2\\homework4\\bin\\Debug\\net6.0\\logins.txt");

                do
                {

                    string login = users[0];
                    string password = users[1];
                    Console.Write($"Введите логин: ");
                    userLogin = Console.ReadLine();
                    Console.Write($"Введите пароль: ");
                    userPassword = Console.ReadLine();

                    if (userLogin == login && userPassword == password)
                    {
                        Console.WriteLine("\nЛогин и пароль верны");
                        break;
                    }
                    else
                    {
                        i--;
                        Console.WriteLine($"Вы ввели неверный логин или пароль, попробуйте еще раз. \nУ вас {i} попытки");
                    }
                }
                while (i != 0);
                
            }
            Login();

            static void StructLogin() //проверка логина и пароля с использованием структуры
            {
                int i = 3;

                string userLogin;
                string userPassword;

                do
                {

                    Console.Write($"Введите логин: ");
                    userLogin = Console.ReadLine();
                    Console.Write($"Введите пароль: ");
                    userPassword = Console.ReadLine();

                    var account = new Account();
                    account.AccountLogin();

                    var pass = new Account();
                    pass.AccountPassword();


                    if (account.AccountLogin(userLogin) && pass.AccountPassword(userPassword))
                    {
                        Console.WriteLine("\nЛогин и пароль верны");
                        break;
                    }
                    else
                    {
                        i--;
                        Console.WriteLine($"Вы ввели неверный логин или пароль, попробуйте еще раз. \nУ вас {i} попытки");
                    }
                }
                while (i != 0);


            }
            StructLogin();
        }

    }
}