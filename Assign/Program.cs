internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        Console.WriteLine("Assign Values:");
        Console.WriteLine("\t a =" + (a = 8));
        Console.WriteLine("\t b =" + (b = 4));
        Console.WriteLine("\n\nAdd and Assign: ");
        Console.WriteLine("\t a += b (8 += 4)\t a =" + (a += b));
        Console.WriteLine("\n\nsubtract and Assign: ");
        Console.WriteLine("\t a -= b (12 -= 4)\t a =" + (a -= b));
        Console.WriteLine("\n\nMultiply and Assign:");
        Console.WriteLine("\t a *= b (8 *=4) \t a=" + (a *= b));
        Console.WriteLine("\n\nDivide and Assign: ");
        Console.WriteLine("\t a /= b (32 /= 4)\t a=" + (a /= b));
        Console.WriteLine("\n\nModulus and Assign: ");
        Console.WriteLine("\t a %= b (8 %= 4)\t a=" + (a %= b));
        Console.ReadKey();
   
    }
}