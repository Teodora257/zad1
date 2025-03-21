namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число N от интервала [10..100]: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 10 || N > 100)
            {
                Console.WriteLine("Числото трябва да бъде в интервала [10..100].");
                return;
            }

            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                numbers.Add(random.Next(1, 102)); 
            }

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    evenNumbers.Add(num);
                else
                    oddNumbers.Add(num);
            }

            Console.WriteLine("Четни числа: " + string.Join(" ", evenNumbers));

            oddNumbers.Reverse();
            Console.WriteLine("Нечетни числа: " + string.Join(" ", oddNumbers));
        }
    }
}
