namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(2,2, true);
            Console.WriteLine(answer);
        }
    }
}
