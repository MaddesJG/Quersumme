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
            int length;
            int summe = 0;
            string quer_string;
            try
            {

                Console.Write("Please enter a number: ");
                quer_string = Convert.ToString(Console.ReadLine());
                length = quer_string.Length - 1;
                string[] quer_sub = new string[length + 1];
                int[] summenarray = new int[length + 1];
                for (int i = 0; i <= length; i++)
                {
                    quer_sub[i] = quer_string.Substring(i, 1);

                }

                for (int i = 0; i <= length; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, quer_sub[i]);
                }


                for (int i = 0; i <= length; i++)
                {
                    summenarray[i] = Convert.ToInt32(quer_sub[i]);
                }



                for (int i = 0; i <= length; i++)
                {
                    summe = summe + summenarray[i];
                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Ergebniss: {0}", summe);

                Console.ReadKey();

            }

            catch (FormatException)
            {
                Console.WriteLine("Error");
            }


            catch (OverflowException)
            {
                Console.WriteLine("Error");
            }



        }
    }
}
