using System;

namespace WhaleWars
{
    public class Item
    {       
        public string Name{get; set;}

        public Item CreateItem(string name)
        {
            Name = name;

        }
    }

}

    