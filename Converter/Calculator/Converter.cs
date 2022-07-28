
using System.Diagnostics;

namespace Calculator;

public static class Converter
{
    public static void ConvertTo(int value)
    {
        while(true)
        {
            int number, b;
            bool i;
            do
            {
                Console.WriteLine("\n Choose a number system:");
                Console.WriteLine(" For system 2 write 2");
                Console.WriteLine(" For system 16 write 16");
                Console.WriteLine(" For system 8 write 8");
                Console.WriteLine(" To enter a new number, type 6");
                Console.WriteLine("\n Press 0 to exit");
                i = int.TryParse(Console.ReadLine(), out number);
            } while (i == false);


            switch (number)
            {
                case 2:
                    ReverseStr(ConvertToBin(value));
                    break;
                case 16:
                    ReverseStr(Converter.ConvertToHex(value));
                    break;
                case 8:
                    ReverseStr(Converter.ConvertToOct(value));
                    break;
                case 6:
                    Console.Write("\n Write a number to convert: ");
                    var c = int.TryParse(Console.ReadLine(), out b);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Try Again, incorrect value");
                    break;
            }
        }
    }

    private static void ReverseStr(string str)
        {
            string input = "";
            input = str;
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.Write(output);
        }

    private static string ConvertToBin(int value)
        {
            int valueFromUser = value;
            string result = "";
            while (true)
            {
                result += valueFromUser % 2; //остаток от деления. 
                valueFromUser = valueFromUser / 2;
                if (valueFromUser == 0)
                    break;
            }

            return result;
        }

    private static string ConvertToHex(int value)
        {
            string result = "";
            int valFromUser = value;

            while (valFromUser != 0)
            {
                var timeVar = valFromUser % 16;
                valFromUser = valFromUser / 16;

                if (timeVar <= 9)
                {
                    result += timeVar;
                }
                else if (timeVar == 10)
                {
                    result += "A";
                }
                else if (timeVar == 11)
                {
                    result += "B";
                }
                else if (timeVar == 12)
                {
                    result += "C";
                }
                else if (timeVar == 13)
                {
                    result += "D";
                }
                else if (timeVar == 14)
                {
                    result += "E";
                }
                else if (timeVar == 15)
                {
                    result += "F";
                }

            }

            return result;
        }

    private static string ConvertToOct(int value)
    {
        int valueFromUser = value;
        string result = "";
        while (true)
        {
            result += valueFromUser % 8; //остаток от деления. 
            valueFromUser = valueFromUser / 8;
            if (valueFromUser == 0)
                break;
        }

        return result;
    }
}


    

