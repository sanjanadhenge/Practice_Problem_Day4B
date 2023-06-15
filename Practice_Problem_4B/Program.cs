namespace Practice_Problems_4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 15,9,65,80,45,6,54 };
            int temp = 0;
            for(int i=0;i<arr.Length; i++)
            {
                for(int j=i;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
               
            }
            Console.WriteLine("Maximum element is " + arr[arr.Length-1]);
            Console.WriteLine("Minimum element is " + arr[0]);

        }
    }
}
