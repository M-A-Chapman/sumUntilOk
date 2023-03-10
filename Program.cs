namespace sumUntilOk;
class Program
{
    static void Main(string[] args)
    {
        var sum = 0;
        while (true)
        {
            Console.WriteLine("Enter a number or \"ok\" to exit:");
            var input = Console.ReadLine();
            if (input == "ok")
                break;

            sum += Convert.ToInt32(input);
        }
        Console.WriteLine(string.Format("the sum of all numbers is {0}", sum));
    }
}
