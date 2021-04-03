using System;

namespace домашка
{
    public class ArrayMaster
    {
        private static Random rnd = new Random(); //метод для ввода
        public static int[,] Array(int[,] arr)
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                }
            }
            return arr;
        }
        
        public static void PrintArray(int[,] arr) //метод для вывода
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[,] MultArray(int[,] arr1, int[,] arr2) //метод для умножения
        {
            var arrResult = new int[arr1.GetLength(1), arr1.GetLength(0)];
            for (var i = 0; i < arr1.GetLength(0); i++)
            {
                for (var j = 0; j < arr1.GetLength(1); j++)
                {
                    for (var k = 0; k < arr1.GetLength(0); k++)
                    {
                        arrResult[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            return arrResult;
        }

        public static int[,] SumArray(int[,] arr1, int[,] arr2) //метод для сложения
        {
            var arrResult = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (var i = 0; i < arr1.GetLength(0); i++)
            {
                for (var j = 0; j < arr1.GetLength(1); j++)
                {
                    arrResult[i, j] = arr1[i,j] + arr2[i,j];
                }
            }

            return arrResult;
        }
        
        public static int[,] SubArray(int[,] arr1, int[,] arr2) //метод для вычитания
        {
            var arrResult = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (var i = 0; i < arr1.GetLength(0); i++)
            {
                for (var j = 0; j < arr1.GetLength(1); j++)
                {
                    arrResult[i, j] = arr1[i,j] - arr2[i,j];
                }
            }

            return arrResult;
        }
        
        public static int[,] PowArray(int[,] arr) //метод для возведения в квадрат
        {
            var arrPow = new int[arr.GetLength(0), arr.GetLength(1)];
            
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    arrPow[i, j] = arr[i,j]*arr[i,j];
                }
            }

            return arrPow;
        }

        public static int[,] TransArray(int[,] arr) //метод для транспонирования
        {
            var arrTrans = new int[arr.GetLength(1), arr.GetLength(0)];
            for (var i = 0; i < arr.GetLength(1); i++)
            {
                for (var j = 0; j < arr.GetLength(0); j++)
                {
                    arrTrans[i, j] = arr[j, i];
                }
            }

            return arrTrans;
        }
    }
}