namespace gitC_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            while (true)
            {
                Console.Write("Введіть перше число: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                    break;
                Console.WriteLine("Некоректне введення! Введіть число.");
            }

            while (true)
            {
                Console.Write("Введіть друге число: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                    break;
                Console.WriteLine("Некоректне введення! Введіть число.");
            }

            double sum = num1 + num2;
            Console.WriteLine($"Сума: {sum}");

        }
    }
}
