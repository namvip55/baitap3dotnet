using System;
/**Mục tiêu:** Áp dụng vòng lặp `for`/`while`
**Yêu cầu (Requirements):**
  1. Nhập vào số nguyên dương N.
  2. Viết hàm `IsPrime(int n)` kiểm tra N có phải Số Nguyên Tố không
  3. Viết hàm `IsPerfectNumber(int n)` kiểm tra N có phải Số Hoàn Hảo không
  4. In ra N số đầu tiên của dãy số Fibonacci.
**TestCases Kiểm thử:**
  - Input: N = 6.
  - Output: 6 là Số hoàn hảo! 6 KHÔNG là Số nguyên tố. Dãy Fibonacci 6 số: `0, 1, 1, 2, 3, 5`.*/
class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n < 1)
            return false;

        int sum = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum == n;
    }

    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;

        Console.Write("Dãy Fibonacci: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a);

            if (i < n - 1)
                Console.Write(", ");

            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Nhập N: ");
        int N = int.Parse(Console.ReadLine()!);

        if (IsPrime(N))
            Console.WriteLine($"{N} là Số nguyên tố.");
        else
            Console.WriteLine($"{N} KHÔNG là Số nguyên tố.");

        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} là Số hoàn hảo.");
        else
            Console.WriteLine($"{N} KHÔNG là Số hoàn hảo.");

        PrintFibonacci(N);
    }
}