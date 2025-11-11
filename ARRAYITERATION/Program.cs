using System;

public class ArrayIteration
{

    public static void Main(string[] args)
    {
        var colors = new[] { "Red", "Green", "Blue", "Yellow" };

        Console.WriteLine("--- Using a for loop ---");

        for (int i = 0; i < colors.Length; i++)

        {
            Console.WriteLine($"Index {i} {colors[i]}");

        }

        Console.WriteLine("\n--- Using a foreach loop ---");

        foreach (var color in colors)
        {
            Console.WriteLine("Color: " + color);
        }

    }

}
