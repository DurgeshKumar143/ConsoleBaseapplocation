using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {

            //Directory.CreateDirectory("d:/5th/Durgesh");
            //Console.WriteLine("Folder created successfully");
            // Console.ReadKey();
            //string FolderName;
            //Console.Write("Enter name of the Folder ");
            //FolderName = Console.ReadLine();
            //if (Directory.Exists($"d:/5th/{FolderName}") == false)
            //{
            //    Directory.CreateDirectory($"d:/5th/{FolderName}");
            //    Console.Write("Folder created successfully");
            //}
            //else
            //{
            //    Console.Write("Directory already exixts with same same name");
            //    Console.ReadKey();
            //}

            //for(int x = 1; x <= 2000; x++)
            //{
            //    string fname = Path.GetRandomFileName();
            //    Directory.CreateDirectory($"d:/5th/hello/hey/{fname}");
            //    Console.WriteLine($"Directory created successfully with name {fname}");
            //}
            //Directory.Delete("d:/5th/hello/hey");
            //string[] arr = Directory.GetDirectories("d:/5th/hello/hey");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    string folder_name_with_path = arr[i];
            //    Directory.Delete(folder_name_with_path);

            //bool b = File.Exists("d:/5th/hello/hey/ram.jpeg");
            //if (b == true)
            //{
            //    File.Delete("d:/5th/hello/hey/ram.jpeg");
            //    Console.WriteLine("File deleted successfully");
            //}
            //else
            //{
            //    Console.Write("File not Exits");

            //    Console.ReadKey();
            //}

            // find the max number from thre number
            //int num1, num2, num3;
            //Console.WriteLine("Enter the first number");
            //num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //num2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third number");
            //num3=int.Parse(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine($"Your max value is {num1}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your max value is {num2}");
            //    }
            //}else if(num2> num3)
            //{
            //    Console.WriteLine($"Your max value is {num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Your max value is {num3}");
            //}


            // Check number of day
            //int dayno;
            //Console.Write("Enter the day Number");
            //dayno = int.Parse(Console.ReadLine());
            //switch (dayno)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day Number");
            //        break;
            //}


            // WAP to read any two number from the user and perform arithmatic operation using switch case statement
            //int num1, num2, resuilt;
            //Console.Write("Enter the first number: ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: "); 
            //num2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Choose an operation (+, -, *, /): ");
            // int opration=int.Parse(Console.ReadLine());
            //switch (opration)
            //{
            //    case 1:
            //        Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"The subtraction of {num1} and {num2} is : {num1-num2}");
            //        break;
            //        case 3:
            //        Console.WriteLine($"The multiple value of {num1} and {num2}. is {num1*num2}");
            //        break;
            //        case 4:
            //        Console.WriteLine($"The dividen value of {num1} and {num2} is {num1 / num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalided choick");
            //        break;

            //}

            // WAP to read a number from the user and print table of that number using for loop

            //int num1;
            //Console.Write("Enter the number: ");
            //num1 = int.Parse(Console.ReadLine());
            //for(int i=1;i<=num1;i++)
            //{
            //    Console.WriteLine($"{num1} * {i} = {num1 * i}");
            //}


            // find the root of quadratic equation
            //int a, b, c, root;
            //double det,root1,root2;
            //Console.Write("Enter the coefficients a, b, and c: ");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            // det = (b * b) - (4 * a * c);
            //det=Math.Sqrt(det);
            //Hello hl = new Hello();
            //int sum = hl.add(78, 12);
            //Console.WriteLine(sum);

            //string friend = "Hello i am Durgesh kumar";
            //foreach(char c in friend)
            //{
            //    Console.WriteLine(c);
            //}

            //int[] arr = { 74, 8, 52, 89, 145, 23, 98, 69, 41, 54, 785 };
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}



            // Write the program to display table from 2 to 20
            //for(int i = 1; i <= 20; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //        Thread.Sleep(1000);

            //    }
            //    Console.Write("\t");
            //}

            // WAP to create a small computer virus 

            //DriveInfo[] di1 = DriveInfo.GetDrives();
            //int count1,count2;
            //count1 = di1.Length;
            //for (int x=1; ; x++)
            //{
            //    DriveInfo[] di2 = DriveInfo.GetDrives();
            //    count2= di2.Length;
            //    if (count2 > count1)
            //    {
            //        //Console.WriteLine($"Drive {di2[count2 - 1].Name} was added");
            //        Process.Start("Shutdown.exe")
            //        break;
            //    }
            //}



            //int[] mynums = new int[10];
            //for(int i=0;i<mynums.Length;i++)
            //{
            //    Console.WriteLine($"Enter the data in {i+1} index ");
            //    mynums[i] = int.Parse(Console.ReadLine());

            //}
            //// show array value
            //for(int i=0;i< mynums.Length;i++)
            //{
            //    Console.WriteLine($"Item are {mynums[i]}");
            //}


            // WAP to find of 8 floating point  number use Array.
            float[] flt = new float[8];
            float  avg=0,sum=0;
            //for (int i = 0; i < flt.Length; i++)
            //{
            //    Console.WriteLine($"Enter the {i + 1} number: ");
            //    flt[i] = float.Parse(Console.ReadLine());
            //    sum+=flt[i];


            //}
            // Array.Sort(flt);

            //avg=sum/flt.Length;

            // Console.WriteLine($"Your all the number average is  {avg}");

            //for(int i=0;i<flt.Length;i++)
            //{
            //    Console.WriteLine($"Arrays item is{flt[i]}");
            //}



            //int[] ar = new int[8];
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.WriteLine($"Enter the {i + 1} number: ");
            //    ar[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter a number to search ");
            //int search = int.Parse(Console.ReadLine());

            //int r=Array.IndexOf(ar, search);
            //if (r == -1)
            //{
            //    Console.WriteLine("Number not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Number found at index {r}");
            //}


            /*int[,] arr = new int[3,3];

            for(int i=0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter the value for [{i},{j}] : ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }*/

            // print the matrix value

            //for(int i = 0; i < arr.GetLength(0); i++)
            // {
            //     for (int j = 0; j < arr.GetLength(1); j++)
            //     {
            //         Console.Write($"{arr[i, j]} ");
            //     }
            //     Console.WriteLine();
            // }


            //string str, mystr="";
            //Console.Write("Enter a string: ");
            //str = Console.ReadLine();
            //Console.WriteLine($"Your entered string is {str}");
            //Console.WriteLine($"Uppercase of string is {str.ToUpper()} ");
            //Console.WriteLine($"Lowercase of strng is {str.ToLower()}");
            //Console.WriteLine($"Number of charecter in string {str.Length}");
            //str = mystr.Insert(5,"Hello");
            //Console.WriteLine($"After insertion new String is {str}");

            //string str, searchWord;
            //bool result;
            //Console.Write("Enter a string: ");
            //str = Console.ReadLine();
            //Console.Write("Enter a word to search: ");
            //searchWord = Console.ReadLine();
            //result = str.Contains(searchWord);
            //if(result )
            //{
            //    Console.WriteLine($"{searchWord} is found in the given string.");
            //}
            //else
            //{
            //    Console.WriteLine("Search word is not found");
            //}


            //// make the a program in the program to search value using indexof method

            //string str,searchValue;

            //int num;
            //Console.Write("Enter a string: ");
            //str = Console.ReadLine();
            //Console.Write("Enter a word to search: ");
            //searchValue = Console.ReadLine();
            //num=str.IndexOf(searchValue);
            //if(num==-1)
            //{
            //    Console.WriteLine("Search word is not found");
            //}
            //else
            //{
            //    Console.WriteLine("Search world find ");
            //}

            // make a program to find number of word in the sentence
            string str;
            Console.Write("Enter a sentence: ");
            str = Console.ReadLine();
            //string[] words = str.Split(' ');
            //Console.WriteLine($"Number of words in the sentence is {words.Length}");
            int count = 0;

            for(int i=0;i<str.Length;i++)
            {
                char c = str[i];
                if(c=='-' || c=='.' || c=='?' || c=='|' || c==' ')
                {
                    count++;

                } 
            }
            Console.WriteLine($"Number of words in the sentence is {count}");












            Console.ReadKey();

            


 

        }
    }
}
