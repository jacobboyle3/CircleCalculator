public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the length of your room: ");
        decimal length = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width of your room: ");
        decimal width = decimal.Parse(Console.ReadLine());
        decimal area = length * width;
        Console.WriteLine("The area of the room is: {0}", area);
        decimal perimeter = length + width + length + width;
        Console.WriteLine("The perimeter of your room is: {0}", perimeter);
    }
}