using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool MenuSystem = true;                            
            while (MenuSystem)
            {
                MenuSystem = MainMenu();
            }
        }
        private static bool MainMenu()
        {

            Console.Clear();
            Console.Write("\n\n");
            Console.WriteLine("\tWelcome to Lexicon\t\t\t \n\tProgramming Preparatory Assignment\n");
            Console.Write("\t----------------------------------");

            Console.WriteLine("\r\n\t Here are 16 tasks in this program");
            Console.Write("\t----------------------------------\n");
            Console.WriteLine("\t[1] Print HELLO World");
            Console.WriteLine("\t[2] Function Input");
            Console.WriteLine("\t[3] Function Color");
            Console.WriteLine("\t[4] Print Date");
            Console.WriteLine("\t[5] Function Input large value");
            Console.WriteLine("\t[6] Function Guessing number game");
            Console.WriteLine("\t[7] Function Import data");
            Console.WriteLine("\t[8] Function Export data");
            Console.WriteLine("\t[9] Function Decimal into root");
            Console.WriteLine("\t[10] Function Multiplication with Tab");
            Console.WriteLine("\t[11] Function Arrays");
            Console.WriteLine("\t[12] Function Palindrom");
            Console.WriteLine("\t[13] Function Print all number between");
            Console.WriteLine("\t[14] Function Sort");
            Console.WriteLine("\t[15] Function Addition");
            Console.WriteLine("\t[16] Function Random value");
            Console.WriteLine("\n\t[0] Exit");
           
            Console.Write("\r\n\t[Select an Option] - [Value from 1 to 16] For Test tasks.\r\n\t\t Press \t[0] To Exit program. ");
            Console.ForegroundColor= ConsoleColor.Gray;
            


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\r\n Descirption of Task 1 :Print Hello World. ");
                    Console.WriteLine("\r\n Hello World!");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to Main Menu");
                    Console.ReadLine();
                    
                    return true;
                    
                case "2":
                    Console.WriteLine("\r\nDescirption of Task 2 : Input from User. ");

                    Console.Write("Please, Enter your First Name: ");
                    string myFirstName;
                    myFirstName = Console.ReadLine();
                    
                    Console.Write("Please, Enter your Last Name: ");
                    string myLastName;
                    myLastName = Console.ReadLine();
                    
                  
                    Console.Write("Please, Write your age: ");
                    string Age;
                    Age = Console.ReadLine();
                    
                    Console.WriteLine();
                    Console.WriteLine("\r\nFirst Name:" + myFirstName +"\r\nLast Name:"+myLastName+"\r\nAge :"+Age+
                                      "\r\n\r\nPress Enter to Main Menu");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Gray;

                    return true;


                case "3":

                    Console.ForegroundColor = ConsoleColor.Green;

                    return true;

                case "4":

                    Console.Write("\r\n\tCurrent Date and Time is : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    DateTime now = DateTime.Now;
                    Console.WriteLine(now);
                    
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\tPress Enter to Main Menu");
                    
                    Console.ReadLine();

                    return true;
               
                case "5":
                    Console.Write("\tPlease Enter First Number: ");
                    int number1st = int.Parse(Console.ReadLine());

                    Console.Write("\tPlease Enter Second Number: ");
                    int number2nd = int.Parse(Console.ReadLine());

                    var greatnum = (number1st > number2nd) ? number1st : number2nd;
                    Console.WriteLine("\tGreatest Number: " + greatnum);
                    Console.ReadLine();

                   
                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();

                    return true;

                case "6":

                    Random rand = new Random();
                    int guess = 0;
                    string guessnumber = "\tPlease Guess a number from range 1 and 100";
                    int num = rand.Next(1, 100);
                    Console.WriteLine(guessnumber);


                    int i = 0;

                    while (guess != num)
                    {
                        try
                        {
                            guess = Convert.ToInt32(Console.ReadLine());

                            if (guess > num)
                            {
                                Console.WriteLine("\tThe number is too High");
                            }
                            else
                            {
                                Console.WriteLine("\tThe number is too Low");
                            }
                        }

                        catch
                        {
                            Console.WriteLine("\tGuess must be in a range from 1 to 100");
                            i--;
                        }


                        i++;
                    }
                    Console.WriteLine("\r\n\tGreat ! You Guessed correctly, \r\n\tYou took " + i + " Number of Attempts");
                    Console.ReadLine();
                 
                    Console.WriteLine("Press Enter to Main Menu");
                    Console.ReadLine();

                    return true;

                case "7":
                    
                    try
                    {
                    
                        StreamWriter lexicon = new StreamWriter("E:\\Lexicon.txt");
                        
                        lexicon.WriteLine("\tAssignment - .NET Preparatory course - Visula Studio 2019");
                        lexicon.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception can be: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                    Console.WriteLine("Press Enter to Main Menu");
                    Console.ReadLine();
                    return true;

                case "8":

                    String line;
                    try
                    {
                       
                        StreamReader lexicon = new StreamReader("E:\\Lexicon.txt");
                        line = lexicon.ReadLine();
                        while (line != null)
                        {
                        Console.WriteLine(line);
                        line = lexicon.ReadLine();
                        }
                        
                        lexicon.Close();
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();
                    return true;

                case "9":

                    Console.WriteLine("\tEnter a Number:");
                    double Number = Convert.ToInt16(Console.ReadLine());
                    double SqrtNumber = Math.Sqrt(Number);
                    Console.Write("\n\tSquare root of Number : " + Math.Sqrt(Number));
                    
                    double pow = Math.Pow(Number,2);
                    double pow1 = Math.Pow(Number, 10);
                    Console.Write("\n\tSqrt raised to 2 : " + Math.Pow(Number,2));
                    Console.Write("\n\tSqrt raised to 10 : " + Math.Pow(Number, 10));
                    Console.ReadLine();

                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();

                    return true;

                case "10":
                   
                    Console.Write("\n\n");
                    int row, column, value, columnmax, rowmax;
                    row = 1;
                    
                    columnmax = 10;
                    rowmax = 10;
                    
                    Console.WriteLine("    Multiplication Table 1-10   ");
                    Console.WriteLine("\t--------------------------------------------------------------------------");
                    
                    do
                    {
                        column = 1;
                        do
                        {
                            value = row * column;
                           
                            Console.Write("\t" + value);
                            column += 1;
                        }
                        while (column <= columnmax);
                       
                        Console.WriteLine();
                        row += 1;
                    }
                    while (row <= rowmax);
                    Console.WriteLine("\t---------------------------------------------------------------------------");
                    
                   
                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();
                    return true;

                case "11":

                    
                    int[] list = new int[] { 5, 6, 2, 3, 4, 1 };
                   
                    foreach (int x in list)
                       
                    Console.WriteLine("["+ x +"]"); 
                    Console.ReadLine();

              
                    Array.Sort(list); 
                    foreach (int y in list)
                    Console.WriteLine("[" + y + "]");
                    Console.ReadKey();


                    return true;

                case "12":

                    string pd, reverse = "";
                    Console.WriteLine("\tPlease Enter a WORD");
                    pd = Console.ReadLine();
                    for (int p = pd.Length - 1; p >= 0; p--) 
                    {
                        Console.WriteLine(p);
                        reverse += pd[p].ToString();
                    }
                    if (reverse == pd) 
                    {
                        Console.WriteLine("\tYES! WORD is a  Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("\tNO! WORD is not a Palindrome");
                    }
                    Console.ReadKey();

                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();
                    return true;

                case "13":

                    Console.WriteLine("\tWrite the first number:");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\tWrite the second number:");
                    int second = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine($"\tThe Result is {first}{second}");
                   
                    
                    Console.WriteLine("\tPress Enter to Main Menu");
                    Console.ReadLine();
                    return true;

                case "14":

                    Console.WriteLine("Please, Enter value from 1 to 10: ");
                    int[] number = new int[10];
                    for (int i = 0; i < number.Length; i++)

                    {
                        number[i] = int.Parse(Console.ReadLine());

                        if (number[i] == 0)
                        {
                            Console.WriteLine("Zero- 0 is not allowed to enter");
                           
                        }
                    }

                    
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] % 2 == 0)
                        {
                            Console.Write("{0} ", number[i]);
                        }
                    }

                    
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] % 2 != 0)
                        {
                            Console.Write("{0} ", number[i]);

                            return true;


                            

                case "15":


                    int[] nums = { 1, 2, 3, 4, 5, 6 };
                    var str = String.Join(",", nums);
                    
                    Console.WriteLine(str);
                    Console.WriteLine(nums.Sum());
                    Console.ReadLine();
                    return true;

                case "16":

                  

                    return true;

                case "0":
                    return false;
                default:
                    return true;
                    
            }

        }

       
        }
    }

    
