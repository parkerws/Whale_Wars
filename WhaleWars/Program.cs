using System;

namespace WhaleWars
{
    class Program
    {
        public static void Main()
        {
            Management.Title();

            string name = Management.PlayerName();
            

            Management.Mgmt(name);


        }
    }
}