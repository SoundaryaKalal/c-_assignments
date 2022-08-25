1.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
Convert this program using a function

//multi2num

namespace ConsoleApp2
{
    internal class Program
    {
        public static int mul_num(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        public static void MSain()
        {
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = mul_num(num1, num2, num3);
            Console.WriteLine($"the output is {result}");

        }
    }
}

2.Write a C# program that accepts and 2 numbers and prints the small no
Convert this program using out parameter

//swap//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swap
    {
        public static void numSwap(ref int dig1, ref int dig2)
        {
            int temp = 0;
            temp = dig1;
            dig1 = dig2;
            dig2 = temp;

        }
        public static void Main()
        {
            int dig1 = 15;
            int dig2 = 30;
            Console.WriteLine($"Values before swap are {dig1},{dig2}");
            numSwap(ref dig1, ref dig2);
            Console.WriteLine($"Values after swap are {dig1},{dig2}");
        }
    }
}
3.Write a C# to swap two numbers using ref parameters

//twonum

namespace ConsoleApp2
{
    internal class SmallNum
    {
        public static void Num(int num1, int num2, out int result)
        {
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
        }
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter First Number");


            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number");

            num2 = Convert.ToInt32(Console.ReadLine());


            Num(num1, num2, out int result);
            Console.WriteLine($"The smaller number is {result}");
        }




    }
}

4.Write a program that takes as input a number in 2011) and performs the following actions:
– Calculates the sum of the digits (in our example 2+0+1+1 = 4).
– Prints on the console the number in reversed order: dcba(in our example 1102).
– Puts the last digit in the first position: dabc(in our example 1201).
– Exchanges the second and the third digits: acbd(in our example 2101).










5.Write C# Program to Find Minimum and Maximum of Numbers

//min&max num

using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] Arr = { 22, -15, -43, 0, 28, 42, 35 };
        Console.WriteLine("Maximum Element : " + Arr.Max());
        Console.WriteLine("Minimum Element : " + Arr.Min());
        Console.Read();
    }
}




6.Write a C# program to print all negative elements in an array

//neg elementarry

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int[] arr = new int[6];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of negative numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}


7.Write C# program to print all unique element in an array

//uniq elementarry

static void Main(string[] args)
{
    int[] items = { 3, 5, 4, 2, 6, 8, 9 };
    int n = items.Length;

    Console.WriteLine("Unique array elements: ");

    for (int i = 0; i < n; i++)
    {
        bool isDuplicate = false;
        for (int j = 0; j < i; j++)
        {
            if (items[i] == items[j])
            {
                isDuplicate = true;
                break;
            }
        }

        if (!isDuplicate)
        {
            Console.WriteLine(items[i]);

        }
    }

    Console.ReadLine();
}


8.Write C# program to copy all elements of one array to another

//one to another arry

using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100];

        int[] first = new int[100];
        int[] second = new int[100];

        int i, num;

        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < num; i++)
        {
            first[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < num; i++)
        {
            second[i] = first[i];
        }

        Console.WriteLine("Elements of first array are:");
        for (i = 0; i < num; i++)
        {
            Console.Write(first[i] + "\t");
        }

        Console.WriteLine("\nElements of second array are:");
        for (i = 0; i < num; i++)
        {
            Console.Write(second[i] + "\t");
        }

        Console.ReadLine();
    }

}


9.Write C# program to merge two sorted array

//merge two stored arry

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int i = 0;
        int j = 0;

        int[] arr1 = new int[5] { 5, 6, 8, 10, 30, 45 };

        int[] arr2 = new int[5] { 60, 66, 75, 89, 96 };

        int[] merged = new int[10];

        for (i = 0, j = 0; i < 5; i++)
        {
            merged[j++] = arr1[i];
        }
        for (i = 0; i < 5; i++)
        {
            merged[j++] = arr2[i];
        }
        Console.WriteLine("Elements of merged array = ");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
        }
        Console.WriteLine();
    }
}


10.Write C# Program to Find the Average Values of all the Array Elements

//average value

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program
{
    public void sumAverageElements(int[] arr, int size)
    {

        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }
        average = sum / size;
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        int size;
        Console.WriteLine("Enter the Size :");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = a.Length;
        program pg = new program();
        pg.sumAverageElements(a, len);
    }
}



11.Write a program in C# Sharp to find the second largest element in an array

//second large element

using System;  
public class Exercise16
{
    public static void Main()
    {
        int n, i, j = 0, lrg, lrg2nd;
        int[] arr1 = new int[50];

        Console.Write("\n\nFind the second largest element in an array :\n");


        Console.Write("Input the size of array : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        lrg = 0;

        for (i = 0; i < n; i++)
        {
            if (lrg < arr1[i])
            {
                lrg = arr1[i];
                j = i;
            }
        }

        lrg2nd = 0;
        for (i = 0; i < n; i++)
        {
            if (i == j)
            {
                i++;
                i--;
            }
            else
            {
                if (lrg2nd < arr1[i])
                {
                    lrg2nd = arr1[i];
                }
            }
        }

        Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
    }
}


12.Write a C# function to find whether a given number is prime. It should returns a Boolean true if the number if prime, else returns Boolean false

//boolean number

using System;
public class funcexer9
{
    public static bool chkprime(int num)
    {
        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
    public static void Main()
    {
        Console.Write("\n\nFunction : To check a number is prime or not :\n");

        Console.Write("Input a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (chkprime(n))
            Console.WriteLine(n + " is a prime number");
        else
            Console.WriteLine(n + " is not a prime number");
    }
}



13.Write C# function to find position of the first prime number in a given array. Use the above function to decide a number is prime or not.

//prime number

using System;

class GFG
{

    static readonly int limit = 1000000;
    static int[] position = new int[limit + 1];


    static void sieve()
    {

        position[0] = -1;
        position[1] = -1;
        int pos = 0;

        for (int i = 2; i <= limit; i++)
        {

            if (position[i] == 0)
            {

                position[i] = ++pos;

                for (int j = i * 2; j <= limit; j += i)
                    position[j] = -1;
            }
        }
    }


    public static void Main(String[] args)
    {
        sieve();
        int n = 11;
        Console.Write(position[n]);
    }
}





14.Write C# function to find biggest prime number in a given array.

//biggest gvn arry

using System;
 
class MyProgram
{
    static long MaxPrime(long num)
    {
        long CurrMaxPrime = -1;

        if (num % 2 == 0)
        {
            CurrMaxPrime = 2;
            while (num % 2 == 0)
            {
                num = num / 2;
            }
        }

        for (long i = 3; i <= Math.Sqrt(num); i += 2)
        {
            while (num % i == 0)
            {
                CurrMaxPrime = i;
                num = num / i;
            }
        }

        if (num > 2)
            CurrMaxPrime = num;

        return CurrMaxPrime;
    }

    static void Main(string[] args)
    {
        long x, y, z;
        x = 42;
        y = 1092;
        z = 695467363456;

        Console.WriteLine("Largest prime factor of " + x
                           + " is: " + MaxPrime(x));
        Console.WriteLine("Largest prime factor of " + y
                           + " is: " + MaxPrime(y));
        Console.WriteLine("Largest prime factor of " + z
                           + " is: " + MaxPrime(z));
    }
}

15.Modify Q2 to so that it returns both the position and also the number
 

