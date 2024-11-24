using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab2_ITP
{
    internal class Program
    {
        #region power func 
        /*
        static double power(double baseNum, int exponent)
        {
            double result = 1;
            if (exponent == 0)
            {
                return 1;
            }
            if (exponent > 0)
            {
                for (int i = 0; i < exponent; i++)
                {
                    result *= baseNum;
                }
            }
            return result;
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Q1 menu[new,display,exit]
            /*
            char character;
            do
            {
                
                // to clear window
                Console.Clear();
                Console.SetCursorPosition(12, 5);
                Console.WriteLine("New");
                Console.SetCursorPosition(12, 6);
                Console.WriteLine("Display");
                Console.SetCursorPosition(12, 7);
                Console.WriteLine("Exit");

                Console.SetCursorPosition(5, 9);
                Console.WriteLine("please choose character n | d | e ");

                character = char.Parse(Console.ReadLine());
                switch (character)
                {

                    case 'n':
                        Console.WriteLine("New selected");
                        break;
                    case 'd':
                        Console.WriteLine("Display selected");
                        break;
                    case 'e':
                        Console.WriteLine("Exit selected");
                        break;
                    default:
                        Console.WriteLine("please choose valid character");
                        break;
                }
                Console.ReadLine();

            }
            while (character != 'e');
                */
            #endregion

            #region Q2 accept 5 nums ,print sum
            /*
            int sum = 0;
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Enter number{i+1} ");
                int number=int.Parse(Console.ReadLine());
                sum+= number;   
            }
            Console.WriteLine($"Sum of this 5 number = {sum}");
            */
            #endregion

            #region Q3 accept nums until its sum exceed 100

            /*
             int sum = 0;
            while (sum <= 100)
            {
                Console.WriteLine($"Enter number ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
                Console.WriteLine($"Sum of this number = {sum}");


            }
          Console.WriteLine("Sum of this number exceed 100");
            */
            #endregion

            #region Q4 one dim arr scan data[print,sum,max,min]
            /*
            Console.Write("Enter size of array : ");
            int size=int.Parse(Console.ReadLine());
            int[]arr= new int[size];

            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            for(int i=0; i<size; i++)
            {
                Console.Write($"Enter number {i+1} : ");
                arr[i]=int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < size; i++)
            {
                //sum
                sum += arr[i];
                Console.WriteLine("------");
                //max
                if (arr[i]>max)
                    max = arr[i];
               
                // or using built in method :
                //max = arr.Max();
                Console.WriteLine("------");


                //min
                if (arr[i] < min)
                    min = arr[i];

                // or using built in method :
                //min = arr.Min();
                Console.WriteLine("------");


            }
            Console.WriteLine($"Sum of numbers in array = {sum}");
            Console.WriteLine($"Maximum of numbers in array = {max}");
            Console.WriteLine($"Minimum of numbers in array = {min}");
 
            */

            #endregion

            #region Q5 2 dim arr scan[print sum for each row &col] -?
            /*
            int[,] arr = new int[3,4];
            int i;  //---> for rows
            int j;  //---> for columns

           

            for (i=0; i<arr.GetLength(0); i++)
            {
                for(j=0;j<arr.GetLength(1); j++)
                {
                    Console.Write($"Array [{i},{j}] = ");
                    arr[i,j]=int.Parse(Console.ReadLine());

                }

            }

            int[] rowSum = new int[arr.GetLength(0)];
            int[] colSum = new int[arr.GetLength(1)];


            // for to scan values in 2d arr:
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    rowSum[i] += arr[i, j];
                    colSum[j]+= arr[i, j];
                }
            }
            for (i = 0; i < arr.GetLength(0); i++)
            {
                for(j=0;j<arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}  ");

                }
                Console.WriteLine($"sum of row = {rowSum[i]}");
            }
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"sum of colunms = {colSum[j]}");
            }
            */
            #endregion

            #region prime number
            /*
            Console.Write("Enter number to check :");
            int Number = int.Parse(Console.ReadLine());

            
            if (Number < 2)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                for (int i = 2; i<Number; i++)
                {
                    if (Number % i == 0)
                    {
                        Console.WriteLine("Not prime");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("prime number");
                        break;
                    }

                }

            }
            */

            #endregion

            #region mirror of number
            /*
            Console.WriteLine("Enter number : ");
            string number =Console.ReadLine();
            string reversedNumber = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            Console.WriteLine($"Reversesd number : {reversedNumber}");
            */

            /*
            // other way :
            Console.WriteLine("Enter number : ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;
            while (number != 0)
            {
               // to get last number 
                int lastDigit = number % 10;
                //add to reverse
                reversed = reversed * 10 + lastDigit;
                //remove it from number
                number /= 10;
            }
            Console.WriteLine($"reverse of number : {reversed}");
            */
            #endregion

            #region split string
            /*
            Console.WriteLine("Enter your words");
            string words=Console.ReadLine();
            // to split sentence to words
            string[] word = words.Split();
            Array.Reverse(word);

            // to join words in one string 
            string reversedWords=string.Join(" ", word);
            Console.WriteLine($"reversed string : {reversedWords}");
            */
            #endregion

            #region count of '1'
            /*
            int count = 0;
            for (int i = 0; i <= 1000000; i++) 
            { 
                //convert number to string
                string number=i.ToString();
                foreach (char c in number)
                {
                    if (c == '1')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"count of number '1' in this range = { count}");
            */
            #endregion

            #region max distance between identical number
            /*
            int maxDistance = 0;

                        
            int[] arr = { 1, 2, 3, 4, 8, 2, 4, 1, 1, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
               for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        int distance = j - i;
                        if(distance > maxDistance)
                        {
                            maxDistance = distance;
                        }

                    }
                    //else
                    //{
                    //    j++;
                    //}
                    
                }
            Console.WriteLine($"max distance= {maxDictence}");

            }
            */
            #endregion


            #region power function
            /*
            Console.Write("Enter base number : ");
            double baseNumber=double.Parse(Console.ReadLine());

            Console.Write("Enter Exeponent : ");
            int Exeponent = int.Parse(Console.ReadLine());
           double result= power(baseNumber, Exeponent);

            Console.WriteLine($"result of {baseNumber}^{Exeponent} = {result}");
            */

            #endregion




        }
    }
}
