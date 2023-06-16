namespace Problem_Day4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string [] words = str.Split(' ');
            for(int i=0; i<words.Length; i++)
            {
                Reverse(words[i]);
            }
            
        }

       

        public static void Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = str.Length-1; i >=0; i--)
            {
              reverse += chars[i];
            }
            Console.Write(reverse+" ");
        }
    }
}



