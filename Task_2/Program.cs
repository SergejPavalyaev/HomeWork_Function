namespace Task_2
{
    public class Program
    {
        public static void Main (string [] args){
            //Задайте массив заполненный случайными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            int limitMin = 100;
            int limitMax = 999;
            int size = 7;
            int count = 0;
            int [] array = InitArrayRand(size, limitMin, limitMax);
            count = CountParity(array);
            System.Console.WriteLine($"Count item of parity = {count}");
        }
        public static int CountParity (int [] array){
            int count = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) count++;
            }
            return count;
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
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
            return array;
        }
    }
}