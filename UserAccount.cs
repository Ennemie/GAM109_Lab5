using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class UserAccount
    {
        public string Name;
        public int Rank;
        public float Winrate;
        public string Type;
        public int Skin;

        public UserAccount(string name, int rank, float winrate, string type, int skin)
        {
            Name = name;
            Rank = rank;
            Winrate = winrate;
            Type = type;
            Skin = skin;
        }
        public void XuatInfo()
        {
            Console.WriteLine($"Name: {Name}, Rank: {Rank}, Winrate: {Winrate}, Type: {Type}, Skin: {Skin}");
        }
    }
}
