﻿namespace Problem_Day4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i= 0; i < 7;i++)
            {
               for(int j= 0; j < 7;j++)
                {
                    if(i==0 || i==6 || j==0 || j==6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
               
                Console.Write("\n");    
            }
        }
    }
}
