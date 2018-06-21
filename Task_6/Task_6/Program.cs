using System;

namespace Task_6
{
    class Program
    {
        /// <summary>
        /// проверка на ввод
        /// </summary>
        /// <returns></returns>
        static int Input()
        {
            int a = 0;
            bool ok;
            do
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    ok = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое число");
                    ok = false;
                }
            } while (!ok);
            return a;
        }
        /// <summary>
        /// вывод последовательности
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        static void Print(double [] arr, int k)
        {
            if (k == 0)//вывод элементов, кратных 3
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 3 == 0)
                    {
                        Console.Write(arr[i] + " ");

                    }
            }
            else//вывод всех элементов
                for (int i = 0; i < arr.Length; i++)                    
                        Console.Write(arr[i] + " ");
   
        }
        /// <summary>
        /// проверка последовательности
        /// </summary>
        /// <param name="arrN"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <param name="j"></param>
        /// <param name="c"></param>
        static void Check( ref double[]arrN, int k, int m, int j, int c)
        {
            while (k != arrN.Length&&j!=m)
            {
                double last = 2 * Math.Abs(arrN[c+2] - arrN[c+1]) + arrN[c];
                arrN[k]= last;
                if (last % 3 == 0)
                    j++;
                k++;
                c++;
                Check(ref arrN, k, m, j, c);
                return;
            }
            if (j == m)//остановка для М
            {
                Console.WriteLine("M");
                Print(arrN, 0);
            }
            else//для N
                Console.WriteLine("N");
                Print(arrN, 1);            
        }

        static void Main(string[] args)
        {
            int n = 0, m = 0;
            do
            {
                Console.WriteLine("Введите N (N должно быть >3)");
                n = Input();
            } while (n <= 3);
            do
            {
                Console.WriteLine("Введите M (M должно быть >=0)");
                m = Input();
            } while (m <0);

            double[] masN = new double[n];
            masN[0] = Input();
            masN[1] = Input();
            masN[2] = Input();          
                   
            Check(ref masN, 3, m, 0, 0);
            Console.ReadKey();
        }
    }
      
          
             

}

