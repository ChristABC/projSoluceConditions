using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Veuillez entrer un nombre qui sera le minimum : ");
        string numberMinAsString = Console.ReadLine();
        int numberMin = Convert.ToInt32(numberMinAsString);

        Console.Write("Veuillez entrer un nombre qui sera le maximum : ");
        string numberMaxAsString = Console.ReadLine();
        int numberMax = Convert.ToInt32(numberMaxAsString);

        Console.Write("Veuillez entrer un nombre entre ces deux valeurs : ");
        string numberChooseAsString = Console.ReadLine();
        int numberChoose = Convert.ToInt32(numberChooseAsString);

        if (numberChoose > numberMax)
        {
            Console.WriteLine("Votre nombre est superieur au maximum !");
        }
        else if (numberChoose < numberMin)
        {
            Console.WriteLine("Votre nombre est inferieur au minimum !");
        }
        else
        {
            Console.WriteLine("Bravo !");
        }
    }
}