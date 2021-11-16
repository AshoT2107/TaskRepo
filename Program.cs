using System;

namespace Task
{
    class Program
    {
        static bool isNumber(string s)
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
            
                var res = isNumber(word);
                if (res)
                {
                    var number = int.Parse(word);
                    if (isMersenne(number))
                    {
                        Console.WriteLine("Mersenna");
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
                        Console.Write("Number is Prime.");
                    }
                
                    else
                    {
                        Console.Write("Number is not Prime.");
                    }
                }
                else
                {
                    if (word != "quit")
                            goto key;
                    if (word == "quit")
                        Environment.Exit(0);
                }
            
        }
        static bool isMersenne(int n)
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
