// See https://aka.ms/new-console-template for more information

internal class Massive
{
    public static void Main(string[] args)
    {
        string str;
        bool VariableForTryParse;
        int timeVariable2 = 0,
            minValueOfArray,
            maxValueOfArray,
            arrayValue,
            meaning,
            timeVariable;


        while (true)
        {


            Console.WriteLine("\n To exit, type Exit. Otherwise, press any key to create an array");
            str = Console.ReadLine();

            if (str.ToLower() == "exit")
            {
                return;
            }

            Console.WriteLine("\n Enter the array size no more than 20 and no less than 0:");


            VariableForTryParse =
                int.TryParse(Console.ReadLine(), out arrayValue); //Переменная которая задает размер массива

            if (VariableForTryParse == false || arrayValue > 20 || arrayValue <= 0)
            {
                Console.WriteLine("Incorrect value");
            }
            else
            {
                var array = new int[arrayValue]; //Задаем размер массива
                Console.WriteLine("Initializing the array:");
                for (int i = 0; i < array.Length; i++)
                {
                    do
                    {
                        
                        VariableForTryParse = int.TryParse(Console.ReadLine(), out meaning);
                    } while (VariableForTryParse == false);

                    array[i] = meaning; //Присваиваем значение каждой ячейки массива
                }

                Console.WriteLine("\n Your array:");
                foreach (var n in array)
                {
                    Console.Write(n + " ");// Вывод массива
                } 

                for (int i = 0; i < array.Length - 1; i++) //сортировка
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            timeVariable = array[i];
                            array[i] = array[j];
                            array[j] = timeVariable;
                        }


                    }
                }

                Console.WriteLine("\n Array sort:");
                
                timeVariable = 1;

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                    Console.WriteLine();

                    timeVariable2 = timeVariable2 + array[i]; // сумма элементов
                    timeVariable = timeVariable * array[i]; // умножение элементов
                }

                Console.WriteLine("Sum of all array elements: " + timeVariable2);
                Console.WriteLine("Multiplexing of all array elements: " + timeVariable);
                
                minValueOfArray = array[0];
                for (int i = 1; i < array.Length; i++) // минимальный элемент
                {
                    if (array[i] < minValueOfArray)
                    {
                        minValueOfArray = array[i];
                    }

                }

                Console.WriteLine("\n Min value of array: " + minValueOfArray);

                maxValueOfArray = array[0];
                for (int i = 1; i < array.Length; i++) // максимальный элемент
                {
                    if (array[i] > maxValueOfArray)
                    {
                        maxValueOfArray = array[i];
                    }
                }

                Console.WriteLine("\n Max value of array: " + maxValueOfArray);
                
                int temp;
                int b = 0;
                int length = array.Length - 1;
                while (b < length)
                {
                    temp = array[b];
                    array[b] = array[length];
                    array[length] = temp;
                    b++;
                    length--;
                }

                Console.WriteLine("\n Reversed array:");
                foreach (var n in array)
                {
                    Console.Write(n + " ");// Вывод массива
                }
                Console.WriteLine();
                Console.WriteLine("Add element by index");
                int index = 0, value = 0;
                do
                {
                    Console.WriteLine("value");
                    VariableForTryParse = int.TryParse(Console.ReadLine(), out value);
                } while (VariableForTryParse == false);
                
                do
                {
                    Console.WriteLine("The index must not exceed the array dimension by more than 1 unit. " +
                                      "Dimension of array: " + array.Length);
                    VariableForTryParse = int.TryParse(Console.ReadLine(), out index);
                } while (VariableForTryParse == false 
                         || index >= array.Length + 1 
                         || index < 0);

                int[] newArray = new int[array.Length + 1];
                newArray[index] = value;
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }

                for (int i = index; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i];
                }

                array = newArray;

                Console.WriteLine();
                foreach (var n in array)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
                
                do
                {
                    Console.WriteLine("Which element index to remove? " +
                                      "Dimension of array: " + array.Length);
                    VariableForTryParse = int.TryParse(Console.ReadLine(), out index);
                } while (VariableForTryParse == false 
                         || index >= array.Length 
                         || index < 0);
                
                int[] newArray2 = new int[array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray2[i] = array[i];
                }

                for (int i = index + 1; i < array.Length; i++)
                {
                    newArray2[i - 1] = array[i];
                }

                array = newArray2;

                Console.WriteLine();
                foreach (var n in array)
                {
                    Console.Write(n + " ");
                }



            }
        }



    }



}



    
