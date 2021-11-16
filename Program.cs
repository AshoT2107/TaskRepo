using System;

namespace Task
{
    class Program
    {
        static bool Number(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            key:
            Console.Write("please,input the text=");
            
            var word = Console.ReadLine();
            
                var res = Number(word);
                if (res)
                {
                    var number = int.Parse(word);
                    if (Mersenne(number))
                    {
                        Console.WriteLine("it is Mersenne prime number");
                    }
                    bool IsPrime = true;
                    for (int i = 2; i < number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                    }
                    
                    if (IsPrime)
                    {
                        Console.Write("it is a regular prime number");
                    }
                
                    else
                    {
                        Console.Write("it is not a prime number");
                    }
                }
                else
                {
                    if (word != "quit") 
                    {
                        Console.WriteLine("Invalid Number");
                        goto key;
                    }
                       
                    if (word == "quit")
                        Environment.Exit(0);
                }
            
        }
        static bool Mersenne(int n)
        {
            while (n != 0)
            {
                int r = n % 2;
                if (r == 0)
            return false;
                n /= 2;
            }
            return true;
        }
    }
}
