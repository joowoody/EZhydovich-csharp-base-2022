    using System.Threading.Channels;
    using Calculator;

    bool c;
    int b;
    do
    {
        Console.Write("\n Write a number to convert: ");
        c = int.TryParse(Console.ReadLine(), out b);
        
    } while (b < 0 || c ==false);

    
    Calculator.Converter.ConvertTo(b);

























    // int timeVar;
            // string result = ""; //Результат
            // int.TryParse(Console.ReadLine(), out int tryParseValue);
            
    // while (tryParseValue != 0)
    // {
        // timeVar = tryParseValue % 16;
        // tryParseValue = tryParseValue / 16;
        
         // if (timeVar <= 9)
        // {
            // result += timeVar;
        // }
        // else if (timeVar == 10)
        // {
            // result += "A";
        // }
        // else if (timeVar == 11)
        // {
            // result += "B";
        // }
        // else if (timeVar == 12)
        // {
            // result += "C";
        // }
        // else if (timeVar == 13)
        // {
            // result += "D";
        // }
        // else if (timeVar == 14)
        // {
            // result += "E";
        // }
        // else if (timeVar == 15)
         // {
             // result += "F";
         // }
         

    // }


    


    // int.TryParse(Console.ReadLine(), out int tryParseValue2);
    // string result2="";
            // while (true)
            // {
               // result2 += tryParseValue2 % 2; //остаток от деления. 
                // tryParseValue2 = tryParseValue2 / 2; 
                // if (tryParseValue2 == 0)
                    // break;
            // }
  
            
    
            

    
            
            