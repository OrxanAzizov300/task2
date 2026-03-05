namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(SentenceLength("Netersen ne var ne yox"));*/
            /*int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(MonthNum(userNumber));*/

           /* int[] arr = [1, 2, 3, 4, 5];
            Console.WriteLine(ReversedArr(arr));*/

            /*Console.WriteLine(CalculateAverage(3, 4, 5));*/
            /*Console.WriteLine(Muqayise(3,2));*/
            /*Console.WriteLine(InTheArray(12));*/


        }


        //task1
        /*static int SentenceLength(string sentence)
        {
            int say = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                say++;
            }
            return say;
        }*/




        //task2
        /*static string MonthNum(int number)
        {
            switch (number)
            {
                case 1:
                    return "Monday";
                    
                case 2:
                    return "Tuesday";
                    
                case 3:
                    return "Wednesday";
                    
                case 4:
                    return "Thursday";
                    
                case 5:
                    return "Friday";
                    
                case 6:
                    return "Saturday";
                    
                case 7:
                    return "Sunday";
                    
                default:
                    return "Invalid number";
            }
        }*/


        //task3
        /*static int BiggestNum(int [] arr)
        {
            int arrMax = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>arrMax)
                {
                    arrMax = arr[i];
                }
            }
            return arrMax;
        }*/


        //task4
        /*static double CalculateAverage(int a, int b, int c)
        {
            int cem = a + b + c;
            double average = cem / 3;
            return average;
        }*/

        //task5
        /*static string Muqayise(int a, int b)
        {
            int cem = a + b;
            int hasil = a * b;
            if (cem>hasil)
            {
                return "Cem boyukdur";
            }
            else if (cem==hasil)
            {
                return "BERABERDILERRR!!!";
            }
            else
            {
                return "hasil boyukdur🙌";
            }
        }*/

        //task6
        /*static bool InTheArray(int num)
        {
            int[] arr = [1, 4, 7, 12, 56, 23, 22, 15];
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    return true;

                }
            }

            return false;
        }*/


        //task7
        /*static int SmallestNum(int[] arr)
        {
            int arrMin = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arrMin)
                {
                    arrMin = arr[i];
                }
            }
            return arrMin;
        }*/

        //task8

        /*static int[] ReversedArr(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length-1; i >=0 ; i--)
            {
                reversed[j] = arr[i];
                j++;
            }
            return reversed;
        }*/
    }
}
