namespace MMĆwiczenia
{
internal class Program
{
    static string color= "";
    static void Main(string[] args)
    {
        while (color == "")
        {
        Console.WriteLine("Wybierz kolor!");
        color = Console.ReadLine();
            if (color != "blue" && color != "red")
                color = "";
            else
                Console.WriteLine(Colors.Print(color));
    }
    }
    }
}
