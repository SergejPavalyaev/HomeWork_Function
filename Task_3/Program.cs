namespace Task_3
{
    public class Program
    {
        public static void Main (string [] args){
            //Напишите программу, которая перевернёт одномерный массив
            //(первый элемент станет последним, второй – предпоследним и т.д.)
            int limitMin = 10;
            int limitMax = 99;
            int size = 5;
            int [] array = InitArrayRand(size,limitMax,limitMin);
            PrintArray(array);
            array = TurnOverArray(array);
            PrintArray(array);
        }
        public static int [] TurnOverArray (int [] array){
            int size = array.Length;
            int [] turnArray = new int [size];
            for (int i = 0; i < size; i++)
            {
                turnArray [i] = array [size - 1 - i];
            }
            return turnArray;
        }
        public static int [] InitArrayRand (int size, int limitMin, int limitMax){
            int [] array = new int [size];
            Random rand = new Random();
            int temp = limitMax;
            if (limitMin > limitMax)
            {
                limitMax = limitMin;
                limitMin = temp;
            }
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(limitMin, limitMax + 1);
            }
            return array;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }
    }
}