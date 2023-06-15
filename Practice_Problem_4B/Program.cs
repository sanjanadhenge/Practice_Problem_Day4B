namespace Practice_Problems_4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3, 5, 8, 7, 2, 9, 5, 3 };
            int n = arr.Length;
            int[] fr1 = new int[n] ;
            for(int m=0;m<n; m++)
            {
                fr1[m] = -1;
            }
            
            int ctr=0,i=0,j=0;
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr[i], fr1[i]);
                }
            }

        }
    }
}
