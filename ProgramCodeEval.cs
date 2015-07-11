using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodeEvalDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                        
                string[] arr = line.Split();
            
                int fizz = int.Parse(arr[0]);
                int buzz = int.Parse(arr[1]);
                int num = int.Parse(arr[2]);
                //int fizzBuzz = fizz * buzz;
            
                for (int counter = 1; counter <= num; counter++)
                {
                     if (counter % fizz == 0 && counter % buzz == 0)
                     {
                        System.Console.Write("FB ");
                     }
                    else if (counter % fizz == 0)
                    {
                        System.Console.Write("F ");
                    }
                    else if (counter % buzz == 0)
                    {
                        System.Console.Write("B ");
                    }
                    else
                    {
                        System.Console.Write(counter + " ");
                    }  
                }
                System.Console.WriteLine('\n');
                }
        }
    }
}
