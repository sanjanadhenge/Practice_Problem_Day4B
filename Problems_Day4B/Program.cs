namespace Problem_Day4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int[,] matrixA = new int[3,3];
            for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    matrixA[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixA[i,j] +"\t"); 
                }
                Console.Write("\n");
            }
            Console.WriteLine("sum of each row ====>");
            
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                   sum += matrixA[i, j];
                }
                Console.WriteLine("Sum of Row {0} is {1} ",i,sum);
            }
        }

       

       
    }
}



