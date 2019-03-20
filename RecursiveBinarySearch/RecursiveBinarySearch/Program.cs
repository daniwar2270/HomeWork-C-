using System;

class Program
{

    static int BinarySearch(int[] arr, int end, int start, int x, ref int speed)
    {

        if (start >= end)
        {
            int mid = end + (start - end) / 2;


            if (arr[mid] == x)
            {
                speed++;
                return mid;
            }


            if (arr[mid] > x)
            {
                speed++;
                return BinarySearch(arr, end, mid - 1, x, ref speed);
            }
            speed++;
            return BinarySearch(arr, mid + 1, start, x, ref speed);
        }


        return -1;
    }


    public static void Main()
    {

        int[] arr = { 2, 3, 4, 10, 40 };
        int end = arr.Length - 1;
        int x = 10;
        int speed = 0;
        int result = BinarySearch(arr, 0, end, x, ref speed);

        if (result == -1)
            Console.WriteLine("Element not found\nSpeed: {0}", speed);
        else
            Console.WriteLine("Element found at index {0}\nSpeed: {1}", result, speed);

    }
}