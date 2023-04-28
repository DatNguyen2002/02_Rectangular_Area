using System;

namespace AreaR
{
    class Program
    {
        static void Main(string[] args)
        {
            float dai, rong;

            Console.Write("Nhap Chieu Dai: ");
            dai = float.Parse(s: Console.ReadLine());
            Console.Write("Nhap Chieu Rong: ");
            rong = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Dien tich chieu hinh chu nha:"+ (dai*rong));
        }
    }
}