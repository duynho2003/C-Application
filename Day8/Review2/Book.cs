using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review2
{
    public class Book : Library
    {
        string title;
        double price;
        bool isSale;

        public string Title
        {
            get { return title; }
            set
            {
                string titlePat = @"[A-za-z0-9\s]+";
                Regex reg = new Regex(titlePat);
                if (reg.IsMatch(value))
                {
                    title = value;
                }
                else
                {
                    throw new Exception();
                }
                title = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public bool IsSale
        {
            get { return isSale; }
            set
            {
                isSale = value;
            }
        }
        public override void bookInfo()
        {
            string sSale = isSale ? "Sale" : "None";
            Console.WriteLine($"Title: {title}, Price: {price}, Isale: {sSale}");
        }

        public void Input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input Title: ");
                    Title = Console.ReadLine();
                    break;
                }
                catch
                {
                    Console.WriteLine("Title only contains letters, digits and white space!");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Input Price: ");
                    Price = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Price must be greater than zero. ");
                }
            }

            while (true)
            {
                Console.WriteLine("Input Isale (true/false): ");
                string userInput = Console.ReadLine()!;

                // Kiểm tra xem người dùng nhập "true" hay "false"
                if (bool.TryParse(userInput, out bool isSaleValue))
                {
                    // Nếu người dùng nhập đúng kiểu bool (true hoặc false) thì gán giá trị cho thuộc tính IsSale và thoát khỏi vòng lặp
                    IsSale = isSaleValue;
                    break;
                }
                // Nếu người dùng nhập sai, hiển thị thông báo lỗi
                Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
            }
        }
    }
}