// See https://aka.ms/new-console-template for more information
internal class Program
{
 private static void Main(string[] args)
 {
 int number1, number2, total;
 Console.WriteLine("Dona'm número: ");
 number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Dona'm un altre número: ");
 number2 = Convert.ToInt32(Console.ReadLine());
 total = number1 + number2;
 Console.WriteLine("la suma és " + total);
 Console.ReadLine();
 }
}