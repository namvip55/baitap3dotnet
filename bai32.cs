using System;
/*Mục tiêu: Vận dụng cấu trúc rẽ nhánh if-else if-else đầy đủ, thư viện Math.Sqrt().
Yêu cầu:
Nhập 3 hệ số a, b, c (double).
Xử lý trường hợp a=0 (Phương trình trở thành bậc nhất bx+c=0).
Khi a # 0, tính Δ=b2−4ac: tìm nghiệm.
TestCases Kiểm thử:
 a=1,b=−3,c=2→x1​=2.00,x2​=1.00.
 a=1,b=−2,c=1→ Nghiệm kép x=1.00.
 a=1,b=1,c=1→ Vô nghiệm.*/
class Program
{
    static void Main()
    {
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine()!);

        // Trường hợp a = 0: phương trình bậc nhất
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình có một nghiệm: x = {x:F2}");
            }
        }
        else
        {
            // Phương trình bậc hai
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"Phương trình có hai nghiệm:");
                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine($"Phương trình có nghiệm kép: x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
    }
}