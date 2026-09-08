using System;
class Program
{
    static void Caculator()
    {
        Console.Write("Nhap vao 2 so thuc a , b: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao toan tu :");
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
                _ => throw new Exception(),
            };
            Console.WriteLine($"{a} {op} {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Loi khong the chia cho 0!");
        }
        catch (Exception)
        {
            Console.WriteLine("Toan tu khong hop le!");
        }

    }

    static void ptb2()
    {
        Console.Write("Nhap vao 3 so thuc a, b, c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine($"Phuong trinh bac 2 co dang: {a}x^2 + {b}x + c");

        if(a == 0)
        {
            if(b == 0)
            {
                if(c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem!");

                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Phuong trinh co nghiem x = " + x);

            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }else if(delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem phan biet x1 = {x1} , x2 = {x2}");
            }
        }
    }

    static void isPrimeAndFibonacci()
    {
        Console.Write("Nhap vao 1 so nguyen duong N:");
        int n = int.Parse(Console.ReadLine());
        bool check = true;
        if (n < 2)
        {
            check = false;
        }
        else
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    check = false;
                    break;
                }
            }
        }
        if(check == true)
        {
            Console.WriteLine(n + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(n + " khong la so nguyen to");
        }

        //fibo
        int a = 0, b = 1;
        Console.WriteLine($"Danh sach day fibonacci {n} so dau tien la: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(a );
            int next = a + b;
            a = b;
            b = next;
        }

    }
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.Clear();

            Console.WriteLine("=====Menu bai tap=====");
            Console.WriteLine("1.Caculator");
            Console.WriteLine("2.Giai phuong trinh bac 2");
            Console.WriteLine("3.So nguyen to va fibonacci");
            Console.WriteLine("0.Thoat chuong trinh");


            Console.Write("Nhap vao lua chon:");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Lua chon khong hop le!");
                Console.WriteLine("Nhan phim bat ky de tiep tuc..");
                Console.ReadKey();
                continue;
            }

            Console.Clear();


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dang chay bai 1....");
                    Caculator();
                    break;
                case 2:
                    Console.WriteLine("Dang chay bai 2...");
                    ptb2();
                    break;
                case 3:
                    Console.WriteLine("Dang chay bai 3...");
                    isPrimeAndFibonacci();
                    break;
                case 0:
                    Console.WriteLine("Da thoat chuong trinh....0");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;

            }

            if (choice != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nhấn phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }
}