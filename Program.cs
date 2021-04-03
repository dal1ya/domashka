using System;

namespace домашка
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите размерность массивов A и B");
            
            var n = Convert.ToInt32(Console.ReadLine());
            var m = Convert.ToInt32(Console.ReadLine());
            var arrayA = new int[n, m];
            var arrayB = new int[n, m];
            var arrResult = new int[n, m];
            var arrTrans = new int[m, n];

            arrayA = ArrayMaster.Array(arrayA);
            Console.WriteLine("A=");
            ArrayMaster.PrintArray(arrayA);
            
            
            arrayB = ArrayMaster.Array(arrayB);
            Console.WriteLine("B=");
            ArrayMaster.PrintArray(arrayB);
            
            
            if (n != m)
            {
                Console.WriteLine("Операция произведения невозможна");
                Console.WriteLine();
            }

            else
            { 
                arrResult = ArrayMaster.MultArray(arrayA, arrayB);
                Console.WriteLine("A*B=");
                ArrayMaster.PrintArray(arrResult);
            }


            arrResult = ArrayMaster.SumArray(arrayA, arrayB);
            Console.WriteLine("A+B=");
            ArrayMaster.PrintArray(arrResult);
            
            
            arrResult = ArrayMaster.SubArray(arrayA, arrayB);
            Console.WriteLine("A-B=");
            ArrayMaster.PrintArray(arrResult);
            
            
            arrResult = ArrayMaster.PowArray(arrayA);
            Console.WriteLine("A*A=");
            ArrayMaster.PrintArray(arrResult);
            
            
            arrResult = ArrayMaster.PowArray(arrayB);
            Console.WriteLine("B*B=");
            ArrayMaster.PrintArray(arrResult);


            arrTrans = ArrayMaster.TransArray(arrayA);
            Console.WriteLine("A'=");
            ArrayMaster.PrintArray(arrTrans);


            arrTrans = ArrayMaster.TransArray(arrayB);
            Console.WriteLine("B'=");
            ArrayMaster.PrintArray(arrTrans);
        }
    }
}