namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(2,2, true);
            Console.WriteLine(answer);
            Console.WriteLine(Methods.Add(0,1,true));
            Console.WriteLine(Methods.Add(10, 10, false));  
             
        }
    }
}
