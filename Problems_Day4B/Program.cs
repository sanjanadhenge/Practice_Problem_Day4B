﻿namespace Problem_Day4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i= 0; i < 8;i++)
            {
                for(int j=8;j>i;j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");    
            }
        }
    }
}
