using System;

namespace P127_References_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //CheckNumber(number); 
            //Console.WriteLine("1-ci ededi daxil edin");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2-ci ededi daxil edin");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Operatoru daxil edin +,-,/,*");
            //char Operator = Convert.ToChar(Console.ReadLine());
            //Calculate(number1, number2, Operator);


            //Add(5,2);
            //Add("Avaz", "Mammadli");
            //Add(5,2);
            //Add("Ali", 255);
            //Add(7800, 6430);
            //Add(bNum1: 50, bNum2: 200);


            //int total = 5;
            //Add(out total);
            //Console.WriteLine(total);
            //string numStr = Console.ReadLine();
            //int number;
            //bool result = int.TryParse(numStr,out number);
            //if (result)
            //{
            //    Console.WriteLine(number);
            //}
            //else{
            //    Console.WriteLine("duzgun eded daxil edin");
            //}

            //Array methods

            int[] arr = { 1, 3, 5, 8, 10, 13, 20,13, 27,5,13 };
            //Console.WriteLine(Array.LastIndexOf(arr,13));

            int num = Array.Find(arr, x => x == 1239);
            Console.WriteLine(num);

            int[] num2 = Array.FindAll(arr, x => x == 13);
            foreach (int number in num2)
            {
                Console.WriteLine(number);
            }

            bool result = Array.Exists(arr,x=>x==8);
            if (result)
            {
                Console.WriteLine("Bele bir eded var");
            }
            else
            {
                Console.WriteLine("Bele bir eded yoxdur");
            }
        }
        #region Task 1
        //public static void CheckNumber(int num)
        //{
        //    if (num%7==0)
        //    {
        //        Console.WriteLine("7ye bolunur");
        //    }
        //    else
        //    {
        //        int x = num % 7;
        //        while (x>=4)
        //        {

        //            if (num%7==0)
        //            {
        //                Console.WriteLine(num);
        //                break;
        //            }
        //            num++;

        //        }
        //        while (x<4)
        //        {
        //            if (num % 7 == 0)
        //            {
        //                Console.WriteLine(num);
        //                break;
        //            }
        //            num--;
        //        }

        //    }
        //}
        #endregion

        #region Task 2
        //public static void Calculate(int num1, int num2, char Operator)
        //{
        //    switch (Operator)
        //    {
        //        case '+':
        //            Console.WriteLine(num1 + num2);
        //            break;
        //        case '-':
        //            Console.WriteLine(num1 - num2);
        //            break;
        //        case '*':
        //            Console.WriteLine(num1 * num2);
        //            break;
        //        case '/':
        //            Console.WriteLine(num1 / num2);
        //            break;

        //        default:
        //            Console.WriteLine("Duzgun Operator Daxil Edin");
        //            break;
        //    }

        //}
        #endregion


        public static void Add(byte bNum1, byte bNum2)
        {
            Console.WriteLine(bNum1 * bNum2);
        }
        public static void Add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }

        public static void Add(string name,string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
       

        public static void Add(string name, byte age)
        {
            Console.WriteLine(name + " " + age);
        }


        public static void Add(long num1, long num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(out int num)
        {
            num = 100 ;
        }
    }
}
