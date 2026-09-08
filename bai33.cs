/**Mục tiêu:** Áp dụng vòng lặp `for`/`while`
**Yêu cầu (Requirements):**
  1. Nhập vào số nguyên dương N.
  2. Viết hàm `IsPrime(int n)` kiểm tra N có phải Số Nguyên Tố không
  3. Viết hàm `IsPerfectNumber(int n)` kiểm tra N có phải Số Hoàn Hảo không
  4. In ra N số đầu tiên của dãy số Fibonacci.
**TestCases Kiểm thử:**
  - Input: N = 6.
  - Output: 6 là Số hoàn hảo! 6 KHÔNG là Số nguyên tố. Dãy Fibonacci 6 số: `0, 1, 1, 2, 3, 5`.*/

using System;

class Program
{
    static bool isPrime(int n)
    {
        bool check = true;
        if (n < 2)
        {
            check = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            }
        }
        return check;
    }


    static bool isPerfectNumber(int n)
    {
        if(n < 1)
        {
            return false;
        }
        else
        {
            int sum = 0;
            for(int i = 1; i <= n/2;i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap vao 1 so nguyen duong N :");
        int N = int.Parse(Console.ReadLine());
        if(isPerfectNumber(N) == true)
        {
            Console.WriteLine($"{N} la so hoan hao");
        }
        else
        {
            Console.WriteLine($"{N} khong la so hoan hao");
        }

        if(isPrime(N) == true)
        {
            Console.WriteLine($"{N} la so nguyen to");

        }
        else
        {
            Console.WriteLine($"{N} khong la so nguyen to");
        }

        int a = 0, b = 1;
        Console.Write("Day fibonaci " + N + " so dau la: ");
        for(int i = 0; i < N; i++)
        {
            Console.Write(a );
            int next = a + b;
            a = b;
            b = next;
        }

    }
}