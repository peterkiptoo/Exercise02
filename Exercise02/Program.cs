using System;
using Exercise01;
namespace Exercise02
{
   public class Program
    {

            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter a Number to Convert it to Words:");
                    string number = Console.ReadLine();
                    number = BigIntExtenderLibrary.Towards(double.Parse(number));

                    Console.WriteLine("The Number in Words is: \n{0}", number);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

}
