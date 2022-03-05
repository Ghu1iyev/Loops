using System;

namespace AP204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 246;
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
            
            
        }
    }
}
