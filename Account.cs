using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_I_do
{
    static class Account
    {
        static List<User> users = new List<User>();
        static string path = $@"{Directory.GetCurrentDirectory()}\Files\Users.json";
        public static void UserlistLoad()
        {
            Json.JsonDeserialization<List<User>>(Account.path, ref users);
        }
        public static void AddUser(User user)
        {
            users.Add(user);
            Json.JsonSerialization(Account.path, users);
        }
        public static User GetUser(int index)
        {
            return users[index];
        }
        public static int Size()
        {
            return users.Count;
        }
    }
}
