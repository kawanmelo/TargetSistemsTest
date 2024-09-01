class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        List<int> list = Program.CalculateFibonacciNumbers(num);
        if (list.Contains(num))
        {
            Console.WriteLine("O número pertence a sequencia de Fibonacci!");
        }
        else
        {
            Console.WriteLine("O número não pertence a sequencia de Fibonacci!");
        }
        
    }

    // Calculate the fibonacci sequence in range 0 - max.
    public static List<int> CalculateFibonacciNumbers(int max)
    {
        List<int> fibonacciSequence = new List<int> { 0, 1 };
        int i = 2;

        while (true)
        {
            int nextValue = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            if (nextValue > max)
            {
                break;
            }
            fibonacciSequence.Add(nextValue);
            i++;
        }
        return fibonacciSequence;
    }
}