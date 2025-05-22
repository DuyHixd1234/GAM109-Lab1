using System;

namespace Lab1
{
    class Maps
    {
        public string ID;
        public string Name;
        public static string _inGame = "lien minh huyen thoai";

        public Maps() { }

        public Maps(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public string ShowData()
        {
            return "ID: " + ID + " | Name: " + Name + " | inGame: " + _inGame;
        }
    }
}
