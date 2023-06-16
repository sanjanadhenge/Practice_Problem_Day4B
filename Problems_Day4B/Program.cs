namespace Problem_Day4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem = 0;
            while(number != 0)
            {
                rem= number%10;
                sum = sum+rem;
                number = number/10;
            }
            Console.WriteLine("Sum of Digits of given number  is {0} ",sum);
            
            
        }

       

       
    }
}



