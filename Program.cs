using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter 1 to convert pounds to kilograms OR vice versa by entering 2: ");
        int choice = int.Parse(Console.ReadLine());

        double pWeight, kWeight;
        double kValue = 0.453592;
        double pValue = 2.20462;

        switch (choice)
        {
            case 1:
                Console.Write("Enter weight in pounds: ");
                pWeight = double.Parse(Console.ReadLine());

                kWeight = pWeight * kValue;
                Console.WriteLine($"{pWeight} lbs = {Math.Round(kWeight)} kg");
                break;

            case 2:
                Console.Write("Enter weight in kilograms: ");
                kWeight = double.Parse(Console.ReadLine());

                pWeight = kWeight * pValue;
                Console.WriteLine($"{kWeight} kg = {Math.Round(pWeight)} lbs");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
