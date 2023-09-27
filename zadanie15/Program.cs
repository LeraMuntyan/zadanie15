using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int n = 6;
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 10);
            Console.Write("{0,3} ", arr[i]);
        }
        Console.WriteLine();



        while (HasDuplicates(arr))
        {
     
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (Array.IndexOf(arr, arr[i]) < i)
                {
                   
                    arr[i] *= i;
                }
            }
        }

       
        foreach (int element in arr)
        {
            Console.Write("{0,3} ", element);
        }
        Console.WriteLine();
         Console.WriteLine("Если хотите повторить ввод, введите 1, иначе любую другую цифру.");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Main();
        }
    }

    static bool HasDuplicates(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (Array.LastIndexOf(array, array[i]) > i)
            {
                return true;
            }
        }
        return false;

    }
    
}