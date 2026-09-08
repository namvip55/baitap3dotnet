using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("Nhap vao so thuc a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao so thuc b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao phep toan (+, -, *, /, %): ");
        string op = Console.ReadLine();

        try
        {
            double result = op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" when b == 0 => throw new DivideByZeroException(),
                "/" => a / b,
                "%" when b == 0 => throw new DivideByZeroException(),
                "%" => a % b,
                _ => throw new Exception("Phep toan khong hop le")
            };

            Console.WriteLine($"{a} {op} {b} = {result:f2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Loi khong the chia cho 0!");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }
    }

}