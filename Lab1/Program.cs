using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //bai 1 su dung static class
            UserData.ShowInfo();

            Console.WriteLine("\n=== BAI 2 ===");
            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps { ID = "2024", Name = "URF" };
            Console.WriteLine(maps2.ShowData());

            Console.WriteLine("\n=== BAI 3 ===");
            Calculator calc = new Calculator(10, 5);
            Console.WriteLine("Tổng: " + calc.Cong());
            Console.WriteLine("Hiệu: " + calc.Tru());
            Console.WriteLine("Tích: " + calc.Nhan());
            Console.WriteLine("Thương: " + calc.Chia());
        }
    }
}
