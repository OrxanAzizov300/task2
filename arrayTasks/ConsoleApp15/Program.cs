using System.Runtime.ConstrainedExecution;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [33,5,8,10,1,3,15,20,25];

            int arrMin = array[0];
            int arrMax = array[0];
            /*int cem = 0;*/
            /*int hasil = 1;*/


            //task1,2
            /*for (int i = 1; i < array.Length; i++)
            {
                if (array[i]<arrMin)
                {
                    arrMin = array[i];
                }
                if (array[i] > arrMax)
                {
                    arrMax = array[i];
                }


            }
            Console.WriteLine(arrMin);
            Console.WriteLine(arrMax);*/

            //task3
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==1)
                {
                    Console.WriteLine(array[i]);
                }
            }*/


            //task4
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }*/

            //task5
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    cem += array[i];
                }
            }
            Console.WriteLine(cem);*/

            //task6
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    hasil *= array[i];
                }
            }
            Console.WriteLine(hasil);*/

            //task7
            /*for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < arrMin)
                {
                    arrMin = array[i];
                }
                if (array[i] > arrMax)
                {
                    arrMax = array[i];
                }


            }
            Console.WriteLine(arrMax - arrMin);*/

            //task8
            /*for (int i = 1; i < array.Length; i++)
            {
                if (array[i]%2==1 && array[i] > arrMax)
                {
                    arrMax = array[i];
                }


            }
            Console.WriteLine(arrMax);

            //task9
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] < arrMin)
                {
                    arrMin = array[i];
                }


            }
            Console.WriteLine(arrMin);*/

        }
    }
}
