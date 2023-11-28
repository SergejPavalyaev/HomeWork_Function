namespace Task_1
{
    public class Program
    {
        public static void Main (string [] args)
        {
            // Напишите программу, которая бесконечно запрашивает целые числа с консоли.
            // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
            System.Console.WriteLine("Input natural number:");
            int number = InputNumber();
            if (number == 0) goto Found;
            // System.Console.WriteLine(number);


            Found:
            System.Console.WriteLine("End program.");
        }

        public static int InputNumber ()
        {
            string input = string.Empty;
            int number = 0;
            bool flag = false;
            bool flag2 = false;
            while (!flag2)
            {
                while (!flag)
                {
                    try
                    {
                    input = System.Console.ReadLine();
                    number = Convert.ToInt32(input);
                    flag = true;
                    }
                    catch (System.Exception)
                    {
                        if (input == "q") 
                        {
                            number = 0;
                            flag = true;
                            flag2 = true;
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Error, input natural number:");
                        }
                    }
                }
            if (number > 0 || flag2)
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Error, input natural number:");
                flag = false;
            }
            }
            return number;
        }
    }   
}