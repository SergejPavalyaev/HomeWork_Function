namespace Task_2
{
    public class Program
    {
        public static void Main (string [] args){
            //Задайте массив заполненный случайными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            int limitMin = 100;
            int limitMax = 999;
            int size = 5;
            int [] array = InitArrayRand(size, limitMin, limitMax);
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