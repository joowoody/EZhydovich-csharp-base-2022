// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

internal class Operators
{
    static void Main(string[] args)
    {
        bool HZ;
        int f = 0;
        int d = 0;
        
        while (true)
        {
            Console.WriteLine("Type exit to close the program or start!");
            string str = Console.ReadLine();
            if (str.ToLower() == "exit")
            {
                break;
            }
            else if (str.ToLower() == "start")
            {
                do
                {
                    Console.WriteLine($"Input first number: ");
                    HZ = int.TryParse(Console.ReadLine(), out f);
                } 
                while (HZ == false);
            
                //Console.WriteLine("You entered an incorrect number, please try again"); // String is not a number.
            }

            do
            {
                Console.WriteLine($"Input second number: ");

                HZ = int.TryParse(Console.ReadLine(), out  d);
            } while (HZ == false);

            if(f > d)
            {
                Console.WriteLine("f more d!");
            }

            if (d > f)
            {
                Console.WriteLine("d more f!");
            }
            else if (f == d)
            {
                Console.WriteLine("Number are equal!");

            }

            }
            
        }
        
        }

       
        
    

    
