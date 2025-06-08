using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bai 1a ===");
            List<UserAccount> list = new List<UserAccount>();
            list.Add(new UserAccount("Son Tung", 10, 55.5f, "Ca Nhac", 50));
            list.Add(new UserAccount("Den Vau", 5, 70, "Ca Nhac", 10));
            list.Add(new UserAccount("Thuy Linh", 15, 45.5f, "Ca Nhac", 25));
            list.Add(new UserAccount("Do Mixi", 1, 90, "ALL", 2));
            list.Add(new UserAccount("Ba Tuyet Diamond", 3, 60.5f, "Am thuc", 10));
            list.Add(new UserAccount("PewPew", 4, 55.5f, "live", 50));
            list.Add(new UserAccount("Lien Minh", 2, 85.5f, "Game", 255));
            list.Add(new UserAccount("Lien Quan", 11, 55.5f, "Game", 200));
            list.Add(new UserAccount("Fifa 4", 5, 45.5f, "Game", 150));
            list.Add(new UserAccount("CSO", 8, 55.5f, "Game", 1000));
            list.Add(new UserAccount("CSGO", 6, 85.5f, "Game", 500));

            foreach(var x in list)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 1b ===");
            var result_1b = list.OrderByDescending(x => x.Rank).ToList();
            foreach(var x in result_1b)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 1c ===");
            var result_1c = list.OrderByDescending(x => x.Name).ThenByDescending(x => x.Skin).ToList();
            foreach (var x in result_1c)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 1d ===");
            var result_1d = list.Where(x => x.Name.StartsWith("B")).ToList();
            foreach (var x in result_1d)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 2a ===");
            var result_2a = list.Where(x => x.Winrate > 50).ToList();
            result_2a = result_2a.OrderByDescending(x => x.Winrate).ToList();
            foreach (var x in result_2a)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 2b ===");
            var Max_Winrate = list.Max(x => x.Winrate);
            var result_2b = list.Where(x => x.Winrate == Max_Winrate).ToList();
            foreach (var x in result_2b)
            {
                x.XuatInfo();
            }

            Console.WriteLine("\n=== Bai 2c ===");
            Console.WriteLine($"Danh sach UserAccount co {list.Count} Users");

            Console.WriteLine("\n=== Bai 3 ===");
            var result_3 = list.ToLookup(x => x.Type);
            foreach(var x in result_3)
            {
                Console.WriteLine($"Type: {x.Key} - Count: {x.Count()}");
                foreach(var y in x)
                {
                    Console.Write("- ");
                    y.XuatInfo();
                }
            }
        }
    }
}
