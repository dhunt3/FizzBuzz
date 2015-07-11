namespace FizzBuzzDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 3;
            int buzz = 5;
            int fizzBuzz = fizz * buzz;
            int num = 15;
            for (int counter = 1; counter <= num; counter++)
            {
                if (counter % fizzBuzz == 0)
                {
                    //System.Console.Write('\n');
                    System.Console.Write("FB ");
                }
                else if (counter % fizz == 0)
                {
                   // System.Console.Write('\n');
                    System.Console.Write("F ");
                }
                else if (counter % buzz == 0)
                {
                    //System.Console.Write('\n');
                    System.Console.Write("B ");
                }
                else
                {
                    //System.Console.Write('\n');
                    System.Console.Write(counter + " ");
                }
            }
            System.Console.ReadLine();
        }
    }
}
