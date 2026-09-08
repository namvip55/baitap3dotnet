using System;
/*
Mục tiêu: Áp dụng switch expression trong C#, pattern matching và bắt ngoại lệ chia cho 0.
Yêu cầu:
Nhập vào số thứ nhất a (double), số thứ hai b (double) và phép toán op (char: +, -, *, /, %).
Sử dụng  để tính kết quả.
Bắt trường hợp phép chia / hoặc % cho 0 để hiển thị thông báo lỗi hợp lệ.
TestCases Kiểm thử:
 a = 10, b = 4, op = '+' →  14.00
 a = 10, b = 0, op = '/' →  "Lỗi: Không thể chia cho 0!"
*/
class Program
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập số thứ hai b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập phép toán (+, -, *, /, %): ");
        char op = Console.ReadLine()![0];

        try
        {
            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' when b == 0 => throw new DivideByZeroException(),
                '%' when b == 0 => throw new DivideByZeroException(),
                '/' => a / b,
                '%' => a % b,
                _ => throw new Exception("Phép toán không hợp lệ!")
            };

            Console.WriteLine($"Kết quả: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}   