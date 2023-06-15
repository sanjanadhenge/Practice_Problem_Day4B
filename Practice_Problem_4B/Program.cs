namespace Practice_Problems_4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1,2,1,3,5,8,7,2,9,5,3 };
            int count = 0;
            for(int i=0;i<arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Count for Duplicate elements => "+count);
        }
    }
}
