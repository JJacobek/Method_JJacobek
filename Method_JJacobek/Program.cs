using System;

namespace Method_JJacobek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();
            try
            {
                Console.WriteLine("Hello {0}!", input);
            }
            catch
            {

            }
        }
        private static void Conditional_Input(int Get_Name)
        { 
                string input = Console.ReadLine();
                int inputs = int.Parse(input);
                if (inputs >= 0 && inputs <= 0)
                {
                    Console.WriteLine("Please enter a valid name");
                }
                else
                {
                    Console.WriteLine("Hello {0}!", input);
                }
        }

    }
}
