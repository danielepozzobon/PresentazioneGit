namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciao!");
            Console.WriteLine("Come ti chiami?");
            var nome = Console.ReadLine();
            Console.WriteLine($"Ciao, {nome}!");
        }
    }
}
