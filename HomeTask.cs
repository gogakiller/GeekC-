using System;

public class HomeTask
{
    public static void first(int m, int n){
        if (m <= n){
            Console.Write(m + " ");
            first(m + 1, n);
        }
    }
    public static int second(int n, int m)
    {
        if (n == 0) return m + 1;
        if (m == 0) return second(n - 1, m);
        return second(n - 1, second(n, m - 1));
    }
    public static void third(int [] array, int start, int end){
        if (end >= start) {
            Console.Write(array[end] + " ");
            third(array, start, end - 1);
        }
    }
    public static void Main(string[] args)
    {
        // Задание 1
        first(3, 5);
        Console.WriteLine();
        
        
        //Задание 2
        Console.WriteLine(second(2, 5));
        
        
        //Задание 3
        Random rd = new Random(); //Объявляем генератор. 
        int[] i = new int[20]; //Создаем массив. 
        for (int j = 0; j < i.Length; j++) 
        { 
            i[j] = rd.Next(2, 9); //Присваиваем элементам массива случайные числа от 2 до 9. 
        }
        third(i, 0, i.Length - 1);
    }
}