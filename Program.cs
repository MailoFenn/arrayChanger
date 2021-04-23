using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}};
            int[] sub_arr_up = new int[arr.GetLength(1)];
            int[] sub_arr_down = new int[arr.GetLength(1)];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        sub_arr_up[j] = arr[i, j];
                    }
                    if(i == arr.GetLength(0) - 1)
                    {
                        sub_arr_down[j] = arr[i, j];
                    }
                }
            }

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        arr[i, j] = sub_arr_down[j];
                    }
                    if(i == arr.GetLength(0) - 1)
                    {
                        arr[i, j] = sub_arr_up[j] ;
                    }
                }
            }
        }
    }
}
