internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ви ввели число {N}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}