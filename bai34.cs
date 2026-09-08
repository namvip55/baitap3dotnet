using System;
/***Mục tiêu:** Xây dựng kiến trúc Console Menu chuẩn, xử lý lặp lại cho đến khi chọn Thoát.
**Yêu cầu (Requirements):**
1. Sử dụng vòng lặp `do-while` để giữ chương trình luôn chạy.
2. Hiển thị Menu gồm các lựa chọn:
- 1. Chạy Bài tập 1 (Calculator)
- 2. Chạy Bài tập 2 (Phương trình bậc 2)
- 3. Chạy Bài tập 3 (Số nguyên tố & Fibonacci)
- 0. Thoát chương trình
3. Xử lý xóa màn hình `Console.Clear()` và tạm dừng `Console.ReadKey()` mượt mà.*/
class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("===== MENU BÀI TẬP =====");
            Console.WriteLine("1. Chạy Bài tập 1 (Calculator)");
            Console.WriteLine("2. Chạy Bài tập 2 (Phương trình bậc 2)");
            Console.WriteLine("3. Chạy Bài tập 3 (Số nguyên tố & Fibonacci)");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("========================");
            Console.Write("Nhập lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("===== BÀI TẬP 1: CALCULATOR =====");

                    // Gọi code Calculator ở đây
                    Console.WriteLine("Đang chạy Calculator...");

                    break;

                case 2:
                    Console.WriteLine("===== BÀI TẬP 2: PHƯƠNG TRÌNH BẬC 2 =====");

                    // Gọi code phương trình bậc 2 ở đây
                    Console.WriteLine("Đang chạy phương trình bậc 2...");

                    break;

                case 3:
                    Console.WriteLine("===== BÀI TẬP 3: SỐ NGUYÊN TỐ & FIBONACCI =====");

                    // Gọi code số nguyên tố & Fibonacci ở đây
                    Console.WriteLine("Đang chạy bài tập 3...");

                    break;

                case 0:
                    Console.WriteLine("Đã thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

            // Không dừng khi đã chọn Thoát
            if (choice != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nhấn phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }
}
