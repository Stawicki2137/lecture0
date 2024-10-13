namespace Sandbox;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Mateusz", name2 = "Karolinka";
        for(int i=0; i<10; ++i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Hello, {name1}, {i+15}");
            }
            else
            {
                {
                    Console.WriteLine($"Hello, {name2}");
                }
            }
        }

    }
}