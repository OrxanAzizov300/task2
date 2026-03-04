namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            /*int age = int.Parse(Console.ReadLine());
            if (age>65 || age==65)
            {
                Console.WriteLine("Pensiya yasina catib");
            }
            else
            {
                Console.WriteLine("Cavan usagsan ged isle hele");
            }*/


            //task2
            /*int num = int.Parse(Console.ReadLine());
            if (num>0 && num<125)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }*/


            //task3
            /*int num = int.Parse(Console.ReadLine());
            if (num>0)
            {
                if (num%2==0)
                {
                    Console.WriteLine("eded cutdur");
                }
                else
                {
                    Console.WriteLine("eded tekdir");
                }
            }
            else
            {
                Console.WriteLine("MUSBET EDED YAZ!!!");
            }*/

            //task4
            /*int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("sert odendi");
                }
                else
                {
                    Console.WriteLine("odenmedi");
                }
            }
            else
            {
                Console.WriteLine("MUSBET EDED YAZ!!!");
            }*/


            //task5
            /*int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("bolundu");
                }
                else
                {
                    int qaliq = num % 2;
                    Console.WriteLine(qaliq);
                }
            }
            else
            {
                Console.WriteLine("MUSBET EDED YAZ!!!");
            }*/


            //task6
            /*int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1*num2>0)
            {
                Console.WriteLine("musbetdir");
            }
            else if (num1 * num2 < 0) //tekce else yazmamagimin sebebi birden vuranda netice 0 olsa
            {
                Console.WriteLine("menfidir");
            }*/

            //task7

            /*string userName = Console.ReadLine();
            string userSurname = Console.ReadLine();
            string userFullName = userName + " " + userSurname;
            Console.WriteLine(userFullName);*/

            //task8

            /*int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            double bmi = height / weight *weight;
            if (bmi>25)
            {
                Console.WriteLine("ARTIQ CEKILI");
            }
            else if(bmi>18.5 && bmi < 24.9)
            {
                Console.WriteLine("Normal cekili");
            }
            else
            {
                Console.WriteLine("ariqqq");
            }*/




            //task9
            /*int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 1; i--)    
            {
                num = num * (i-1);
                
            }
            Console.WriteLine(num);*/



            //task10
            /*int[] arr = { 2, 5, 4, 3, 9, 12, 7};
            int arrMax = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]%2!=0 && arr[i] > arrMax)
                {
                    arrMax = arr[i];
                }
            }
            Console.WriteLine(arrMax);*/


            //task11
            /*int[] arr = { 2, 5, 4, 3, 9, 12, 7 };
            int arrMax = arr[0];
            int arrMin = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arrMax)
                {
                    arrMax = arr[i];
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arrMin)
                {
                    arrMin = arr[i];
                }
            }
            Console.WriteLine((arrMin + arrMax)/2);*/


            //task12

            int[] arr = { 2, 5, 4, 3, 9, 12, 7 };
            int arrMax = arr[0];
            int arrMin = arr[0];
            int cem = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arrMax)
                {
                    arrMax = arr[i];
                }
            }
            Console.WriteLine(arrMax);
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < arrMin)
                {
                    arrMin = arr[j];
                }
            }
            Console.WriteLine(arrMin);
            for (int z = 0; z < arr.Length; z++)
            {
                
                if (z == arrMin || z == arrMax)
                {
                    continue;
                }
                Console.WriteLine(arr[z]);
                cem = cem + arr[z];



            }
            Console.WriteLine(cem);
        }
    }
}
            

        

