using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quersumme
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe;
            int switchcase = 1;
            string quer_string;
            string X = "Y";
        Start:        //start point                 
            do
            {
                try
                {

                    Console.Clear();
                    summe = 0;
                    Console.Write("Please enter a number: ");
                    quer_string = ConvertString();       //call method ConvertString
                    int length = quer_string.Length - 1;
                    int[] summenarray = new int[length + 1];    //create array
                    for (int i = 0; i <= length; i++)
                    {
                        StringMethod(quer_string, summenarray, i);     //call method StringMethod

                    }

                    for (int i = 0; i <= length; i++)
                    {
                        Console.WriteLine("{0}: {1}", i + 1, summenarray[i]);           //write the content of the array in a list
                    }

                    for (int i = 0; i <= length; i++)
                    {
                        summe = summe + summenarray[i];
                    }
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Result: {0}", summe);            //output the result
                    Console.WriteLine("");

                    switch (switchcase)               //switchcase to continue/close the program
                    {
                        case 1:
                            Console.Write("Continue? Y/N: ");
                            X = Console.ReadLine();
                            X = X.ToLower();
                            goto case 2;
                        case 2:
                            if (X.ToLower() == "y" || X.ToLower() == "n")
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Input");
                                goto case 1;
                            }
                        default:
                            Console.WriteLine("Unknown Error");
                            goto case 1;
                    }


                }

                catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Unknown Error! Please restart Brain.exe!");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                goto Start;                   //jumps to Start
                }


            catch (NullReferenceException)                              
            {
                Console.Clear();
                Console.WriteLine("Error! Please dowload more RAM!");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                goto Start;                     //jumps to Start

                }
        } while (X == "y");
            
        }

        private static string ConvertString()
        {
            return Convert.ToString(Console.ReadLine());                        //method converts input into string
        }

        private static void StringMethod(string quer_string, int[] summenarray, int i)
        {
            summenarray[i] = Convert.ToInt32(quer_string.Substring(i, 1));          //method converts strings to int32 and adds them to the array
        }
    }
}