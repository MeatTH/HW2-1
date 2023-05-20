using System;

class Program
{
    static void Main(string[] args)
    {
            //pascal();
            
    }
    static void pascal()
    {
        double R = double.Parse(Console.ReadLine());
        while (R < 0)
        {
            if (R < 0)
            {
                Console.WriteLine("Invalid Pascals triangle row number.");
            }
            R = double.Parse(Console.ReadLine());
        }
        for (double i = 0; i <= R; i++)
        {
            for (double j = 0; j <= i; j++)
            {
                double n = factorial(i) / (factorial(j) * factorial(i - j));
                Console.Write(n + " ");
            }
            Console.WriteLine(" ");
        }
    }
    static double factorial(double R)
    {
        double n = 1;
        for (int i = 1; i <= R; i++)
        {
            n = n * i;
        }
        return n;
    }
    
        

        
    }

    



}
