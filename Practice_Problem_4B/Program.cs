namespace Practice_Problems_4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3, 5, 8, 7, 2, 9, 5, 3 };
            int n = arr.Length;
            int j = 0, i = 0, k = 0, ctr = 0;

            int[] b = new int[arr.Length];

            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
          
                for (j = 0; j < i - 1; j++)
                {
                   
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
              
                for (k = i + 1; k < n; k++)
                {
                    
                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }
               
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }
    }
}
