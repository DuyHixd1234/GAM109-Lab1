using System;

namespace Lab1
{
    public static class UserData
    {
        public static string UserName;
        public static int ID;
        public static int Health;
        public static int Point;

        //static constructor
        static UserData()
        {
            ID = 12275;
            UserName = "Hai";
            Health = 200;
            Point = 100;
        }

        public static void ShowInfo()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("UserName: " + UserName);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Point: " + Point);
        }
    }
}
